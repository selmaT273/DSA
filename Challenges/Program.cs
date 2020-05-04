using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayReversed();
        }

        static void ArrayReversed()
        {
            int[] arr1 = { 3, 8, 5, 9, 12 };
            int[] arr2 = new int[5];

            int j = 0;

            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                arr2[j] = arr1[i];
                j++;
            }

            Console.Write(string.Join(",", arr2));
        }
    }
}
