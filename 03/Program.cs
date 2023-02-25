using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Print(n);
        }
        static void Print(int num)
        {
            for (int s1 = 1; s1 <= num; s1++)
            {
                for (int s2 = 1; s2 <= s1; s2++)
                {
                    Console.Write(s2 + " ");
                }
                Console.WriteLine();
            }
            for (int s1 = num - 1; s1 >= 1; s1--)
            {
                for (int s2 = 1; s2 <= s1; s2++)
                {
                    Console.Write(s2 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
