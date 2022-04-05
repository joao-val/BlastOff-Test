using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_14
{
    internal class Palindrome
    {
        public Palindrome()
        {

        }

        string word;
        int x;

        public void Displays()
        {
            Console.WriteLine("Type the phrase or word to be verified:");

            word = Console.ReadLine();
            string word1 = String.Concat(word.ToUpper().Where(x => !Char.IsWhiteSpace(x)));
            x = word1.Length - 1;

            while (x != -1)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    if (word1[i] == word1[x])
                    {
                        if (x == 0)
                        {
                            Console.WriteLine("'" + word + "' It's palindrome!");
                            Console.ReadLine();
                        }
                        x--;
                    }
                    else
                    {
                        Console.WriteLine("'" + word + "' not a palindrome");
                        i = word1.Length;
                        x = -1;

                        Console.ReadLine();
                    }
                }
            }
        }

    }
}
