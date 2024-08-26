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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            splitContainer1 = new SplitContainer();
            panel4 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            panel5 = new Panel();
            SQVal = new Label();
            SQLabel = new Label();
            MAXVal = new Label();
            MAX = new Label();
            MINVal = new Label();
            MIN = new Label();
            AVGVal = new Label();
            AVGLabel = new Label();
            PLVal = new Label();
            PLLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(chart1);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(1040, 457);
            splitContainer1.SplitterDistance = 138;
            splitContainer1.TabIndex = 0;
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
            panel3.Size = new Size(83, 124);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(0, -2);
            button3.Name = "button3";
            button3.Size = new Size(54, 82);
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
            tableLayoutPanel2.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 2, 1);
            tableLayoutPanel2.Controls.Add(button2, 2, 2);
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
            // textBox3
            // 
            textBox3.Location = new Point(129, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 23);
            textBox2.TabIndex = 5;
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
            // textBox1
            // 
            textBox1.Location = new Point(129, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 1;
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
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(406, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 124);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(261, 121);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(253, 93);
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
            dataGridView1.Size = new Size(250, 90);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(253, 93);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "GraphColor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(3, 3);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
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
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel1);
            panel5.Location = new Point(906, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(122, 216);
            panel5.TabIndex = 3;
            // 
            // SQVal
            // 
            SQVal.AutoSize = true;
            SQVal.Location = new Point(61, 140);
            SQVal.Name = "SQVal";
            SQVal.Size = new Size(13, 15);
            SQVal.TabIndex = 9;
            SQVal.Text = "0";
            // 
            // SQLabel
            // 
            SQLabel.AutoSize = true;
            SQLabel.Location = new Point(3, 140);
            SQLabel.Name = "SQLabel";
            SQLabel.Size = new Size(22, 15);
            SQLabel.TabIndex = 8;
            SQLabel.Text = "SQ";
            // 
            // MAXVal
            // 
            MAXVal.AutoSize = true;
            MAXVal.Location = new Point(61, 105);
            MAXVal.Name = "MAXVal";
            MAXVal.Size = new Size(29, 15);
            MAXVal.TabIndex = 7;
            MAXVal.Text = "0ms";
            // 
            // MAX
            // 
            MAX.AutoSize = true;
            MAX.Location = new Point(3, 105);
            MAX.Name = "MAX";
            MAX.Size = new Size(33, 15);
            MAX.TabIndex = 6;
            MAX.Text = "MAX";
            // 
            // MINVal
            // 
            MINVal.AutoSize = true;
            MINVal.Location = new Point(61, 70);
            MINVal.Name = "MINVal";
            MINVal.Size = new Size(29, 15);
            MINVal.TabIndex = 5;
            MINVal.Text = "0ms";
            // 
            // MIN
            // 
            MIN.AutoSize = true;
            MIN.Location = new Point(3, 70);
            MIN.Name = "MIN";
            MIN.Size = new Size(30, 15);
            MIN.TabIndex = 4;
            MIN.Text = "MIN";
            // 
            // AVGVal
            // 
            AVGVal.AutoSize = true;
            AVGVal.Location = new Point(61, 35);
            AVGVal.Name = "AVGVal";
            AVGVal.Size = new Size(29, 15);
            AVGVal.TabIndex = 3;
            AVGVal.Text = "0ms";
            // 
            // AVGLabel
            // 
            AVGLabel.AutoSize = true;
            AVGLabel.Location = new Point(3, 35);
            AVGLabel.Name = "AVGLabel";
            AVGLabel.Size = new Size(29, 15);
            AVGLabel.TabIndex = 2;
            AVGLabel.Text = "AVG";
            // 
            // PLVal
            // 
            PLVal.AutoSize = true;
            PLVal.Location = new Point(61, 0);
            PLVal.Name = "PLVal";
            PLVal.Size = new Size(23, 15);
            PLVal.TabIndex = 1;
            PLVal.Text = "0%";
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(116, 175);
            tableLayoutPanel1.TabIndex = 0;
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
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
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
    }
}