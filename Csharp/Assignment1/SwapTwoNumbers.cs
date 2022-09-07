using System;

namespace Assignment1
{
    internal class SwapTwoNumbers
    {
        public void Swapping(int a, int b) { 
            a = a + b;
            b = a - b;
            a = a - b;
            //OR we can do
            //temp=a;
            //a=b;
            //b=temp;
            Console.WriteLine("Integers after swapping are A = {0} and B = {1}\n", a, b);
        }
    }
}
