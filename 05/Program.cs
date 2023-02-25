using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            Convert(input);
        }
        static void Convert(double num)
        {
            Console.WriteLine($"{(num - 32) * 5 / 9:F2}");
        }
    }
}
