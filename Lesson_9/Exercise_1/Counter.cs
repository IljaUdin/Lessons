using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Counter
    {
        public delegate void DelegatContainer();
        public event DelegatContainer event_123;
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 77)
                {
                    if (event_123 != null)
                    {
                        event_123();
                    }
                }
            }
        }
    }
}
