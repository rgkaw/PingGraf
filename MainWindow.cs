
namespace PingGraf
{
    public partial class MainWindow : Form
    {
        PingSender pinger = new PingSender();
        bool PingStatus = false;
        private CancellationTokenSource stopToken;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                if (stopToken != null) stopToken.Cancel();
            }
            else
            {
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
                    string x = "8.8.8.8";
                    PingResponse res = await pinger.SendPing(x);

                    label3.Text = res.Reply.RoundtripTime.ToString();
                    await Task.Delay(1000, cancellationToken);
                }
            }
            catch (Exception ex)
            {

            }


        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}