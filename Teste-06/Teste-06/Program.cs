using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Teste_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);

            string a, b;
            TimeSpan r;

            int year = 2022;

            int month = 02;

            int day = 15;

            Console.WriteLine("Enter the game start time in the format hh:mm:ss :");
            a = Console.ReadLine();

            string[] x = a.Split(':');

            int h = int.Parse(x[0].ToString());

            int m = int.Parse(x[1].ToString());

            int s = int.Parse(x[2].ToString());

            DateTime he = new DateTime(year, month, day, h, m, s);

            Console.WriteLine("Enter the game end time in the format hh:mm:ss :");
            b = Console.ReadLine();

            string[] z = b.Split(':');

            h = int.Parse(z[0].ToString());

            m = int.Parse(z[1].ToString());

            s = int.Parse(z[2].ToString());


            DateTime hs = new DateTime(year, month, day, h, m, s);

            Console.WriteLine("Game start time:" + a);

            Console.WriteLine("Game end time:" + b);

            r = hs - he;

            Console.WriteLine("The game lasted "+ r.TotalMinutes.ToString() + " minutes");

            Console.ReadKey();
        }
    }
}