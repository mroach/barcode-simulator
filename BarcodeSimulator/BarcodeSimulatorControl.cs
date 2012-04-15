using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BarcodeSimulator
{

    public partial class BarcodeSimulatorControl : Form
    {

        public BarcodeSimulatorControl()
        {
            InitializeComponent();
        }

        private void BarcodeSimulatorControl_Load(object sender, EventArgs e)
        {
            // setup a new Hotkey to watch for Windows+Z
            // this could/should be configurable on the form
            var hk = new Hotkey(Keys.Z, shift: false, control: false, alt: false, windows: true);
            hk.Pressed += HotkeyPressed;
            hk.Register(this);

            // show the hotkey on the form as an FYI
            hotkeyTextBox.Text = hk.ToString();

            // list all available keys in the 'ends with' drop down
            Enum.GetNames(typeof (Keys)).ToList().ForEach(k => endsWithComboBox.Items.Add(k));

            // focus on the text box for adding new string
            ActiveControl = newStringTextBox;

            SetupToolTips();
        }

        private void SetupToolTips()
        {
            var tt = new ToolTip {InitialDelay = 500, ReshowDelay = 500, ShowAlways = true};
            
            tt.SetToolTip(delayNumeric, "Delay in milliseconds between each keypress when sending a barcode.");
            tt.SetToolTip(hotkeyTextBox, "Activation key sequence. Press " + hotkeyTextBox.Text + " to send the next barcode.");
            tt.SetToolTip(endsWithComboBox, "Optionally ends each barcode sending with this key.");
            tt.SetToolTip(newStringTextBox, "Enter a series of characters you want to simulate. Press Enter to add it.");
            tt.SetToolTip(itemsListBox, "List of barcodes to send. Sends in order round-robin style. Select one and press Delete to remove it.");
        }

        private void HotkeyPressed(object sender, HandledEventArgs e)
        {
            if (itemsListBox.Items.Count == 0)
            {
                MessageBox.Show("You have to add some strings to the list first.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var endKey = Keys.None;

            if (endsWithComboBox.SelectedIndex > 0)
                Enum.TryParse(endsWithComboBox.SelectedItem.ToString(), out endKey);

            var s = Pop();

            // do the delayed key sending in a separate thread so we don't hang the window
            ThreadStart starter = () => StartSending(s, (int) delayNumeric.Value, endKey);
            var t = new Thread(starter);
            t.Start();
        }

        private static void StartSending(string text, int delay, Keys endKey = Keys.None)
        {

            foreach (var s in text.Select(character => character.ToString()))
            {
                Debug.WriteLine("{0} Sending text '{1}'", DateTime.Now.ToString("HH:mm:ss.fff"), s);
                SendKeys.SendWait(s);
                SendKeys.Flush();
                Thread.Sleep(delay);
            }

            // if configured, send an 'end' key to signal that we're at the end of the barcode
            if (endKey != Keys.None)
                SendKeys.SendWait("{" + Enum.GetName(typeof (Keys), endKey) + "}");

            // beep!
            System.Media.SystemSounds.Beep.Play();
        }

        /// <summary>
        /// Get the next value from the list of items and advance the selection
        /// If we're at the end of the list, go back to the beginning
        /// </summary>
        /// <returns></returns>
        private string Pop()
        {
            if (itemsListBox.SelectedIndex == -1)
                itemsListBox.SelectedIndex = 0;

            var s = itemsListBox.SelectedItem.ToString();

            if (itemsListBox.SelectedIndex == itemsListBox.Items.Count - 1)
                itemsListBox.SelectedIndex = 0;
            else
                itemsListBox.SelectedIndex++;

            return s;
        }

        /// <summary>
        /// Ignore all key entry aside from Enter. Enter adds the value to the
        /// string list and clears the new string entry text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newStringTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            itemsListBox.Items.Add(newStringTextBox.Text);
            newStringTextBox.Clear();
        }

        /// <summary>
        /// Handle deleting items from the string list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                return;

            if (itemsListBox.SelectedIndex == -1)
                return;

            itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);
        }
    }
}
