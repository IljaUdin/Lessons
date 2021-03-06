using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int pingNumber = rnd.Next(0, 10);
            int pongNumber = rnd.Next(0, 10);

            Ping ping = new Ping();
            Pong pong = new Pong();
            ping.PingEvent += OnConsole;
            pong.PongEvent += OnConsole;

            if (pingNumber > pongNumber)
            {
                for (int i = 0; i < pongNumber; i++)
                {
                    ping.HitPing();
                    pong.HitPong();
                }
                pong.lossPong();
                
            }
            else if (pingNumber < pongNumber)
            {
                for (int i = 0; i < pingNumber; i++)
                {
                    ping.HitPing();
                    pong.HitPong();
                }
                ping.HitPing();
                ping.lossPing();
            }
            else
            {
                for (int i = 0; i < pingNumber; i++)
                {
                    ping.HitPing();
                    pong.HitPong();
                }
                Console.WriteLine("Ничья");
            }
            Console.ReadKey();
        }

        public static void OnConsole(string text)
        {
            Console.WriteLine(text);
        }
    }
}
