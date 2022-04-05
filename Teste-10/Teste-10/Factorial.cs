using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_10
{
    internal class Factorial
    {

        public Factorial()
        {

        }

        public double number, factorial, x;

        public void Displays()
        {
            factorial = number;
            if(factorial == 1) Console.WriteLine("Factorial number is: " + factorial);
            
            for(double i = number -1; i >= 1; i--)
            {
                factorial = factorial * i;
                Console.WriteLine(" * " + i + " = " + factorial);
                Console.WriteLine("");
            }
        }

    }
}
