using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett ord, skriv AVSLUTA för att avsluta, max 100 ord");
            string input = Console.ReadLine();
            string[] words = new string[100];
            int i = 0;

            while (input != "AVSLUTA")
            {
                words[i] = input;
                input = Console.ReadLine();
                i++;
            }
            Console.Write("Din mening just nu är ");
            for (int j = 0; j < i; j++)
            {
                Console.Write(words[j]+" ");
            }
            Console.WriteLine();
        }
    }
}
