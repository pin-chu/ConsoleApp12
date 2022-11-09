using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student{ English =50,Chinese=70,Math=65},
                new Student{ English =40,Chinese=50,Math=75},
                new Student{ English =80,Chinese=70,Math=95},
                new Student{ English =70,Chinese=60,Math=45},
                new Student{ English =80,Chinese=75,Math=55},
                new Student{ English =55,Chinese=50,Math=40}
            };

            var result = students
                .OrderBy(x => x.English)
                .ThenBy(x => x.Chinese);
                //.OrderByDescending(x => x.English)
                //.ThenBy(x => x.Chinese);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
    public class Student
    {
        public int English { get; set; }
        public int Chinese { get; set; }
        public int Math { get; set; }

        public override string ToString()
        {
            return $"Eng={English} ,Chs={Chinese},Math= {Math}";
        }
    }
}
