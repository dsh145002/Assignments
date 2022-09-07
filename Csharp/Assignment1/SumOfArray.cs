using System;

namespace Assignment1
{
    internal class SumOfArrayOfIntegers
    {
        public int FindTotalSum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
