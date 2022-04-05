using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_04
{
    public class Temperature
    {

        public Temperature()
        {
            this.C = 0;
            this.F = 0;
        }

        public double C, F;


        public double Converter
        {
            get { 
                return (C * (9.0/5.0)) + 32;
            }
        }

        public void Displays()
        {
            Console.WriteLine("");
            Console.WriteLine("This C° is " + this.Converter + "°F");
        }

    }
}
