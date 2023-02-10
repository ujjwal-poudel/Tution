using System;

namespace Conditional
{
    public class SwitchStatements
    {
        public static int GreatestInteger(int a, int b)
        {
            switch (a > b)
            {
                case true:
                    return a;
                default:
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