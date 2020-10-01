using System;
using System.IO;

namespace pr_02_01_02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //тк файлы .ini это фишка винды, а я сижу на линуксе, то данная программа будет мониторить изменения .txt файлов в главной директории
            FileSystemWatcher watcher = new FileSystemWatcher("/home");
            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            watcher.EnableRaisingEvents = true;
            Console.Read();
        }
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }
    }
}