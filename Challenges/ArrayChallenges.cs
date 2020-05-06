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
            int[] newArray = new int[inputArray.Length + 1];

            decimal middle = Math.Ceiling(inputArray.Length / 2m);

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < middle)
                {
                    newArray[i] = inputArray[i];
                }
                else if (i == middle)
                {
                    newArray[i] = num;
                }
                else
                {
                    newArray[i] = inputArray[i - 1];
                }
            }

            return newArray;
        }
    }
}
