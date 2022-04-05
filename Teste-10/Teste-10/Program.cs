using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();

            Console.WriteLine("Enter the number: ");
            factorial.number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            while (factorial.number < 0)
            {
                Console.WriteLine("Enter a valid number:");
                factorial.number = Convert.ToDouble(Console.ReadLine());
                }
            factorial.Displays();

        }
    }
}
