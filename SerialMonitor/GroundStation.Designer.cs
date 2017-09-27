namespace SerialMonitor
{
    partial class GroundStation
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
            this.portSelect.Location = new System.Drawing.Point(23, 20);
            this.portSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portSelect.Name = "portSelect";
            this.portSelect.Size = new System.Drawing.Size(109, 24);
            this.portSelect.TabIndex = 0;
            this.portSelect.SelectedIndexChanged += new System.EventHandler(this.portSelect_SelectedIndexChanged);
            // 
            // portSelectLabel
            // 
            this.portSelectLabel.AutoSize = true;
            this.portSelectLabel.Location = new System.Drawing.Point(9, 1);
            this.portSelectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portSelectLabel.Name = "portSelectLabel";
            this.portSelectLabel.Size = new System.Drawing.Size(77, 17);
            this.portSelectLabel.TabIndex = 1;
            this.portSelectLabel.Text = "Select Port";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(147, 17);
            this.scanButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(81, 26);
            this.scanButton.TabIndex = 2;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // baudSelect
            // 
            this.baudSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudSelect.FormattingEnabled = true;
            this.baudSelect.Location = new System.Drawing.Point(278, 20);
            this.baudSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baudSelect.Name = "baudSelect";
            this.baudSelect.Size = new System.Drawing.Size(128, 24);
            this.baudSelect.TabIndex = 3;
            this.baudSelect.SelectedIndexChanged += new System.EventHandler(this.baudSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Baud";
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(455, 8);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(98, 45);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(569, 8);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(106, 45);
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
            this.transmitGroup.Location = new System.Drawing.Point(2, 180);
            this.transmitGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transmitGroup.Name = "transmitGroup";
            this.transmitGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transmitGroup.Size = new System.Drawing.Size(717, 85);
            this.transmitGroup.TabIndex = 1;
            this.transmitGroup.TabStop = false;
            this.transmitGroup.Text = "Transmit Data";
            // 
            // sendDataButton
            // 
            this.sendDataButton.Enabled = false;
            this.sendDataButton.Location = new System.Drawing.Point(583, 28);
            this.sendDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(92, 37);
            this.sendDataButton.TabIndex = 1;
            this.sendDataButton.Text = "Send";
            this.sendDataButton.UseVisualStyleBackColor = true;
            this.sendDataButton.Click += new System.EventHandler(this.sendDataButton_Click);
            // 
            // sendDataTextbox
            // 
            this.sendDataTextbox.Enabled = false;
            this.sendDataTextbox.Location = new System.Drawing.Point(9, 36);
            this.sendDataTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendDataTextbox.Name = "sendDataTextbox";
            this.sendDataTextbox.Size = new System.Drawing.Size(557, 22);
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
            this.receiveBoxLayoutPanel.Location = new System.Drawing.Point(12, 57);
            this.receiveBoxLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receiveBoxLayoutPanel.MaximumSize = new System.Drawing.Size(727, 400);
            this.receiveBoxLayoutPanel.Name = "receiveBoxLayoutPanel";
            this.receiveBoxLayoutPanel.RowCount = 2;
            this.receiveBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.receiveBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.receiveBoxLayoutPanel.Size = new System.Drawing.Size(721, 267);
            this.receiveBoxLayoutPanel.TabIndex = 8;
            // 
            // receiveGroup
            // 
            this.receiveGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveGroup.Controls.Add(this.receivedTextBox);
            this.receiveGroup.Location = new System.Drawing.Point(2, 2);
            this.receiveGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receiveGroup.Name = "receiveGroup";
            this.receiveGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receiveGroup.Size = new System.Drawing.Size(717, 174);
            this.receiveGroup.TabIndex = 8;
            this.receiveGroup.TabStop = false;
            this.receiveGroup.Text = "Data Received";
            // 
            // receivedTextBox
            // 
            this.receivedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receivedTextBox.Location = new System.Drawing.Point(2, 17);
            this.receivedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receivedTextBox.Multiline = true;
            this.receivedTextBox.Name = "receivedTextBox";
            this.receivedTextBox.ReadOnly = true;
            this.receivedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivedTextBox.Size = new System.Drawing.Size(713, 155);
            this.receivedTextBox.TabIndex = 0;
            // 
            // chartLayoutPanel
            // 
            this.chartLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartLayoutPanel.Controls.Add(this.testChart);
            this.chartLayoutPanel.Location = new System.Drawing.Point(765, 8);
            this.chartLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartLayoutPanel.Name = "chartLayoutPanel";
            this.chartLayoutPanel.Size = new System.Drawing.Size(346, 315);
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
            this.testChart.Location = new System.Drawing.Point(2, 2);
            this.testChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.testChart.Size = new System.Drawing.Size(347, 311);
            this.testChart.TabIndex = 0;
            this.testChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 369);
            this.Controls.Add(this.chartLayoutPanel);
            this.Controls.Add(this.receiveBoxLayoutPanel);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudSelect);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.portSelectLabel);
            this.Controls.Add(this.portSelect);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(878, 416);
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

