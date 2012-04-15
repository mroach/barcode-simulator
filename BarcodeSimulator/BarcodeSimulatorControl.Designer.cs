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
            this.newStringTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hotkeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endsWithComboBox = new System.Windows.Forms.ComboBox();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.newCodeTypeLabel = new System.Windows.Forms.Label();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumeric)).BeginInit();
            this.itemsGroupBox.SuspendLayout();
            this.configurationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // delayNumeric
            // 
            this.delayNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.delayNumeric.Location = new System.Drawing.Point(79, 27);
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
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key Delay";
            // 
            // newStringTextBox
            // 
            this.newStringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newStringTextBox.Location = new System.Drawing.Point(9, 43);
            this.newStringTextBox.MaxLength = 50;
            this.newStringTextBox.Name = "newStringTextBox";
            this.newStringTextBox.Size = new System.Drawing.Size(162, 20);
            this.newStringTextBox.TabIndex = 3;
            this.newStringTextBox.TextChanged += new System.EventHandler(this.newStringTextBox_TextChanged);
            this.newStringTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newStringTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hotkey";
            // 
            // hotkeyTextBox
            // 
            this.hotkeyTextBox.Location = new System.Drawing.Point(79, 53);
            this.hotkeyTextBox.Name = "hotkeyTextBox";
            this.hotkeyTextBox.ReadOnly = true;
            this.hotkeyTextBox.Size = new System.Drawing.Size(120, 20);
            this.hotkeyTextBox.TabIndex = 5;
            this.hotkeyTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Add Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "End With";
            // 
            // endsWithComboBox
            // 
            this.endsWithComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endsWithComboBox.FormattingEnabled = true;
            this.endsWithComboBox.Location = new System.Drawing.Point(78, 79);
            this.endsWithComboBox.Name = "endsWithComboBox";
            this.endsWithComboBox.Size = new System.Drawing.Size(121, 21);
            this.endsWithComboBox.TabIndex = 2;
            // 
            // itemsListView
            // 
            this.itemsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.itemsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.itemsListView.FullRowSelect = true;
            this.itemsListView.HoverSelection = true;
            this.itemsListView.Location = new System.Drawing.Point(9, 69);
            this.itemsListView.MultiSelect = false;
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(231, 179);
            this.itemsListView.TabIndex = 13;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            this.itemsListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemsListView_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 80;
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsGroupBox.Controls.Add(this.newCodeTypeLabel);
            this.itemsGroupBox.Controls.Add(this.itemsListView);
            this.itemsGroupBox.Controls.Add(this.label3);
            this.itemsGroupBox.Controls.Add(this.newStringTextBox);
            this.itemsGroupBox.Location = new System.Drawing.Point(12, 136);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(254, 264);
            this.itemsGroupBox.TabIndex = 14;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Barcodes";
            // 
            // newCodeTypeLabel
            // 
            this.newCodeTypeLabel.AutoSize = true;
            this.newCodeTypeLabel.Location = new System.Drawing.Point(177, 46);
            this.newCodeTypeLabel.Name = "newCodeTypeLabel";
            this.newCodeTypeLabel.Size = new System.Drawing.Size(0, 13);
            this.newCodeTypeLabel.TabIndex = 14;
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationGroupBox.Controls.Add(this.label2);
            this.configurationGroupBox.Controls.Add(this.delayNumeric);
            this.configurationGroupBox.Controls.Add(this.endsWithComboBox);
            this.configurationGroupBox.Controls.Add(this.label1);
            this.configurationGroupBox.Controls.Add(this.label4);
            this.configurationGroupBox.Controls.Add(this.hotkeyTextBox);
            this.configurationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(254, 118);
            this.configurationGroupBox.TabIndex = 15;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Configuration";
            // 
            // BarcodeSimulatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 408);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.itemsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarcodeSimulatorControl";
            this.Text = "Barcode Simulator";
            this.Load += new System.EventHandler(this.BarcodeSimulatorControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delayNumeric)).EndInit();
            this.itemsGroupBox.ResumeLayout(false);
            this.itemsGroupBox.PerformLayout();
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown delayNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newStringTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hotkeyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox endsWithComboBox;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.Label newCodeTypeLabel;
    }
}

