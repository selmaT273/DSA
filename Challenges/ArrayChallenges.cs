using System;
namespace Challenges
{
    public class ArrayChallenges
    {

        public static int[] ArrayReversed(int[] inputArray) 
        {

            int[] arr2 = new int[inputArray.Length];

            int j = 0;

            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                arr2[j] = inputArray[i];
                j++;
            }

            return arr2;
        }

        public static int[] InsertArrayShift(int[] inputArray, int num)
        {
            int j = 0;
            int[] newArray = new int[inputArray.Length + 1];
            int middle = inputArray.Length / 2;

            for (int i = 0; i < num + 1; i++)
            {
                if (j )
            }
        }
    }
}
