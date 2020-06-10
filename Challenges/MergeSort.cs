using System;
namespace Challenges
{
    public class MergeSort
    {
        public static int[] MergeSorting(int[] inputArray)
        {
            if(inputArray == null)
            {
                throw new ArgumentException();
            }

            if(inputArray.Length > 1)
            {
                int mid = inputArray.Length / 2;

                int[] left = new int[mid];
                for(int m = 0; m < mid; m++)
                {
                    left[m] = inputArray[m];
                }

                int[] right = new int[inputArray.Length - mid];
                for (int m = mid; m < inputArray.Length; m++)
                {
                    right[m - mid] = inputArray[m];
                }
                MergeSorting(left);
                MergeSorting(right);

                int i = 0;
                int j = 0;
                int k = 0;

                while (i < left.Length && j < right.Length)
                {
                    if(left[i] < right[j])
                    {
                        inputArray[k] = left[i];
                        i++;
                    }
                    else
                    {
                        inputArray[k] = right[j];
                        j++;
                    }
                    k++;
                }

                while(i < left.Length)
                {
                    inputArray[k] = left[i];
                    i++;
                    k++;
                }

                while(j < right.Length)
                {
                    inputArray[k] = right[j];
                    j++;
                    k++;
                }
            }

            return inputArray;
        }

    }
}
