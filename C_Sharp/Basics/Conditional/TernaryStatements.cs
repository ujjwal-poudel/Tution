using System;

namespace Conditional
{
    public class TernaryStatements
    {
        public static int GreatestInteger(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int GreatestInteger(int a, int b, int c)
        {
            int great = TernaryStatements.GreatestInteger(a, b);

            return TernaryStatements.GreatestInteger(great, c);
        }

        public static int GreatestInteger(int a, int b, int c, int d)
        {
            int great = TernaryStatements.GreatestInteger(a, b, c);

            return TernaryStatements.GreatestInteger(great, d);
        }
    }
}