using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetTotal handler = new GetTotal(PromoB);
            GetTotal handler = PromoA;

            int result = handler(100);
            Console.WriteLine(result);
        }
        static int PromoB(int p)
        {
            return p >= 10000 ? p - 1000 : p;//滿萬送千
        }
        static int PromoA(int p)
        {
            return p * 8 / 10;//八折
        }
    }
    /// <summary>
    /// 委派(delegate)的宣告方式，類似method.但最後部譨大括號，前面要加'delegate'
    /// </summary>
    /// <param name="price"></param>
    /// <returns></returns>
    public delegate int GetTotal(int price);
   
}
