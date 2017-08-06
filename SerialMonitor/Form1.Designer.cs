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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.device = new System.IO.Ports.SerialPort(this.components);
            this.portSelect = new System.Windows.Forms.ComboBox();
            this.portSelectLabel = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.baudSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.transmitGroup = new System.Windows.Forms.GroupBox();
            this.sendDataButton = new System.Windows.Forms.Button();
            this.sendDataTextbox = new System.Windows.Forms.TextBox();
            this.receiveBoxLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.receiveGroup = new System.Windows.Forms.GroupBox();
            this.receivedTextBox = new System.Windows.Forms.TextBox();
            this.chartLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.testChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.transmitGroup.SuspendLayout();
            this.receiveBoxLayoutPanel.SuspendLayout();
            this.receiveGroup.SuspendLayout();
            this.chartLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).BeginInit();
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
            // transmitGroup
            // 
            this.transmitGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transmitGroup.Controls.Add(this.sendDataButton);
            this.transmitGroup.Controls.Add(this.sendDataTextbox);
            this.transmitGroup.Location = new System.Drawing.Point(3, 269);
            this.transmitGroup.Name = "transmitGroup";
            this.transmitGroup.Size = new System.Drawing.Size(986, 128);
            this.transmitGroup.TabIndex = 1;
            this.transmitGroup.TabStop = false;
            this.transmitGroup.Text = "Transmit Data";
            // 
            // sendDataButton
            // 
            this.sendDataButton.Enabled = false;
            this.sendDataButton.Location = new System.Drawing.Point(801, 42);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(126, 55);
            this.sendDataButton.TabIndex = 1;
            this.sendDataButton.Text = "Send";
            this.sendDataButton.UseVisualStyleBackColor = true;
            this.sendDataButton.Click += new System.EventHandler(this.sendDataButton_Click);
            // 
            // sendDataTextbox
            // 
            this.sendDataTextbox.Enabled = false;
            this.sendDataTextbox.Location = new System.Drawing.Point(12, 54);
            this.sendDataTextbox.Name = "sendDataTextbox";
            this.sendDataTextbox.Size = new System.Drawing.Size(764, 29);
            this.sendDataTextbox.TabIndex = 0;
            // 
            // receiveBoxLayoutPanel
            // 
            this.receiveBoxLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveBoxLayoutPanel.ColumnCount = 1;
            this.receiveBoxLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.receiveBoxLayoutPanel.Controls.Add(this.receiveGroup, 0, 0);
            this.receiveBoxLayoutPanel.Controls.Add(this.transmitGroup, 0, 1);
            this.receiveBoxLayoutPanel.Location = new System.Drawing.Point(17, 85);
            this.receiveBoxLayoutPanel.MaximumSize = new System.Drawing.Size(1000, 600);
            this.receiveBoxLayoutPanel.Name = "receiveBoxLayoutPanel";
            this.receiveBoxLayoutPanel.RowCount = 2;
            this.receiveBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.receiveBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.receiveBoxLayoutPanel.Size = new System.Drawing.Size(992, 400);
            this.receiveBoxLayoutPanel.TabIndex = 8;
            // 
            // receiveGroup
            // 
            this.receiveGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveGroup.Controls.Add(this.receivedTextBox);
            this.receiveGroup.Location = new System.Drawing.Point(3, 3);
            this.receiveGroup.Name = "receiveGroup";
            this.receiveGroup.Size = new System.Drawing.Size(986, 260);
            this.receiveGroup.TabIndex = 8;
            this.receiveGroup.TabStop = false;
            this.receiveGroup.Text = "Data Received";
            // 
            // receivedTextBox
            // 
            this.receivedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receivedTextBox.Location = new System.Drawing.Point(3, 25);
            this.receivedTextBox.Multiline = true;
            this.receivedTextBox.Name = "receivedTextBox";
            this.receivedTextBox.ReadOnly = true;
            this.receivedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivedTextBox.Size = new System.Drawing.Size(980, 232);
            this.receivedTextBox.TabIndex = 0;
            // 
            // chartLayoutPanel
            // 
            this.chartLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartLayoutPanel.Controls.Add(this.testChart);
            this.chartLayoutPanel.Location = new System.Drawing.Point(1052, 12);
            this.chartLayoutPanel.Name = "chartLayoutPanel";
            this.chartLayoutPanel.Size = new System.Drawing.Size(476, 473);
            this.chartLayoutPanel.TabIndex = 9;
            // 
            // testChart
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.testChart.ChartAreas.Add(chartArea1);
            this.testChart.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.testChart.Legends.Add(legend1);
            this.testChart.Location = new System.Drawing.Point(3, 3);
            this.testChart.Name = "testChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "testPoints";
            this.testChart.Series.Add(series1);
            this.testChart.Series.Add(series2);
            this.testChart.Size = new System.Drawing.Size(477, 467);
            this.testChart.TabIndex = 0;
            this.testChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 536);
            this.Controls.Add(this.chartLayoutPanel);
            this.Controls.Add(this.receiveBoxLayoutPanel);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudSelect);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.portSelectLabel);
            this.Controls.Add(this.portSelect);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.Text = "Ground Station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.transmitGroup.ResumeLayout(false);
            this.transmitGroup.PerformLayout();
            this.receiveBoxLayoutPanel.ResumeLayout(false);
            this.receiveGroup.ResumeLayout(false);
            this.receiveGroup.PerformLayout();
            this.chartLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).EndInit();
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
        private System.Windows.Forms.GroupBox transmitGroup;
        private System.Windows.Forms.TextBox sendDataTextbox;
        private System.Windows.Forms.Button sendDataButton;
        private System.Windows.Forms.TableLayoutPanel receiveBoxLayoutPanel;
        private System.Windows.Forms.GroupBox receiveGroup;
        private System.Windows.Forms.TextBox receivedTextBox;
        private System.Windows.Forms.FlowLayoutPanel chartLayoutPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart testChart;
    }
}

