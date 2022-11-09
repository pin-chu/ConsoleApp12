using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
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
                new Student{ English =80,Chinese=70,Math=55},
                new Student{ English =55,Chinese=50,Math=40}
            };

            Func<Student, bool> func = student => (student.English + student.Chinese + student.Math) / 3 >= 60;
            var result = students.Where(func);

            result = students.Where(s=>s.Pass==true);
            foreach(Student s in result)
            {
               // Console.WriteLine(s);
                Console.WriteLine($"Eng={s.English} ,Chs={s.Chinese},Math= {s.Math}");
            }

        }
    }

    public class Student
    {
        public int English { get; set; }
        public int Chinese { get; set; }
        public int Math { get; set; }

        public bool Pass 
        {
            get 
            {
                return (English + Chinese + Math) / 3 >= 60;
            }
             
        }


        //public override string ToString()
        //{
        //    return $"Eng={English} ,Chs={Chinese},Math= {Math}";
        //}
    }
}
