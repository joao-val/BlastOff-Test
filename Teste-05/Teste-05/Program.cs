using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Number number = new Number();

            Console.WriteLine("Testing if numbers are multiples");

            Console.WriteLine("Enter the first number:");
            number.A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number.B = Convert.ToDouble(Console.ReadLine());

            number.Displays();
            Console.ReadLine();

        }
    }
}
