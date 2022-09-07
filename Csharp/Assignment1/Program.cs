using System;
using System.Linq;

namespace Assignment1
{
class Program
{
        //q3 class
        public static int FindTotalSum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static void Main(string[] args)
        {

            //Q2 - Find the maximum from given average marks of 5 students;
            MaximumOfAvg m = new MaximumOfAvg();
            int[] AvgMarks = new int[5];
            Console.WriteLine("Enter Average Marks of 5 students: ");
            for (int i = 0; i < 5; i++)
                {
                    AvgMarks[i] = Convert.ToInt32(Console.ReadLine());
                }
            //Finding maximum values in array using Max function in System.Linq library
            //    Console.WriteLine(AvgMarks.Max());
            Console.WriteLine("Highest marks Obtained = {0}\n",m.FindMax(AvgMarks));

            
            //Q3 - Find the sum of Array of Integers
            //This is included in this file because it is static method
            Console.WriteLine("Enter the size of Array of Integers: ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the Integers : ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sum of all integers in the array = {0}\n",FindTotalSum(arr));

            //Q4 - Swap Two numbers
            SwapTwoNumbers s = new SwapTwoNumbers();
            int A, B;
            Console.WriteLine("Enter the two numbers : ");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integers before swapping are A = {0} and B = {1}", A, B);
            s.Swapping(A, B);

            //Q5 - Calculate Area and Circumference of Circle
            Circle c = new Circle();
            double radius;
            Console.WriteLine("Enter the Radius of Circle");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area and Circumference of circle with radius {0} is {1} respectively ", radius, c.CalculateAreaCircumference(radius));
        }
}
}


