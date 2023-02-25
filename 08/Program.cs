using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            if (type == "int")
            {
                IntGetMax(first, second);
            }
            else if (type == "string")
            {
                StringGetMax(first, second);
            }
            else if (type == "char")
            {
                CharGetMax(first, second);
            }
        }
        static void IntGetMax(string first,string second)
        {
            if (int.Parse(first) > int.Parse(second))
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
        static void StringGetMax(string first, string second)
        {
            if (first.Length > second.Length)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
        static void CharGetMax(string first, string second)
        {
            if(char.Parse(first) > char.Parse(second))
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
    }
}
