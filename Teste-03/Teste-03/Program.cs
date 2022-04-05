using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Number number = new Number();
            
            Console.WriteLine("Calculate who is the smallest number: ");
            Console.WriteLine("First number:");
            number.First = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second number: ");
            number.Second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Third number: ");
            number.Third = Convert.ToDouble(Console.ReadLine());

            number.Displays();
            Console.ReadKey();

        }
    }
}
