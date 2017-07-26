namespace SerialMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.device = new System.IO.Ports.SerialPort(this.components);
            this.portSelect = new System.Windows.Forms.ComboBox();
            this.portSelectLabel = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.baudSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.receiveGroup = new System.Windows.Forms.GroupBox();
            this.receivedTextBox = new System.Windows.Forms.TextBox();
            this.transmitGroup = new System.Windows.Forms.GroupBox();
            this.sendDataTextbox = new System.Windows.Forms.TextBox();
            this.sendDataButton = new System.Windows.Forms.Button();
            this.receiveGroup.SuspendLayout();
            this.transmitGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // device
            // 
            this.device.PortName = "COM3";
            // 
            // portSelect
            // 
            this.portSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portSelect.FormattingEnabled = true;
            this.portSelect.Location = new System.Drawing.Point(32, 30);
            this.portSelect.Name = "portSelect";
            this.portSelect.Size = new System.Drawing.Size(149, 32);
            this.portSelect.TabIndex = 0;
            this.portSelect.SelectedIndexChanged += new System.EventHandler(this.portSelect_SelectedIndexChanged);
            // 
            // portSelectLabel
            // 
            this.portSelectLabel.AutoSize = true;
            this.portSelectLabel.Location = new System.Drawing.Point(12, 2);
            this.portSelectLabel.Name = "portSelectLabel";
            this.portSelectLabel.Size = new System.Drawing.Size(107, 25);
            this.portSelectLabel.TabIndex = 1;
            this.portSelectLabel.Text = "Select Port";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(202, 26);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(111, 39);
            this.scanButton.TabIndex = 2;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // baudSelect
            // 
            this.baudSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudSelect.FormattingEnabled = true;
            this.baudSelect.Location = new System.Drawing.Point(382, 30);
            this.baudSelect.Name = "baudSelect";
            this.baudSelect.Size = new System.Drawing.Size(175, 32);
            this.baudSelect.TabIndex = 3;
            this.baudSelect.SelectedIndexChanged += new System.EventHandler(this.baudSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Baud";
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(630, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(135, 67);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(782, 12);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(146, 67);
            this.disconnectButton.TabIndex = 6;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // receiveGroup
            // 
            this.receiveGroup.Controls.Add(this.receivedTextBox);
            this.receiveGroup.Location = new System.Drawing.Point(17, 112);
            this.receiveGroup.Name = "receiveGroup";
            this.receiveGroup.Size = new System.Drawing.Size(942, 296);
            this.receiveGroup.TabIndex = 7;
            this.receiveGroup.TabStop = false;
            this.receiveGroup.Text = "Data Received";
            // 
            // receivedTextBox
            // 
            this.receivedTextBox.Location = new System.Drawing.Point(15, 28);
            this.receivedTextBox.Multiline = true;
            this.receivedTextBox.Name = "receivedTextBox";
            this.receivedTextBox.ReadOnly = true;
            this.receivedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivedTextBox.Size = new System.Drawing.Size(912, 262);
            this.receivedTextBox.TabIndex = 0;
            // 
            // transmitGroup
            // 
            this.transmitGroup.Controls.Add(this.sendDataButton);
            this.transmitGroup.Controls.Add(this.sendDataTextbox);
            this.transmitGroup.Location = new System.Drawing.Point(17, 408);
            this.transmitGroup.Name = "transmitGroup";
            this.transmitGroup.Size = new System.Drawing.Size(942, 106);
            this.transmitGroup.TabIndex = 1;
            this.transmitGroup.TabStop = false;
            this.transmitGroup.Text = "Transmit Data";
            // 
            // sendDataTextbox
            // 
            this.sendDataTextbox.Enabled = false;
            this.sendDataTextbox.Location = new System.Drawing.Point(15, 45);
            this.sendDataTextbox.Name = "sendDataTextbox";
            this.sendDataTextbox.Size = new System.Drawing.Size(764, 29);
            this.sendDataTextbox.TabIndex = 0;
            // 
            // sendDataButton
            // 
            this.sendDataButton.Enabled = false;
            this.sendDataButton.Location = new System.Drawing.Point(801, 28);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(126, 55);
            this.sendDataButton.TabIndex = 1;
            this.sendDataButton.Text = "Send";
            this.sendDataButton.UseVisualStyleBackColor = true;
            this.sendDataButton.Click += new System.EventHandler(this.sendDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 524);
            this.Controls.Add(this.transmitGroup);
            this.Controls.Add(this.receiveGroup);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudSelect);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.portSelectLabel);
            this.Controls.Add(this.portSelect);
            this.Name = "Form1";
            this.Text = "Ground Station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.receiveGroup.ResumeLayout(false);
            this.receiveGroup.PerformLayout();
            this.transmitGroup.ResumeLayout(false);
            this.transmitGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort device;
        private System.Windows.Forms.ComboBox portSelect;
        private System.Windows.Forms.Label portSelectLabel;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.ComboBox baudSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.GroupBox receiveGroup;
        private System.Windows.Forms.TextBox receivedTextBox;
        private System.Windows.Forms.GroupBox transmitGroup;
        private System.Windows.Forms.TextBox sendDataTextbox;
        private System.Windows.Forms.Button sendDataButton;
    }
}

