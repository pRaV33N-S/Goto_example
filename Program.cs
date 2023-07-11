using System;
using System.Collections.Generic;
using System.IO;
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
            /*
           */
            for(int i = 1; i < 10; i++)
            {
                if (i == 6)
                {
                    goto end;
                }
                Console.WriteLine("i value : {0}", i);
            }
        end: Console.WriteLine("The End");

        }
    }
}
