using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening");
            string mening = Console.ReadLine();
            string[] sub = mening.Split(' ');
            Console.WriteLine("Antal ord är "+sub.Length);
            for (int i=0; i < sub.Length; i++)
            {
                Console.Write(sub[i]);
                Console.WriteLine("("+sub[i].Length+")");
            }
            
            Console.ReadLine();
        }
    }
}
