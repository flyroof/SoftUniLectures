using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Words
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(new[] {' ', ',', ';', '.'},
                StringSplitOptions.RemoveEmptyEntries);

            string longsetWord = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (currentWord.Length > longsetWord.Length)
                {
                    longsetWord = currentWord;
                }
            }

            Console.WriteLine(longsetWord);
        }
    }
}
