using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    class UC2
    {
        public float FindMaximum2(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("All three having same number");
                return -1;
            }
        }
    }
}
