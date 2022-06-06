using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class WorkWithZIP
    {
        public static void CreateZIP()
        {
            Directory.CreateDirectory("D:\\!Rubius\\Lessons\\Lesson_12\\Path\\CreateZIP");

            var myString = "Hello world";
            var filePath = Path.Combine("D:", "!Rubius", "Lessons", "Lesson_12", "Path", "CreateZIP", "helloworld.txt");
            using (var fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (var streamWrite = new StreamWriter(fileStream))
                {
                    streamWrite.WriteLine(myString);
                }
            }
            Directory.CreateDirectory("D:\\!Rubius\\Lessons\\Lesson_12\\Path\\CreateZIP\\Folder1");
            var filePath_2 = Path.Combine("D:", "!Rubius", "Lessons", "Lesson_12", "Path", "CreateZIP", "Folder1", "helloworld_2.txt");
            using (var fileStream = new FileStream(filePath_2, FileMode.OpenOrCreate))
            {

            }
            ZipFile.CreateFromDirectory("D:\\!Rubius\\Lessons\\Lesson_12\\Path\\CreateZIP", "D:\\!Rubius\\Lessons\\Lesson_12\\Path\\archive.zip");
        }
        public static void ExtractZIP()
        {
            try
            {
            ZipFile.ExtractToDirectory("D:\\!Rubius\\Lessons\\Lesson_12\\Path\\archive.zip", "D:\\!Rubius\\Lessons\\Lesson_12\\Path\\ExtractZIP");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InfoDirectory()
        {
            string path = "D:\\!Rubius\\Lessons\\Lesson_12\\Path\\ExtractZIP";
            string path_sw = "D:\\!Rubius\\Lessons\\Lesson_12\\Path\\InfoDirectory.csv";

            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                FileInfo[] files = directory.GetFiles("*.*", SearchOption.AllDirectories);
                DirectoryInfo[] directories = directory.GetDirectories("*.*", SearchOption.AllDirectories);

                FileInfo fileInfo = new FileInfo(path_sw);
                StreamWriter sw = fileInfo.CreateText();

                foreach (FileInfo file in files)
                {
                    sw.WriteLine("{0}\t{1}\t{2}", file.Extension, file.Name, file.CreationTime);
                }

                foreach (DirectoryInfo directory1 in directories)
                {
                    sw.WriteLine("{0}\t{1}\t{2}", directory1.Extension, directory1.Name, directory1.CreationTime);
                }

                FileInfo infoOfSW = new FileInfo("D:\\!Rubius\\Lessons\\Lesson_12\\Path\\Lesson12Homework.txt");
                StreamWriter pathOfSW = infoOfSW.CreateText();
                pathOfSW.WriteLine(path_sw.ToString());

                pathOfSW.Close();
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void DeleteDirectory()
        {
            string path = "D:\\!Rubius\\Lessons\\Lesson_12\\Path\\ExtractZIP";
            DirectoryInfo  directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                Directory.Delete(path, true);
            }
        }
    }
}
