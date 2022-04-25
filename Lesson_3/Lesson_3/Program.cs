using System;

namespace Lesson_3
{
    class Program
    {
        public static void Calculator()
        {
            double num_1, num_2;
            {
                Console.Write("Введите значение числа 1 : ");
                num_1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значение числа 2 : ");
                num_2 = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Выберите тип операции (+, -, *, /, %) : ");
            string type = Console.ReadLine();

            switch (type)
            {
                case "+":
                    Console.WriteLine($"Сумма чисел {num_1} и {num_2} равна {num_1 + num_2}");
                    break;
                case "-":
                    Console.WriteLine($"Разница чисел {num_1} и {num_2} равна {num_1 - num_2}");
                    break;
                case "*":
                    Console.WriteLine($"Произведение чисел {num_1} и {num_2} равно {num_1 * num_2}");
                    break;
                case "/":
                    Console.WriteLine($"Отношение чисел {num_1} и {num_2} равно {num_1 / num_2}");
                    break;
                case "%":
                    Console.WriteLine($"Деление с остатком чисел {num_1} и {num_2} равно {num_1 % num_2}");
                    break;
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Calculator();

                Console.Write("Выполнить новый расчет? Y/N : ");
            }
            while (Console.ReadLine() != "N");
        }
    }
}
