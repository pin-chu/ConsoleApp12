using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]items=new int[] {5,41,6,85,66};
            IEnumerable<int>result=items.OrderBy (x=>x);
            //IEnumerable<int> result = items.OrderByDescending(x => x);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
