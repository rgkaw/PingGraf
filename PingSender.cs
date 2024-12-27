using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PingGraf
{
    public class PingSender
    {
        private Struct data = new Struct();
        private string _who;
        private int _timeout;
        public PingSender(string who, int timeout = 1000)
        {
            this._who = who;
            this._timeout = timeout;
        }

        public async Task<PingResponse> SendPing()
        {
            IPAddress ip = null;
            if (!System.Net.IPAddress.TryParse(_who, out ip)) return new PingResponse();

            Ping pingSender = new Ping();
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            PingOptions options = new PingOptions(64,true);

            try
            {
                PingReply rep = await pingSender.SendPingAsync(_who, _timeout, buffer, options);
                return new PingResponse() { Status = 1, Reply=rep };

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"ping error");
                return new PingResponse();
            }




        }
        private void PingCompleteCallback(object sender, PingCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //ping cancel
                ((AutoResetEvent)e.UserState).Set();
            }
            if (e.Error != null)
            {
                //ping failed
                ((AutoResetEvent)e.UserState).Set();
            }
            PingReply rep = e.Reply;
            Console.WriteLine(rep.RoundtripTime.ToString());
            ((AutoResetEvent)e.UserState).Set();
        }
    }

    public class PingResponse
    {
        public int Status { get; set; } = 0;
        public PingReply Reply { get; set; }
        
    }

}
