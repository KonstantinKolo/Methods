using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            Body();
            Footer();
        }
        static void Header()
        {
            Console.WriteLine("CASH RECEIPT\n-------------------------------");
        }
        static void Body()
        {
            Console.WriteLine("Charged to ______________\nRecieved by _____________");
        }
        static void Footer()
        {
            Console.WriteLine("-------------------------------\n© SoftUni");
        }
    }
}
