using System;
using System.IO;

namespace pr_02_01
{
    class Program
    {
        static void ShowDirectory(DirectoryInfo dir)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("File: {0}", file.FullName);
            }
            foreach (DirectoryInfo subDir in dir.GetDirectories()) 
            {
                ShowDirectory(subDir);
            }
        }
        static void Main(string[] args)
        {
            //Environment.SystemDirectory на линуксе выдаёт пустую строчку, так что пусть будет вывод текущей директории 
            DirectoryInfo dir = new DirectoryInfo(Environment.CurrentDirectory);
            ShowDirectory(dir);
        }
    }
}