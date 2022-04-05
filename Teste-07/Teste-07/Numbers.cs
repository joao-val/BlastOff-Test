using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_07
{
    internal class Numbers
    {

        public Numbers()
        {
        }

        int[] n = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 222 ,333, 444, 555, 666, 777, 888};


        public void Displays()
        {
            for (int i = 0; i < n.Length; i++)
                if (n[i] % 2 == 0)
                {
                    Console.WriteLine(n[i]);
                }
        }

    }
}
