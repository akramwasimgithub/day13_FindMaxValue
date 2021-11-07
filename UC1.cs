using System;
using System.Collections.Generic;
using System.Collections;


namespace TestMaximum
{
    class UC1
    {
        public int FindMaximum1(int first, int second, int third)
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