using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_09
{
    internal class MultiplicationTable
    {
        
        public MultiplicationTable()
        {
        }

        public int number, x;

        public void Displays()
        {
            for (int i = 0; i <= 10; i++)
            {
                x = i * number;
                Console.WriteLine(x);
            }
        }

    }
}
