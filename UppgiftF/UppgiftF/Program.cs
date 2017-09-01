using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal mellan 1-21");
            int gissning;
            Random slump = new Random();
            int tal = slump.Next(1, 22);
            bool fel = true;

            do
            {
                gissning = Convert.ToInt32(Console.ReadLine());
                if (gissning == tal)
                {
                    Console.WriteLine("Grattis!");
                    fel = false;
                }
            }
            while (fel);
            

            
        }
    }
}
