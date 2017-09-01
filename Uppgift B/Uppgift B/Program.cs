using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            int j = 0;

            Array.Sort(words, (x, y) => y.Length.CompareTo(x.Length));
            foreach (string s in words)
            {
                Console.WriteLine(words[j]);
                j++;
            }
            j = 0;
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string s in words)
            {
                Console.WriteLine(words[j]);
                j++;
            }

            /*int noWords = 0;
            int[] wordLength = new int[100];
            int length = 0;
            int pos = 0;
            int längsta = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsWhiteSpace(sentence[i]))
                {
                    wordLength[pos] = length;
                    length = 0;
                    noWords++;
                    pos++;
                } else
                { 
                    length++;
                    words[i] = sentence[i];
                }
            }
            noWords++;
            int[] wordLengthTemp = new int[100];
            for (int i = 0; i <= noWords; i++)
            {
                wordLengthTemp[i] = wordLength[i];
            }
            pos = 0;
            int[] posLängd = new int[100];
            for (int i = 0; i <= noWords; i++)
            {
                for (int j = 0; j <= noWords; j++)
                {
                    if (wordLengthTemp[j] > längsta)
                    {
                        längsta = wordLengthTemp[j];
                        pos = j;
                    }
                }
                posLängd[i] = längsta;
                längsta = 0;
                wordLengthTemp[pos] = 0;
                pos = 0;
            }*/
        }
    }
}
