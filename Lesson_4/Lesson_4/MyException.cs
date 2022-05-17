using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class MyException : Exception
    {
        public void ErrorLenghtArray()
        {
            Console.WriteLine("Размер массива не может быть отрицательным!");
        }
    }
}
