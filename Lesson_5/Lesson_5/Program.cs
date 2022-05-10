using System;
using System.Collections.Generic;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vector_1 = new List<int> { 1, 2, 3 };
            Console.WriteLine("Вектор №1 : [{0}, {1}, {2}]", vector_1[0], vector_1[1], vector_1[2]);
            List<int> vector_2 = new List<int> { 2, 0, 1 };
            Console.WriteLine("Вектор №2 : [{0}, {1}, {2}]", vector_2[0], vector_2[1], vector_2[2]);

            Console.WriteLine(new string('-', 30));

            Vector result = new Vector(vector_1, vector_2);

            Console.WriteLine("Длина вектора №1 равна : {0:0.000}", result.VectorLength_1());
            Console.WriteLine("Длина вектора №2 равна : {0:0.000}\n", result.VectorLength_2());
            Console.WriteLine("Скалярное произведение вектора №1 и №2 равно : {0:0.0}\n", result.VectorProductScalar());
            result.VectorProductVector();
            result.AngleBetweenVectors();
            result.SumDif();

            Console.ReadKey();
        }
    }
}
