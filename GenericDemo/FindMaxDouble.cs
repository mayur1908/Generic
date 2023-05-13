using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class FindMaxDouble
    {
        public static double MaxNumber(double num1, double num2, double num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num2) > 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 || num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 || num3.CompareTo(num2) > 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }
            return num1;

        }
    }
}
