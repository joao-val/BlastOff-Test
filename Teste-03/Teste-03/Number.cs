using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_03
{
    public class Number
    {

        public Number()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        private double a, b, c;
        public double First
        {
            get { return a; }
            set { a = value; }
        }
        public double Second
        {
            get { return b; }
            set { b = value; }
        }
        public double Third
        {
            get { return c; }
            set{ c = value; }
        }

        public double SmallestNumber
        {
            get { 
                if(a < b && a < c) return a;
                else if (b < a && b < c) return b;
                else if (c < a && c < b) return c;
                return 0;
            }
        }
         
        public void Displays()
        {
            Console.WriteLine("");
            if (a == b && a == c)
            {
                Console.WriteLine("The 3 numbers are the same!");
            }
            else
            {
                Console.WriteLine("The smallest number is: " + this.SmallestNumber);
            }
        }

    }
}
