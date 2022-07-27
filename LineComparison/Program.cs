using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program!");
            Console.WriteLine("===========UC1===========");
            Console.WriteLine("===========UC2===========");
            Length UC1 = new Length();
            UC1.EqualityOfLines();
        }
    }
}
