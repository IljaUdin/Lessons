using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WorkWithZIP.CreateZIP();

            WorkWithZIP.ExtractZIP();

            WorkWithZIP.InfoDirectory();

            WorkWithZIP.DeleteDirectory();

            Console.ReadKey();
        }
    }
}
