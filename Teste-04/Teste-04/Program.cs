using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();

            Console.WriteLine("Conversion Celsius to Fahrenheit");
            Console.WriteLine("Enter the °C temperature:");
            temperature.C = Convert.ToDouble(Console.ReadLine());

            temperature.Displays();
            Console.ReadKey();
        }
    }
}
