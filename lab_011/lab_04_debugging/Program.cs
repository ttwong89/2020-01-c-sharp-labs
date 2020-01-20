using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace lab_04_debugging
{
    class Program
    {
        static void Main(string[] args)
        {

            // initialise : clear log file
            File.WriteAllText(@"c:\log\log.dat", "");
            int x = 10;
            x = x + 10;
            int y = x * x;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Trace.WriteLine($"your number is {i}");
                Debug.WriteLine($"your number is {i}");
                Debug.WriteLineIf(i == 6, "hey, i is 6!!!");
                File.AppendAllText("../log.dat", $"Logging i = {i} at {DateTime.Now}");
                Console.WriteLine("\\"); // backslash is 'escaped character'
                Console.WriteLine("\nhello"); // new line
                Thread.Sleep(1500);
                //@ to provide clean string 'literal'
                
            }

            // print file
            var logFilePath = @"c:\log\log.dat";
            Console.WriteLine("\n\nPrinting contents of log file\n\n:");
            Console.WriteLine(File.ReadAllText(logFilePath));
            
           }
    }
}
