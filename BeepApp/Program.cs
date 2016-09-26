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
            while (secs > 0)
            {
                for (int i = 0; i < secs; i++) //timer count down
                {
                    Thread.Sleep(1000 * 1);
                    Console.WriteLine(new string('X', secs--));
                }
                
            }
            for (int i = 0; i < 10; i++) //number of beeps
            {
                Console.Beep();
            }
            Console.WriteLine("[Done]");
            Console.Read();
        }
    }
}
