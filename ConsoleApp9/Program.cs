using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>
            {
                new Member{Id=1,MemberName="A1",Email="A1@gmail.com"},
                new Member{Id=2,MemberName="A2",Email="A2@gmail.com"},
                new Member{Id=3,MemberName="A3",Email="A3@gmail.com"},
                new Member{Id=4,MemberName="A4",Email="A4@gmail.com"},

            };
            //版本一
            //IEnumerable<Buyer> buyers = members.Select(m => new Buyer { Id = m.Id, Name = m.MemberName });

            //版本二
            //Func<Member,Buyer>func=m=>new Buyer { Id=m.Id,Name=m.MemberName};
            //IEnumerable<Buyer> buyers = members.Select(func);

            //版本三
            //Func<Member, Buyer> func = m => {
            //    return new Buyer { Id = m.Id, Name = m.MemberName };
            //};
            //IEnumerable<Buyer>buyers=members.Select(func);

            //版本四,叫用Member.ToBuyer擴充方法!!
            IEnumerable<Buyer> buyers = members.Select(m => m.ToBuyer());
            //IEnumerable<Buyer> buyers = members.Select(MemberExtensions.ToBuyer);

            foreach(var buyer in buyers)
            {
                Console.WriteLine($"{buyer.Id},{buyer.Name}");
            }

        }
    }
    public static class MemberExtensions
    {
        public static Buyer ToBuyer(this Member source)
        {
            return new Buyer { Id = source.Id, Name = source.MemberName };
        }
    }
    public class Member
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
    }
    public class Buyer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }



}
