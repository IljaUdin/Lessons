using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Ping
    {
        public delegate void PingDelegate(string message);

        public event PingDelegate PingEvent;

        public void HitPing()
        {
            PingEvent?.Invoke($"Ping получил Pong");
        }

        public void lossPing()
        {
            PingEvent?.Invoke("Ping промахнулся! Победил Pong");
        }
    }
}
