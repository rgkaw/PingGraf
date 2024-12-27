
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;

namespace PingGraf
{

    public partial class MainWindow : Form
    {
        int queue_length = 120;
        int timeout = 0;
        int interval = 0;
        private int[] queuePercentile;
        private int tmp = 0;
        PingSender pinger;
        bool PingStatus = false;
        private CancellationTokenSource stopToken;
        int idx = 121;
        Queue<int> queue = new Queue<int>();
        Queue<int> queueX = new Queue<int>();
        Series seriesA = new Series();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = queue_length; i > 0; i--) { queueX.Enqueue(i); queue.Enqueue(0); }
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart1.ChartAreas[0].AxisX.IsMarksNextToAxis = true;


            seriesA.Points.DataBindXY(queueX, queue);
            seriesA.ChartType = SeriesChartType.Line;
            seriesA.IsXValueIndexed = true;
            seriesA.IsValueShownAsLabel = false;

            chart1.Series.Clear();
            chart1.Series.Add(seriesA);
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
                    timeout = Int32.Parse(TimeoutBox.Text);
                    interval = Int32.Parse(IntervalBox.Text);
                    if (address == null || address.Length == 0 || address == "") { clear(); return; }
                    address = System.Net.Dns.GetHostAddresses(address).FirstOrDefault().ToString();

                }
                catch (Exception ex)
                {
                    TargetAddressBox.Clear();
                    MessageBox.Show(ex.Message,"input error");
                    return;

                }
                pinger = new PingSender(address, timeout);
                PingStatus = true;
                stopToken = new CancellationTokenSource();
                ping_process(stopToken.Token);
            }

        }

        private async void ping_process(CancellationToken cancellationToken = default)
        {
            try
            {
                while (true)
                {
                    PingResponse res = await pinger.SendPing();
                    tmp = (int)(res.Reply.Status == IPStatus.Success ? res.Reply.RoundtripTime : timeout);
                    if (tmp == 0) { chart1.ChartAreas[0].AxisX.Maximum = queuePercentile[queuePercentile.Length - 1] * 2; }
                    queue.Enqueue(tmp);
                    //queueX.Enqueue(idx);
                    idx++;
                    if (queue.Count > queue_length)
                    {
                        queue.Dequeue();
                        //queueX.Dequeue();
                    }
                    queuePercentile = queue.ToArray<int>();
                    if (idx < (queue_length * 2))
                    {
                        queuePercentile = queuePercentile.Skip((queue_length * 2) - idx + 1).ToArray<int>();
                    }
                    Array.Sort(queuePercentile);
                    MINVal.Text = (queuePercentile[0].ToString() + "ms");
                    MAXVal.Text = (queuePercentile[queuePercentile.Length - 1].ToString() + "ms");
                    AVGVal.Text = (((int)queuePercentile.Average()).ToString() + "ms");
                    PLVal.Text = ((double)((int)queuePercentile.Count<int>(x => x == timeout) / (double)queuePercentile.Length) * 100).ToString("0.##") + "%";
                    SQVal.Text = ((idx - queue_length).ToString());

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
                    await Task.Delay(interval, cancellationToken);
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
            for (int i = queue_length; i > 0; i--) { queueX.Enqueue(i); queue.Enqueue(0); }
            seriesA.Points.Clear();
            seriesA.Points.DataBindXY(queueX, queue);
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