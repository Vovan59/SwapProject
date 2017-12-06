using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 1;
            Swap(a, b);

            Console.WriteLine("a={0} b={1}", a, b);
            Console.ReadLine();

        }
        /// <summary>
        /// меняет значения переменных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap(int a,  int b)
        {       
            int c = a;
            a = b;
            b = c;
        }
    }
}
