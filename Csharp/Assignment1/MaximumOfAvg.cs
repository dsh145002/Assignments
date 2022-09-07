using System;

namespace Assignment1
{
    class MaximumOfAvg
    {
        public int FindMax(int[] arr)
        {
            int Highest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Highest)
                {
                    Highest = arr[i];
                }
            }
            return Highest;
        }
    }
}