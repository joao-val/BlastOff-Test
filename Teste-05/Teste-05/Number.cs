using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_05
{
    internal class Number
    {

        public Number()
        {
            this.A = 0;
            this.B = 0;
        }

        public double A, B;

        public void Displays()
        {
            Console.WriteLine("");

            if (A % B == 0)
            {
                Console.WriteLine("The first number '" + A + "' and second number '" + B + "' are multiples");
            }
            else
            {
                Console.WriteLine("The first number '" + A + "' and second number '" + B + "' are not multiples");
            }
        }
    }
}
