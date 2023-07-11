using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string userName;
            Again:
            Console.WriteLine("Enter User Name");
            userName = Console.ReadLine();
            if(userName.Length>=6)
            {
                Console.WriteLine("Welcome : \t " + userName);
            }
            else
            {
                Console.WriteLine("Invalid User Name");
                goto Again;
            }
            Console.ReadKey();*/

            StringBuilder build = new StringBuilder("Welcome");
            build.Append(" To C# ");
            build.Append("I am String Builder");
            Console.WriteLine(build);
            Console.ReadKey();
        }
    }
}
