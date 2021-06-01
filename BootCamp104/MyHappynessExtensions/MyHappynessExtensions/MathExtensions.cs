using System;

namespace MyHappynessExtensions
{
    public static class MathExtensions
    {
        public static double Power(this double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
