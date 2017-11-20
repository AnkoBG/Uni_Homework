using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2
{
    class RationalNumber
    {
        private int numerator, denominator;
        public RationalNumber()
        {
            numerator = 0;
            denominator = 0;
        }
        public RationalNumber(int num, int denom)
        {
            numerator = num;
            denominator = denom;
            this.Rationalize();
        }
        public decimal ToDecimal()
        {
            return (decimal)numerator / denominator;
        }
        public override string ToString()
        {
            return String.Format("{0}/{1}", numerator, denominator);
        }
        public void Rationalize()
        {
            int minNum = 1;
            int minDenom = 1;
            for (int i = 1; i <= denominator; i++)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    minNum = numerator / i;
                    minDenom = denominator / i;
                }
            }
            numerator = minNum;
            denominator = minDenom;
        }
        public RationalNumber Add(RationalNumber rn)
        {
            int newNumerator;
            int newDenominator = 0;
            newNumerator = numerator * rn.denominator + rn.numerator * denominator;
            newDenominator = denominator * rn.denominator;
            return new RationalNumber(newNumerator, newDenominator);
        }
    }
}
