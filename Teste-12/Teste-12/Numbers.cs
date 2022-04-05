using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_12
{
    internal class Numbers
    {

        public Numbers()
        {

        }

        int[] A = new int[] { 1, 2, 3, 4, 5 };
        int[] B = new int[] { 1, 2, 5, 8, 9 };

        int[] concatenation = new int[5];

        public void Displays()
        {
            for (int i = 0; i < concatenation.Length; i++)
            {
                concatenation[i] = Convert.ToInt32(A[i].ToString() + B[i].ToString());
                Console.WriteLine(concatenation[i]);
            }
        }

    }
}
