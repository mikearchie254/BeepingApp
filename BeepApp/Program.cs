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
        static public int nob;
        static void Prompt()
            {
                Console.WriteLine("Number of beeps: ");
                Console.Write(">>> ");
                nob = int.Parse(Console.ReadLine());
                Console.Clear();
            }
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;   //UI
            Prompt();
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
            for (int i = 0; i < nob; i++) //number of beeps
            {
                Console.Beep();
            }
            Console.WriteLine("[Done]");
            Console.Read();
        }
    }
}
