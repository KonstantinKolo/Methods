using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Line(n);
            for (int s1 = 0; s1 <n - 2; s1++)
            {
                Body(n);
            }
            Line(n);

        }
        static void Line(int num)
        {
            for (int s1 = 0; s1 < num * 2; s1++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        static void Body(int num)
        {
            Console.Write("-");
            for (int s1 = 0; s1 < (2 * num - 2) / 2; s1++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }
    }
}
