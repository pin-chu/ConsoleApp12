using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    //將List<string> 轉型為int[]
    internal class Program
    {
        static void Main(string[] args)
        {
            string Value = "123";
            int number = Value.ToInt(-1);//失敗傳-1
            //Console.WriteLine(number);//123

            Value = "1ABC";
            number = Value.ToInt(-1);//失敗傳-1
            //Console.WriteLine(number);//-1

            List<string> items = new List<string> { "gau","22"," ","56","s","98"};
            int[] result = items.Where (x => x.CanCovert2Int()).Select(x => x.ToInt(0)).ToArray();

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
    public static class stringExtensions
    {
        public static int ToInt(this string source,int defaulValue)
        {
            bool isInt =int.TryParse(source, out int number);
            return isInt ? number : defaulValue;
        }
        public static bool CanCovert2Int(this string source)
        {
            return int.TryParse(source, out int number);
        }
    }

}
