using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise_2
{
    internal class ReadZIP
    {
        public static string ReadFilePath()
        {
            var filePath = Path.Combine("D:", "!Rubius", "Lessons", "Lesson_12", "Path", "Lesson12Homework.txt");
            using (var fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    return streamReader.ReadLine();
                }
            }
        }

        public static void OpenFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(ReadFilePath());

                var list = new List<ContactModel>();

                foreach (var line in lines)
                {
                    var contact = ContactModel.Create(line);
                    if (contact != null)
                    {
                        list.Add(contact);
                    }
                }

                var sorted = list.OrderBy(с => с.CreateTime);

                foreach (var c in sorted)
                {
                    Console.WriteLine($"{c.TypeFile} {c.NameFile} {c.CreateTime}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }

        public static void DeleteFile()
        {
            string path = "D:\\!Rubius\\Lessons\\Lesson_12\\Path\\Lesson12Homework.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
        }
    }
}
