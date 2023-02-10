using System;
using Conditional;

namespace Basics
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(IfElseStatements.GreatestInteger(1, 2, 3, 4));
            Console.WriteLine(SwitchStatements.GreatestInteger(5, 4, 19, 9));
            Console.WriteLine(TernaryStatements.GreatestInteger(8, 5, 3, 2));
        }
    }
}