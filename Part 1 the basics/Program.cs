using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_the_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOne = "Timmy";
            string nameTwo = "     Tommy";
            string schoolCheer = "Programers are the best!";
            Console.WriteLine("'Hello " + nameOne + ".' Said " + nameTwo.Trim() + ".");
            Console.WriteLine($"'Hello {nameTwo.Trim()}.' Said {nameOne}.");
            Console.WriteLine($"{nameOne} has {nameOne.Length} letters in his name. {nameTwo} also has {nameTwo.Length} letters in his name.");
            // I prefer string interpolation.
            // Trim gets rid of blank spaces in the start & end of strings.
            Console.Write(schoolCheer.ToUpper());
            Console.Write("     " + schoolCheer.StartsWith("Programers"));
            //Console.Write just continues on the same line,instead of starting a new line.
            Console.WriteLine(Console.ReadLine());
        }
    }
}
