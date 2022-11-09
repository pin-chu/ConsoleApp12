using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string> func = Greeting;
            string message = func();
            Console.WriteLine(message);

            Func<string> func2 = name;
            string message2 = func2();
            Console.WriteLine(message2);

        }
        static string Greeting()
        {
            return "Hello world";
        }
        static string name()
        {
            return "Hi! Alice";
        }

    }

}
