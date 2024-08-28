
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;

namespace PingGraf
{

    public partial class MainWindow : Form
    {
        int low = 0;
        int high = 0;
        int avg = 0;
        double PL = 0;
        private int queueSize = 100;
        private int[] queuePercentile;
        private int tmp = 0;
        PingSender pinger;
        bool PingStatus = false;
        private CancellationTokenSource stopToken;
        int[] data1 = { 0, 5, 1, 4, 2, 3 };
        int[] data2 = { 5, 0, 4, 1, 3, 2 };
        int idx = 0;
        int prev_timeout = 0;
        string prev_address = "";
        Queue<int> queue = new Queue<int>();
        Queue<int> queueX = new Queue<int>();
        Series seriesA = new Series();
        Queue<int> queue123 = new Queue<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (int i in Enumerable.Repeat(0, 100).ToArray()) { queue123.Enqueue(idx); idx++; };
            idx = 0;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart1.ChartAreas[0].AxisX.IsMarksNextToAxis = true;


            //Series seriesB = new Series();
            seriesA.Points.DataBindXY(queueX, queue);
            seriesA.ChartType = SeriesChartType.Line;
            seriesA.IsXValueIndexed = true;

            //seriesB.Points.DataBindXY(x,data2);
            //seriesB.ChartType = SeriesChartType.Line;
            seriesA.IsValueShownAsLabel = false;
            chart1.Series.Clear();
            chart1.Series.Add(seriesA);
            //chart1.Series.Add(seriesB);
            chart1.Legends.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PingStatus)
            {
                PingStatus = false;
                if (stopToken != null) { stopToken.Cancel(); panel4.BackColor = Color.Red; }
            }
            else
            {
                clear();
                var address = TargetAddressBox.Text;
                try
                {
                    if(address == null || address.Length == 0){ return; }
                    address = System.Net.Dns.GetHostAddresses(address).FirstOrDefault().ToString();

                }
                catch (Exception ex)
                {
                    TargetAddressBox.Clear();
                    MessageBox.Show(ex.Message);
                    return;

                }

                pinger = new PingSender(address, 1000);
                PingStatus = true;
                stopToken = new CancellationTokenSource();
                ping_process(stopToken.Token, (int)IntervalBox.Value);
            }

        }

        private async void ping_process(CancellationToken cancellationToken = default, int delay = 1000)
        {
            try
            {
                while (true)
                {
                    PingResponse res = await pinger.SendPing();
                    tmp = (int)(res.Reply.Status == IPStatus.Success ? res.Reply.RoundtripTime : 1000);
                    if (tmp == 0) { chart1.ChartAreas[0].AxisX.Maximum = queuePercentile[queuePercentile.Length - 1] * 2; }
                    queue.Enqueue(tmp);
                    queueX.Enqueue(idx);
                    idx++;
                    if (queue.Count > 100)
                    {
                        queue.Dequeue();
                        queueX.Dequeue();
                    }
                    queuePercentile = queue.ToArray<int>();
                    if (idx < 200)
                    {
                        queuePercentile = queuePercentile.Skip(200 - idx).ToArray<int>();
                    }
                    Array.Sort(queuePercentile);
                    MINVal.Text = (queuePercentile[0].ToString() + "ms");
                    MAXVal.Text = (queuePercentile[queuePercentile.Length - 1].ToString() + "ms");
                    AVGVal.Text = (((int)queuePercentile.Average()).ToString() + "ms");
                    PLVal.Text = ((double)((int)queuePercentile.Count<int>(x => x == 1000) / (double)queuePercentile.Length) * 100).ToString("0.##") + "%";
                    SQVal.Text = ((idx - 100).ToString());

                    //high = queuePercentile[queuePercentile.Length-1];
                    //avg=(int) queuePercentile.Average();
                    //PL = (double) ((int) queuePercentile.Count<int>(x => x==0)/ queuePercentile.Length);



                    seriesA.Points.DataBindXY(queueX, queue);

                    //chart1.ChartAreas[0].AxisY.Minimum = queue.Min() > 30 ? queue.Min() - 30 : 1;
                    //chart1.ChartAreas[0].AxisY.Minimum = queue.Min() + 30;
                    chart1.ChartAreas[0].AxisY.MajorGrid.IntervalOffset = 10;
                    chart1.Update();
                    //label3.Text = res.Reply.RoundtripTime.ToString();
                    label3.Text = queue.ToArray().ToString();
                    if (tmp > 0) { panel4.BackColor = Color.Green; } else { panel4.BackColor = Color.Red; }
                    await Task.Delay(1000, cancellationToken);
                }
            }
            catch (Exception ex)
            {
                label3.Text = ex.Message;
            }


        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            queue.Clear();
            queueX.Clear();
            foreach (int i in Enumerable.Repeat(0, 100).ToArray()) { queue.Enqueue(0); queueX.Enqueue(idx); idx++; };
            seriesA.Points.Clear();
            chart1.Update();
        }



        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }


        private void IntBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(((char)e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void TargetAddressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyChar) && ((sender as TextBox).Text.Split('.').Length > 4))
            {
                e.Handled = true;
            }
        }
    }
}