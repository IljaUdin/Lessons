using System;
using System.Collections.Generic;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatWeSearch = @"стр(\w*)";

            List<string> listString = new List<string>()
            {
                "строка_1",
                "строка_2",
                "111",
                "строка_3"
            };

            var classSearcher = new StringSearcher();

            classSearcher.EventString += OnConsole;
            classSearcher.Search(listString, whatWeSearch);

            Console.ReadKey();
        }
        public static void OnConsole(string text)
        {
            Console.WriteLine(text);
        }
    }
}
