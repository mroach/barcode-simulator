namespace BarcodeSimulator {
    partial class BarcodeSimulatorControl {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeSimulatorControl));
            this.delayNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.newStringTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hotkeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endsWithComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // delayNumeric
            // 
            this.delayNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.delayNumeric.Location = new System.Drawing.Point(85, 12);
            this.delayNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayNumeric.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.delayNumeric.Name = "delayNumeric";
            this.delayNumeric.Size = new System.Drawing.Size(120, 20);
            this.delayNumeric.TabIndex = 1;
            this.delayNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key Delay";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemsListBox.Location = new System.Drawing.Point(15, 164);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(256, 121);
            this.itemsListBox.TabIndex = 4;
            this.itemsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemsListBox_KeyDown);
            // 
            // newStringTextBox
            // 
            this.newStringTextBox.Location = new System.Drawing.Point(85, 138);
            this.newStringTextBox.MaxLength = 50;
            this.newStringTextBox.Name = "newStringTextBox";
            this.newStringTextBox.Size = new System.Drawing.Size(120, 20);
            this.newStringTextBox.TabIndex = 3;
            this.newStringTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newStringTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hotkey";
            // 
            // hotkeyTextBox
            // 
            this.hotkeyTextBox.Location = new System.Drawing.Point(85, 38);
            this.hotkeyTextBox.Name = "hotkeyTextBox";
            this.hotkeyTextBox.ReadOnly = true;
            this.hotkeyTextBox.Size = new System.Drawing.Size(120, 20);
            this.hotkeyTextBox.TabIndex = 5;
            this.hotkeyTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Add String";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "End With";
            // 
            // endsWithComboBox
            // 
            this.endsWithComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endsWithComboBox.FormattingEnabled = true;
            this.endsWithComboBox.Location = new System.Drawing.Point(84, 64);
            this.endsWithComboBox.Name = "endsWithComboBox";
            this.endsWithComboBox.Size = new System.Drawing.Size(121, 21);
            this.endsWithComboBox.TabIndex = 2;
            // 
            // BarcodeSimulatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 297);
            this.Controls.Add(this.endsWithComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hotkeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newStringTextBox);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delayNumeric);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarcodeSimulatorControl";
            this.Text = "Barcode Simulator";
            this.Load += new System.EventHandler(this.BarcodeSimulatorControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delayNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown delayNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.TextBox newStringTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hotkeyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox endsWithComboBox;
    }
}

