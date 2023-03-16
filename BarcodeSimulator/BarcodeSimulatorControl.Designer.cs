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
            this.label5 = new System.Windows.Forms.Label();
            this.RandomLengthTextBox = new System.Windows.Forms.TextBox();
            this.AddRandomButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
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
            this.delayNumeric.Location = new System.Drawing.Point(105, 33);
            this.delayNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.delayNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayNumeric.Name = "delayNumeric";
            this.delayNumeric.Size = new System.Drawing.Size(160, 22);
            this.delayNumeric.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key Delay";
            // 
            // newStringTextBox
            // 
            this.newStringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newStringTextBox.Location = new System.Drawing.Point(12, 53);
            this.newStringTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newStringTextBox.MaxLength = 50;
            this.newStringTextBox.Name = "newStringTextBox";
            this.newStringTextBox.Size = new System.Drawing.Size(329, 22);
            this.newStringTextBox.TabIndex = 3;
            this.newStringTextBox.TextChanged += new System.EventHandler(this.newStringTextBox_TextChanged);
            this.newStringTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newStringTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hotkey";
            // 
            // hotkeyTextBox
            // 
            this.hotkeyTextBox.Location = new System.Drawing.Point(105, 65);
            this.hotkeyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hotkeyTextBox.Name = "hotkeyTextBox";
            this.hotkeyTextBox.ReadOnly = true;
            this.hotkeyTextBox.Size = new System.Drawing.Size(159, 22);
            this.hotkeyTextBox.TabIndex = 5;
            this.hotkeyTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Add Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "End With";
            // 
            // endsWithComboBox
            // 
            this.endsWithComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endsWithComboBox.FormattingEnabled = true;
            this.endsWithComboBox.Location = new System.Drawing.Point(104, 97);
            this.endsWithComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.endsWithComboBox.Name = "endsWithComboBox";
            this.endsWithComboBox.Size = new System.Drawing.Size(160, 24);
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
            this.itemsListView.HideSelection = false;
            this.itemsListView.HoverSelection = true;
            this.itemsListView.Location = new System.Drawing.Point(12, 85);
            this.itemsListView.Margin = new System.Windows.Forms.Padding(4);
            this.itemsListView.MultiSelect = false;
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(421, 240);
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
            this.itemsGroupBox.Controls.Add(this.label5);
            this.itemsGroupBox.Controls.Add(this.RandomLengthTextBox);
            this.itemsGroupBox.Controls.Add(this.AddRandomButton);
            this.itemsGroupBox.Controls.Add(this.ClearButton);
            this.itemsGroupBox.Controls.Add(this.newCodeTypeLabel);
            this.itemsGroupBox.Controls.Add(this.itemsListView);
            this.itemsGroupBox.Controls.Add(this.label3);
            this.itemsGroupBox.Controls.Add(this.newStringTextBox);
            this.itemsGroupBox.Location = new System.Drawing.Point(16, 167);
            this.itemsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.itemsGroupBox.Size = new System.Drawing.Size(453, 396);
            this.itemsGroupBox.TabIndex = 14;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Barcodes";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Random length";
            // 
            // RandomLengthTextBox
            // 
            this.RandomLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomLengthTextBox.Location = new System.Drawing.Point(222, 366);
            this.RandomLengthTextBox.Name = "RandomLengthTextBox";
            this.RandomLengthTextBox.Size = new System.Drawing.Size(95, 22);
            this.RandomLengthTextBox.TabIndex = 17;
            this.RandomLengthTextBox.Text = "10";
            // 
            // AddRandomButton
            // 
            this.AddRandomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRandomButton.Location = new System.Drawing.Point(93, 366);
            this.AddRandomButton.Name = "AddRandomButton";
            this.AddRandomButton.Size = new System.Drawing.Size(113, 23);
            this.AddRandomButton.TabIndex = 16;
            this.AddRandomButton.Text = "Add Random";
            this.AddRandomButton.UseVisualStyleBackColor = true;
            this.AddRandomButton.Click += new System.EventHandler(this.AddRandomButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.Location = new System.Drawing.Point(10, 366);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // newCodeTypeLabel
            // 
            this.newCodeTypeLabel.AutoSize = true;
            this.newCodeTypeLabel.Location = new System.Drawing.Point(236, 57);
            this.newCodeTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newCodeTypeLabel.Name = "newCodeTypeLabel";
            this.newCodeTypeLabel.Size = new System.Drawing.Size(0, 16);
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
            this.configurationGroupBox.Location = new System.Drawing.Point(16, 15);
            this.configurationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.configurationGroupBox.Size = new System.Drawing.Size(453, 145);
            this.configurationGroupBox.TabIndex = 15;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Configuration";
            // 
            // BarcodeSimulatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 573);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.itemsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RandomLengthTextBox;
        private System.Windows.Forms.Button AddRandomButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

