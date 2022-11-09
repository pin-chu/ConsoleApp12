using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = new int[] { 7, 12, 8, 3, 5 };
            List<int>result =items.ToList();

            int[]result2=result.ToArray();
            IEnumerable<int> result3 = DoubleIt(items);//將每一項目變二倍並傳回
           

            int[]result4=GetEvenItems(items).ToArray();
            
        }
        static IEnumerable<int> GetEvenItems(int[]source)
        {
            List<int> result = new List<int>();

            for(int i = 0; i < source.Length; i++)
            {
                if (source[i] % 2 == 0) result.Add(source[i]);
            }
            return result;
        }

        static IEnumerable<int> DoubleIt(int[]source)
        {
            for(int i=0;i<source.Length;i++)
            {
                source[i] = source[i] * 2;
            }
            return source;
        }

    }
}
