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
                while (!double.TryParse(Console.ReadLine(), out num_1))
                {
                    if (num_1 == 3)
                    {
                        Console.WriteLine("!!!");
                    }
                    else
                    Console.Write("Ошибка ввода! Введите значение числа 1 : ");
                }

                Console.Write("Введите значение числа 2 : ");
                while (!double.TryParse(Console.ReadLine(), out num_2))
                {
                    Console.Write("Ошибка ввода! Введите значение числа 2 : ");
                }
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
                    if (num_2 == 0)
                    {
                        Console.WriteLine("Деление на ноль!");
                    }
                    else
                    { 
                    Console.WriteLine($"Отношение чисел {num_1} и {num_2} равно {num_1 / num_2}");
                    }
                    break;
                case "%":
                    if (num_2 == 0)
                    {
                        Console.WriteLine("Деление на ноль!");
                    }
                    else
                    {
                    Console.WriteLine($"Деление с остатком чисел {num_1} и {num_2} равно {num_1 % num_2}");
                    }
                    break;
                default:
                    Console.WriteLine("Неверный символ операции. Попробуйте еще раз");
                    
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
            while (Console.ReadLine().ToLower() != "n");
        }
    }
}
