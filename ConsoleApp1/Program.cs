using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = Greeting;

            action();//叫用Greeting(),呈現 Hello World

            Action<string> action2 = GreetWith;
            action2("Alice");
        }
        static void Greeting()
        {
            Console.WriteLine("Hello World");
        }
        static void GreetWith(string name)
        {
            Console.WriteLine("Hi!"+name);
        }
    }
}
