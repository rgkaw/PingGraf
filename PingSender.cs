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

        public async Task<PingResponse> SendPing(string who, int timeout = 5000)
        {
            IPAddress ip = null;
            if (!System.Net.IPAddress.TryParse(who, out ip)) return new PingResponse();

            Ping pingSender = new Ping();
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            PingOptions options = new PingOptions(64,true);

            try
            {
                PingReply rep = await pingSender.SendPingAsync(who, timeout, buffer, options);
                return new PingResponse() { Status = 1, Reply=rep };

            }
            catch (Exception ex) 
            { 
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
        public PingReply Reply { get; set;}
        
    }

}
