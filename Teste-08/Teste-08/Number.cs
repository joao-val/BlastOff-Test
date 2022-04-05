using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_08
{
    internal class Number
    {

        public Number()
        {
            this.number = 0;
        }

        public int number;
        private bool primeNumber = true;

        public void Display()
        {
            if(number < 0)
            {
                Console.WriteLine("Invalid number.");
            }
            else if(number == 0 || number == 1)
            {
                Console.WriteLine("Valid number, but it is not a prime number");
            }
            else
            {
                for (int i = 2; i <= (number / 2); i++)
                {
                    if (number % i == 0)
                    {
                        primeNumber = false;
                        break;
                    }
                }

                if (primeNumber)
                {
                    Console.WriteLine("This is a prime number");
                }
                else
                {
                    Console.WriteLine("This is not a prime number");
                }
            }
        }

    }
}
