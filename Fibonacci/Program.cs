using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int x = 0;
            int y = 1;

            for (int i = 0; i < n; i++)
            {
                x = x + y;
                Console.WriteLine(x);
                y = x - y;
            }
            Console.ReadKey();
        }
    }
}
