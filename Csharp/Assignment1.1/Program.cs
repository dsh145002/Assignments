using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    internal class Program
    {
        public static double addition(double a, double b)
        {
            return a + b;
        }
        public static double subtraction(double a, double b)
        {
            if (a < b) return b - a;
            return a - b;
        }
        public static double multiplication(double a, double b)
        {
            return a * b;
        }
        public static double division(double a, double b)
        {
            return a/b;
        }
        static void Main(string[] args)
        {
            double a, b;
            string choice;
            string cont="Y";
            do
            {
                
                Console.WriteLine("Press 1 for addition\nPress 2 for subtraction\nPress 3 for multiplication\n" +
                    "Press 4 for division\nEnter your choice: ");
                choice = (Console.ReadLine());
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the first number : ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the second number : ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Addition = "+addition(a, b));
                        break;
                    case "2":
                        Console.WriteLine("Enter the first number : ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the second number : ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Subtraction = " + subtraction(a, b));
                        break;
                    case "3":
                        Console.WriteLine("Enter the first number : ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the second number : ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Multiplication = " + multiplication(a, b));
                        break;
                    case "4":
                        Console.WriteLine("Enter the first number : ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the second number : ");
                        b = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine(a==0||b==0?"Cannot be 0": "Multiplication = " + division(a, b));
                        break;
                    default:
                        Console.WriteLine("Enter correct Option\n");
                        break;
                }
                Console.WriteLine("Do you want to continue Y/N :");
                cont = Console.ReadLine().ToUpper();
            } while (cont == "Y");
        }
    }
}
