using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作業練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = MyMath.IsEvan(99);
            bool result2 = 99.IsEvan();
            Console.WriteLine(result2);

            //寫擴充方法步驟
            //1.宣告static class,名稱完全不重要
            //2.將method宣告成static method(在static class裡,其實也只能宣告成static)
            //3.針對第一個參數，加'this'

            string value = "0123456789";
            string result3 = MyMath.Left(value, 3);
            string result4 = value.Left(4);

            

        }

    }
    public static class MyMath
    {
        public static bool IsEvan(this int source)
        {
            return source %2 == 0;
        }

        public static string Left(this string source,int length)
        {
            return source.Substring(0,length);
        }
        public static string Left(this string source,int length)
        {
            if (string.IsNullOrEmpty(source)) return string.Empty;
            if(length <= 0) return string.Empty;
            if(source.Length <= 0) return source;

            return source.Substring(0,length);
        }


    }

}
