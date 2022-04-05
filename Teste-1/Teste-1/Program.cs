using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Calculate calculate = new Calculate();

            Console.WriteLine("Calculate the average age");
            
            Console.Write("Inform the First age: ");
            calculate.First = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inform the Second age: ");
            calculate.Second = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inform the Third age: ");
            calculate.Third = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inform the Fourth age: ");
            calculate.Fourth = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Inform the Fifth age: ");
            calculate.Fifth = Convert.ToDouble(Console.ReadLine());

            calculate.Displays();
            Console.ReadKey();

        }
    }
}
