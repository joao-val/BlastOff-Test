using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MultiplicationTable table = new MultiplicationTable();

            Console.WriteLine("Enter the number:");
            table.number = Convert.ToInt32(Console.ReadLine());

            while (table.number < 0) {
                Console.WriteLine("Enter with a valid number:");
                table.number = Convert.ToInt32(Console.ReadLine());
            }

            table.Displays();
            Console.ReadKey();

        }
    }
}
