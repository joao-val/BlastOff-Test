using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_11
{
    internal class Numbers
    {

        public Numbers()
        {

        }

        int[] A =  { 1, 2, 3, 4, 10};
        int[] B =  { 1, 2, 5, 8, 10};
        int intersection = 0;


        public void Displays()
        {
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (B[i] == A[j])
                    {
                        intersection++;
                    }
                }
            }
            int[] C = new int[intersection];
            intersection = 0;

            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (B[i] == A[j])
                    {
                        C[intersection] = B[j];
                        Console.WriteLine(C[intersection] + " ");
                        intersection++;
                    }
                }
            }
        }
    }
}
