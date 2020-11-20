using System;
using System.IO;

namespace FridayWorkWithFiles2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the file name (include extensions):");
            string userInput = Console.ReadLine();
            MoveOnionsfile();
        }
     
        public static void MoveOnionsfile()
        {
            string rootPath = @"C:\Users\opilane\samples\töö";
            string destinationDirectory = @"C:\Users\opilane\samples\töö\vegetables";
            string fileName = "onions.txt";

            File.Move(Path.Combine(rootPath, fileName), Path.Combine(destinationDirectory, fileName));
        }
    }
}

