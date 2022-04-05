using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Number n = new Number();

            Console.WriteLine("Enter with a prime number");
            n.number = Convert.ToInt32(Console.ReadLine());

            n.Display();
        }
    }
}
