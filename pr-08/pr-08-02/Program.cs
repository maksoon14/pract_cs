using System;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Threading;

namespace pr_08_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex mx = null;
            const String mxName = "RUNMEONLYONCE";
            try
            {
                mx = Mutex.OpenExisting(mxName);
            }
            catch (WaitHandleCannotBeOpenedException)
            {
                
            }

            if (mx == null)
            {
                mx = new Mutex(true, mxName);
            }
            else
            {
                mx.Close();
                Environment.Exit(0);
            }
            Console.WriteLine("Our Application");
            Console.Read();
        }
    }
}