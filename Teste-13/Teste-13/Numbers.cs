using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_13
{
    internal class Numbers
    {

        public Numbers(){
        }

        private int[,] n = new int[3, 5] { {10, 20, 30, 40, 50},
            { 60, 70, 80, 90, 15 },
            { 25, 35, 45, 55, 65 } };

        public void Displays()
        {
            foreach (int i in n)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
