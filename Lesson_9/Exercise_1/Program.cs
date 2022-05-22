using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Handler_1 handler_1 = new Handler_1();
            Handler_2 handler_2 = new Handler_2();

            counter.event_123 += handler_1.Message;
            counter.event_123 += handler_2.Message;

            counter.Count();

            Console.ReadKey();
        }
    }
}
