using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> func = Add;
            int result = func(10, 5);//叫用Add(1,5),傳回6
            Console.WriteLine(result);

            func = (n1, n2) =>//=>goes to
            {
                return n1 + n2 + 100;
            };//記得加 ;
              
            result = func(5, 6);
            Console.WriteLine(result);

            func = (n1, n2) => n1 + n2 + 150;//一行就用這個

            result = func(6, 6);
            Console.WriteLine(result);



            func = Substract;
            result = func(2, 10);
            Console.WriteLine(result);
        }
        static int Add (int n1,int n2)
        {
            return n1 + n2;
        }
        static int Substract(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
