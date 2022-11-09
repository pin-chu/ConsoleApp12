using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = Enumerable.Range(1, 30);
            var evenItems = items.Where(num => num % 2 == 0);

            foreach(var item in evenItems)
            {
                Console.WriteLine(item);
            }
            //找出items小於8大於25的項目
            
            var result = items.Where(num => num >25||num<8);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
}
