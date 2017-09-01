using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening som ska översättas");
            string text = Console.ReadLine();
            text = text.Replace('a', '4')
                .Replace('A', '4')
                .Replace('b', '8')
                .Replace('B', '8')
                .Replace('c', '(')
                .Replace('C', '(')
                .Replace("d", "|)")
                .Replace("D", "|)")
                .Replace('e', '3')
                .Replace('E', '3')
                .Replace("f", "|=")
                .Replace("F", "|=")
                .Replace('g', '6')
                .Replace('G', '6')
                .Replace('h', '#')
                .Replace('H', '#')
                .Replace('i', '1')
                .Replace('I', '1')
                .Replace("j", "_|")
                .Replace("J", "_|")
                .Replace("k", "|<")
                .Replace("K", "|<")
                .Replace("l", "|_ ")
                .Replace("L", "|_ ")
                .Replace("m", "/\\/\\")
                .Replace("M", "/\\/\\")
                .Replace("n", "/\\/")
                .Replace("N", "/\\/")
                .Replace('o', '0')
                .Replace('O', '0')
                .Replace("p", "|2 ")
                .Replace("P", "|2 ")
                .Replace("q", "(,)")
                .Replace("Q", "(,)")
                .Replace("r", "|?")
                .Replace("R", "|?")
                .Replace('s', '5')
                .Replace('S', '5')
                .Replace('t', '7')
                .Replace('T', '7')
                .Replace("u", "|_|")
                .Replace("U", "|_|")
                .Replace("v", "\\/")
                .Replace("V", "\\/")
                .Replace("w", "\\/\\/")
                .Replace("W", "\\/\\/")
                .Replace("x", "><")
                .Replace("X", "><")
                .Replace("y", "`/")
                .Replace("Y", "`/")
                .Replace('z', '2')
                .Replace('Z', '2');
            Console.WriteLine(text);
        }
    }
}
