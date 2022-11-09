using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> source = Enumerable.Range(1, 10);
            IEnumerable<string> items = source.Select(x => "Item" + x);

            //IEnumerable<string> items = Enumerable.Range(1,10).Select(x=>"Name"+x);
            //一行寫法

            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }

    }
}
