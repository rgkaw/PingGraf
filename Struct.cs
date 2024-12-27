namespace PingGraf
{
    public class Struct
    {
        TargetInformation info;
        TimeArray time;

    }

    internal class TargetInformation
    {
        String address = String.Empty;
        String ip = String.Empty;
        int ttl = 0;
        
        int pingByte = 0;
    }

    internal class TimeArray
    {
        private int size;
        private Queue<int> ms = new Queue<int>();
        TimeArray() 
        {
            this.size = 3600;
            for (int i = 0; i < this.size; i++) { ms.Enqueue(0); }
        }
        TimeArray(int reqSize) 
        { 
            this.size = reqSize;
            for(int i = 0; i < this.size; i++) { ms.Enqueue(0); }
        }

        void addTime(int resp_ms)
        {
            if(ms.Count > size) { ms.Dequeue(); }
            ms.Enqueue(resp_ms);

        }
          
    }
}
