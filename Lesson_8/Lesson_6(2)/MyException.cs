using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_2_
{
    class MyException : Exception
    {
        public void ErrorMinesValue()
        {
            Console.WriteLine("Значение не может быть меньше или равно нулю");
        }
        public void ErrorSelection()
        {
            Console.WriteLine("Неверная команда");
        }
    }
}
