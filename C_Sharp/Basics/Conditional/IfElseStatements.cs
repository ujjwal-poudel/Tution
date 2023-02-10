using System;

namespace Conditional
{
    public class IfElseStatements
    {   
        public static int GreatestInteger(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static int GreatestInteger(int a, int b, int c)
        {
            int great = GreatestInteger(a, b);

            return GreatestInteger(great, c);
        }

        public static int GreatestInteger(int a, int b, int c, int d)
        {
            int great = GreatestInteger(a, b, c);

            return GreatestInteger(great, d);
        }
    }
}