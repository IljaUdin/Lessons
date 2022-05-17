using System;
using System.Collections.Generic;

namespace Lesson_6_2_
{
    class Program
    {
        static int Box()
        {
            int heightBox = default;
            do
            {
                try
                {
                    Console.Write("Введите высоту ребра коробки (м) : ");
                    heightBox = int.Parse(Console.ReadLine());
                    if (heightBox <= 0)
                        throw new MyException();
                }
                catch (MyException myException)
                {
                    myException.ErrorMinesValue();
                    Console.WriteLine(myException.StackTrace);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.Source);
                    Console.WriteLine(ex.StackTrace);
                }
            }
            while (heightBox <= 0);
            return heightBox;
        }

        static void FillBox()
        {
            Shape example = null;
            List<Box> shapes = new List<Box>();
            Box box = new Box(Box());
            box.Volume();

            do
            {
                do
                {
                    int str = default;
                    do
                    {
                        try
                        {
                            Console.WriteLine("Свободный объем куба равен : {0} (м3)", box.VolumeCube);
                            Console.WriteLine(new string('-', 50));
                            Console.Write("Введите тип фигуры для добавления в коробку (Цилиндр(1), Пирамида(2), Шар(3)) : ");
                            str = int.Parse(Console.ReadLine());
                            if (str > 3 | str <= 0)
                                throw new MyException();
                        }
                        catch (MyException myException)
                        {
                            myException.ErrorSelection();
                            Console.WriteLine(myException.StackTrace);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.Source);
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                    while (str > 3 | str <= 0);

                    if (str == 1)
                    {
                        int height, radius;
                        do
                        {
                            try
                            {
                                Console.Write("Введите высоту цилиндра (м) : ");
                                height = int.Parse(Console.ReadLine());
                                Console.Write("Введите радиус цилиндра (м) : ");
                                radius = int.Parse(Console.ReadLine());
                                if (height <= 0 | radius <= 0)
                                    throw new MyException();
                            }
                            catch (MyException myException)
                            {
                                myException.ErrorMinesValue();
                                Console.WriteLine(myException.StackTrace);
                                height = default;
                                radius = default;
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.Source);
                                Console.WriteLine(ex.StackTrace);
                                height = default;
                                radius = default;
                            }
                        }
                        while (height <= 0 | radius <= 0);
                        example = new Cylinder(height, radius);
                        shapes.Add(box);
                    }
                    else if (str == 2)
                    {
                        int height, square;
                        do
                        {
                            try
                            {
                                Console.Write("Введите высоту пирамиды (м) : ");
                                height = int.Parse(Console.ReadLine());
                                Console.Write("Введите площадь пирамиды (м2) : ");
                                square = int.Parse(Console.ReadLine());
                                if (height <= 0 | square <= 0)
                                    throw new MyException();
                            }
                            catch (MyException myException)
                            {
                                myException.ErrorMinesValue();
                                Console.WriteLine(myException.StackTrace);
                                height = default;
                                square = default;
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.Source);
                                Console.WriteLine(ex.StackTrace);
                                height = default;
                                square = default;
                            }
                        }
                        while (height <= 0 | square <= 0);
                        example = new Pyramid(height, square);
                        shapes.Add(box);
                    }
                    else if (str == 3)
                    {
                        int radius = default;
                        do
                        {
                            try
                            {
                                Console.Write("Введите радиус шара (м) : ");
                                radius = int.Parse(Console.ReadLine());
                                if (radius <= 0)
                                    throw new MyException();
                            }
                            catch (MyException myException)
                            {
                                myException.ErrorMinesValue();
                                Console.WriteLine(myException.StackTrace);
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.Source);
                                Console.WriteLine(ex.StackTrace);
                            }
                        }
                        while (radius <= 0);
                        example = new Ball(radius);
                        shapes.Add(box);
                    }
                }
                while (box.Add(example) == true);

                Console.WriteLine("Попытаться добавить другую фигуру? Y/N : ");
            }
            while (Console.ReadLine().ToLower() != "n");


            Console.WriteLine(new string('=', 50));
            Console.WriteLine("В коробке находятся : ");
            box.Figure_in_Box();
        }
        static void Main(string[] args)
        {
            FillBox();

            Console.ReadKey();
        }
    }
}
