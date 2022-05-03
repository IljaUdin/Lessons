using System;

namespace Lesson_4
{
    class MyException : Exception
    {
        public void ErrorLenghtArray()
        {
            Console.WriteLine("Размер массива не может быть отрицательным!");
        }
    }
    class Program
    {
        static void CompareArray(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);

            for (int i = 1; i < array.Length; i++)
            {
                int secondValue;
                if (array[0] > array[i])
                {
                    secondValue = array[i];
                    Console.WriteLine(new string('-', 30));
                    Console.WriteLine($"Вторым наибольшим элементом массива является число : {secondValue}");
                    break;
                }
            }
        }
        
        static int SizeArray()
        {
            int lenght_array = 0;
            try
            {
                Console.Write("Введите размер массива : ");
                lenght_array = int.Parse(Console.ReadLine());
                if (lenght_array < 0)
                    throw new MyException();
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
            catch (MyException myException)
            {
                myException.ErrorLenghtArray();
                Console.WriteLine(myException.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
            

            return lenght_array;
        }

        static int[] NumbersArray(int lenght_array)
        {
            int[] array = new int[lenght_array];
            Random random = new Random();

            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Введите значение для {i + 1} элемента массива : ");
                    array[i] = int.Parse(Console.ReadLine());
                    //array[i] = random.Next(-10, 10);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
            return array;
        }
        static void Main(string[] args)
        {
            do
            {
                int[] array = NumbersArray(SizeArray());
                for (int i = 0; i < array.Length; i++)
                    Console.WriteLine(array[i]);

                CompareArray(array);

                Console.Write("Выполнить новый цикл? Y/N : ");
            }
            while (Console.ReadLine().ToLower() != "n");
        }
    }
}
