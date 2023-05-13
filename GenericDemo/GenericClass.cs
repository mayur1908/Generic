using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class GenericClass<T> where T : IComparable
    {
        private T variable1; // First variable of generic type T
        private T variable2; // Second variable of generic type T
        private T variable3; // Third variable of generic type T

        public GenericClass(T var1, T var2, T var3)
        {
            variable1 = var1; // Assign the value of var1 to variable1
            variable2 = var2; // Assign the value of var2 to variable2
            variable3 = var3; // Assign the value of var3 to variable3
        }

        public T TestMaximum()
        {
            return GetMaximum(variable1, variable2, variable3); // Call the static GetMaximum method passing the three instance variables
        }

        private static T GetMaximum(T value1, T value2, T value3)
        {
            T maximum = value1; // Assume value1 is the maximum

            if (value2.CompareTo(maximum) > 0)
            {
                maximum = value2; // If value2 is greater than maximum, update maximum to value2
            }
            if (value3.CompareTo(maximum) > 0)
            {
                maximum = value3; // If value3 is greater than maximum, update maximum to value3
            }

            return maximum; // Return the maximum value
        }
    }
}
