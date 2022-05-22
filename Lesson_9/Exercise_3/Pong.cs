using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Pong
    {
        public delegate void PongDelegate(string message);

        public event PongDelegate PongEvent;

        public void HitPong()
        {
            PongEvent?.Invoke("Pong получил Ping");
        }

        public void lossPong()
        {
            PongEvent?.Invoke("Pong промахнулся! Победил Ping");
        }
    }
}
