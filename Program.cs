using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1 obj1 = new UC1();
            int maxValueInt = obj1.FindMaximum1(70, 35, 56);
            Console.WriteLine("the maximum number is: " + maxValueInt);

            Console.WriteLine("------------------------------");

            UC2 obj2 = new UC2();
            float maxValueFloat = obj2.FindMaximum2(25.4f, 54.2f, 66.2f);
            Console.WriteLine("the maximum float is: " + maxValueFloat);


            Console.WriteLine("------------------------------");

            UC3 obj3 = new UC3();
            string maxValuestring = obj3.FindMaximum2("Apple", "Peach", "Banana");
            Console.WriteLine(maxValuestring);
            Console.ReadLine();

            //using generic class 
            Console.WriteLine("By using generic class");

            int[] intArray = { 4, 5, 6, 44, };
            double[] doubleArray = { 5.2, 55.1, 6.2, 8.2 };
            string[] stringArray = { "Apple", "Peach", "Banana" };


            Findmaximum<int> generic = new Findmaximum<int>(intArray);
            generic.PrintMaxValue();
            new Findmaximum<double>(doubleArray).PrintMaxValue();
            Findmaximum<string> stringgeneric = new Findmaximum<string>(stringArray);
            stringgeneric.PrintMaxValue();

        }
    }
}
