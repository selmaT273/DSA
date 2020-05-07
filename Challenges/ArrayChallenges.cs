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
            // Create new empty array one index bigger than the input array
            int[] newArray = new int[inputArray.Length + 1];

            // Finding middle of input and
            // Using Math.Ceiling says if there's not an exact middle, look to the right
            decimal middle = Math.Ceiling(inputArray.Length / 2m);

            // Loop through newArray 
            for (int i = 0; i < newArray.Length; i++)
            {
                // If below the middle 
                if (i < middle)
                {
                    // Set current index of newArray equal to value of inputArray at same index
                    newArray[i] = inputArray[i];
                }

                // If we're on the middle index
                else if (i == middle)
                {
                    // Set current index of newArray equal to num that was passed in
                    newArray[i] = num;
                }

                // If we're past the middle index
                else
                {
                    // Set current index of newArray equal to inputArray's value at the index 1 below
                    newArray[i] = inputArray[i - 1];
                }
            }

            // Return the new array with the num in the middle
            return newArray;
        }

        public static int[] BinarySearch(int[] inputArray, int searchKey)
        {

            return inputArray;
        }
    }
}
