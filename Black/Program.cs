using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black
{
    internal class Program
    {
        static void GreetBlack(string[] args)
        {
            Console.Write("hello Black");
        }

        static void GreetWhite(string[] args)
        {
            Console.Write("hello white");
        }

        static void Main(string[] args)
        {
            Console.Write("hello everyone");
            GreetWhite();
            GreetBlack();
        }
    }
}
