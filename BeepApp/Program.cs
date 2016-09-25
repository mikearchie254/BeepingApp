using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeepApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;   //UI
            Console.WriteLine("Beep Countdown (Seconds)?");//Prompt
            Console.Write(">>> ");//Input
            string seconds= Console.ReadLine();
            int secs = int.Parse(seconds);
            for (int i = 0; i < secs; i++)
            {
                Thread.Sleep(1000 * 1);
                Console.WriteLine(new string('X',i));
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Beep();
            }
            Console.WriteLine("[Done]");
            Console.Read();
        }
    }
}
