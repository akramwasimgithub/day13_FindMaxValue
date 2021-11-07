using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
   
        public class Findmaximum<T> where T : IComparable
        {
            public T[] inputArray;

            public Findmaximum(T[] inputArray)
            {
                this.inputArray = inputArray;
            }

            public T[] Sort(T[] inputArry)
            {
                Array.Sort(inputArray);
                return inputArray;

            }



            public T MaxValue(params T[] inputArray)
            {

                var sorted_value = Sort(inputArray);
                return sorted_value[^1];
            }

            public T MaxMethod()
            {
                var max = MaxValue(this.inputArray);
                return max;

            }
            public void PrintMaxValue()
            {
                var max = MaxValue(this.inputArray);
                Console.WriteLine("maximum value is: " + max);

            }


        }
    }

