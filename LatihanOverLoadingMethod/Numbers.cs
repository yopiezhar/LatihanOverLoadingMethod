using System;

namespace LatihanOverLoadingMethod
{
    internal class Numbers
    {
        public int FindingMinimum(int number1, int number2)
        {
            return (int)Math.Min(number1, number2);

        }

        public int FindingMinimum(int number1, int number2, float number3)
        {
            return (int)Math.Min(number1, Math.Min(number2, number3));
        }

        public int FindMaximum(int number1, int number2)
        {
            return (int)Math.Max(number1, number2);

        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            return (int)Math.Max(number1, Math.Max(number2, number3));
        }
    }
}