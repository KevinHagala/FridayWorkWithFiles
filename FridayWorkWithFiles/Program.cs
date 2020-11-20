using System;
using System.IO;

namespace FridayWorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DeletetoiletPaper();
            Deletecheese();
        }
        public static void DeletetoiletPaper()
        {
            string rootPath = @"C:\Users\opilane\samples\töö\fruit";
            string fileName = "toiletPaper.txt";

            if (File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("File deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public static void Deletecheese()
        {
            string rootPath = @"C:\Users\opilane\samples\töö\vegetables";
            string fileName = "cheese.txt";

            if (File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("File deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}

