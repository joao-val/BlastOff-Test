using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_1
{
    public class Calculate
    {
        public Calculate()
        {
            this.First = 0;
            this.Second = 0;
            this.Third = 0;
            this.Fourth = 0;
            this.Fifth = 0;
        }

        private Double I, J, K, X, Y;

        public double First
        {
            get { return I; }
            set
            {
                if (value >= 0) I = value;
                else I = 0;
            }
        }
        public double Second
        {
            get { return J; }
            set
            {
                if (value >= 0) J = value;
                else J = 0;
            }
        }
        public double Third
        {
            get { return K; }
            set
            {
                if (value >= 0) K = value;
                else K = 0;
            }
        }
        public double Fourth
        {
            get { return X; }
            set
            {
                if (value >= 0) X = value;
                else X = 0;
            }
        }
        public double Fifth
        {
            get { return Y; }
            set
            {
                if (value >= 0) Y = value;
                else Y = 0;
            }
        }

        public double Average
        {
            get { return (I + J + K + X + Y) / 5; }

        }

        public void Displays()
        {
            Console.WriteLine("Average: " + this.Average);
        }

    }
}
