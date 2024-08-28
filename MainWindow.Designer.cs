namespace PingGraf
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            splitContainer1 = new SplitContainer();
            panel5 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            PLLabel = new Label();
            PLVal = new Label();
            AVGLabel = new Label();
            AVGVal = new Label();
            MIN = new Label();
            MINVal = new Label();
            MAX = new Label();
            MAXVal = new Label();
            SQLabel = new Label();
            SQVal = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            TimeoutBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            TargetAddressBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            IntervalBox = new NumericUpDown();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IntervalBox).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel5);
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(chart1);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(1040, 457);
            splitContainer1.SplitterDistance = 138;
            splitContainer1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel1);
            panel5.Location = new Point(797, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(122, 127);
            panel5.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(PLLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(PLVal, 1, 0);
            tableLayoutPanel1.Controls.Add(AVGLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(AVGVal, 1, 1);
            tableLayoutPanel1.Controls.Add(MIN, 0, 2);
            tableLayoutPanel1.Controls.Add(MINVal, 1, 2);
            tableLayoutPanel1.Controls.Add(MAX, 0, 3);
            tableLayoutPanel1.Controls.Add(MAXVal, 1, 3);
            tableLayoutPanel1.Controls.Add(SQLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(SQVal, 1, 4);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(116, 121);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PLLabel
            // 
            PLLabel.AutoSize = true;
            PLLabel.Location = new Point(3, 0);
            PLLabel.Name = "PLLabel";
            PLLabel.Size = new Size(20, 15);
            PLLabel.TabIndex = 0;
            PLLabel.Text = "PL";
            // 
            // PLVal
            // 
            PLVal.AutoSize = true;
            PLVal.Location = new Point(42, 0);
            PLVal.Name = "PLVal";
            PLVal.Size = new Size(23, 15);
            PLVal.TabIndex = 1;
            PLVal.Text = "0%";
            // 
            // AVGLabel
            // 
            AVGLabel.AutoSize = true;
            AVGLabel.Location = new Point(3, 15);
            AVGLabel.Name = "AVGLabel";
            AVGLabel.Size = new Size(29, 15);
            AVGLabel.TabIndex = 2;
            AVGLabel.Text = "AVG";
            // 
            // AVGVal
            // 
            AVGVal.AutoSize = true;
            AVGVal.Location = new Point(42, 15);
            AVGVal.Name = "AVGVal";
            AVGVal.Size = new Size(29, 15);
            AVGVal.TabIndex = 3;
            AVGVal.Text = "0ms";
            // 
            // MIN
            // 
            MIN.AutoSize = true;
            MIN.Location = new Point(3, 30);
            MIN.Name = "MIN";
            MIN.Size = new Size(30, 15);
            MIN.TabIndex = 4;
            MIN.Text = "MIN";
            // 
            // MINVal
            // 
            MINVal.AutoSize = true;
            MINVal.Location = new Point(42, 30);
            MINVal.Name = "MINVal";
            MINVal.Size = new Size(29, 15);
            MINVal.TabIndex = 5;
            MINVal.Text = "0ms";
            // 
            // MAX
            // 
            MAX.AutoSize = true;
            MAX.Location = new Point(3, 45);
            MAX.Name = "MAX";
            MAX.Size = new Size(33, 15);
            MAX.TabIndex = 6;
            MAX.Text = "MAX";
            // 
            // MAXVal
            // 
            MAXVal.AutoSize = true;
            MAXVal.Location = new Point(42, 45);
            MAXVal.Name = "MAXVal";
            MAXVal.Size = new Size(29, 15);
            MAXVal.TabIndex = 7;
            MAXVal.Text = "0ms";
            // 
            // SQLabel
            // 
            SQLabel.AutoSize = true;
            SQLabel.Location = new Point(3, 60);
            SQLabel.Name = "SQLabel";
            SQLabel.Size = new Size(22, 15);
            SQLabel.TabIndex = 8;
            SQLabel.Text = "SQ";
            // 
            // SQVal
            // 
            SQVal.AutoSize = true;
            SQVal.Location = new Point(42, 60);
            SQVal.Name = "SQVal";
            SQVal.Size = new Size(13, 15);
            SQVal.TabIndex = 9;
            SQVal.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Location = new Point(674, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(28, 23);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Location = new Point(708, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(83, 127);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(0, -2);
            button3.Name = "button3";
            button3.Size = new Size(83, 119);
            button3.TabIndex = 0;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new Point(4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 127);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.68116F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.31884F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.Controls.Add(TimeoutBox, 1, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(TargetAddressBox, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 2, 1);
            tableLayoutPanel2.Controls.Add(button2, 2, 2);
            tableLayoutPanel2.Controls.Add(IntervalBox, 1, 1);
            tableLayoutPanel2.Location = new Point(3, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(391, 124);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // TimeoutBox
            // 
            TimeoutBox.Location = new Point(129, 83);
            TimeoutBox.Name = "TimeoutBox";
            TimeoutBox.Size = new Size(196, 23);
            TimeoutBox.TabIndex = 6;
            TimeoutBox.WordWrap = false;
            TimeoutBox.KeyPress += IntBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 80);
            label4.Name = "label4";
            label4.Size = new Size(120, 44);
            label4.TabIndex = 4;
            label4.Text = "Time out (ms)";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(120, 40);
            label2.TabIndex = 2;
            label2.Text = "Interval (ms)";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click_1;
            // 
            // TargetAddressBox
            // 
            TargetAddressBox.Location = new Point(129, 3);
            TargetAddressBox.Name = "TargetAddressBox";
            TargetAddressBox.Size = new Size(196, 23);
            TargetAddressBox.TabIndex = 1;
            TargetAddressBox.KeyPress += TargetAddressBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 40);
            label1.TabIndex = 0;
            label1.Text = "Target IP/Address";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(338, 43);
            button1.Name = "button1";
            button1.Size = new Size(50, 23);
            button1.TabIndex = 7;
            button1.Text = "reset";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(338, 83);
            button2.Name = "button2";
            button2.Size = new Size(50, 23);
            button2.TabIndex = 8;
            button2.Text = "reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // IntervalBox
            // 
            IntervalBox.Location = new Point(129, 43);
            IntervalBox.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            IntervalBox.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            IntervalBox.Name = "IntervalBox";
            IntervalBox.Size = new Size(196, 23);
            IntervalBox.TabIndex = 9;
            IntervalBox.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(406, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 127);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(261, 124);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(253, 96);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SaveFile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(250, 96);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(253, 96);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "GraphColor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(3, 3);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(896, 309);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 68);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "label3";
            label3.Click += label3_Click_1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 457);
            Controls.Add(splitContainer1);
            Name = "MainWindow";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IntervalBox).EndInit();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TimeoutBox;
        private Label label4;
        private Label label2;
        private TextBox TargetAddressBox;
        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel3;
        private Button button3;
        private Panel panel4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label PLLabel;
        private Label PLVal;
        private Label AVGLabel;
        private Label AVGVal;
        private Label MIN;
        private Label MINVal;
        private Label MAX;
        private Label MAXVal;
        private Label SQLabel;
        private Label SQVal;
        private NumericUpDown IntervalBox;
    }
}