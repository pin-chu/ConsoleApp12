using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result1 = Calc(2,5,(n1, n2) => n1 + n2);
            Console.WriteLine(result1);

            double result2 = Calc(10, 5, (n1, n2) => (double)n1 / n2);
            Console.WriteLine(result2);

            Func<int, bool> funcIsEvan = n => n % 2 == 0;//判斷是否為偶數
            bool isEvan = funcIsEvan(55);//return false
            Console.WriteLine(isEvan);

            bool isOdd = Predicate(55, n => n % 2 == 1);//判斷是否為奇數

            Console.WriteLine(isOdd);

        }

        /// <summary>
        /// 傳回num 傳入 func之後的值
        /// </summary>
        /// <param name="num"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        static bool Predicate(int num,Func<int,bool>func)
        {
            return func(num);
        }
        static double Calc(int n1,int n2,Func<int,int,double>func)
        {
            return func(n1, n2);
        }
    }
}
