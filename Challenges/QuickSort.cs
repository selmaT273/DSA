using System;
namespace Challenges
{
    public class QuickSort
    {
        public static int[] QuickSorting(int[] inputArr, int left, int right)
        {
            int pivotIndex = 0;

            if(left < right)
            {
               pivotIndex = Partition(inputArr, left, right);
            }

            if (left < pivotIndex - 1)
            {
                QuickSorting(inputArr, left, pivotIndex - 1);
            }

            if (pivotIndex < right)
            {
                QuickSorting(inputArr, pivotIndex, right);
            }

            return inputArr;
        }

        public static int Partition(int[] inputArr, int left, int right)
        {
            int pivotIndex = (right + left) / 2;
            int pivot = inputArr[pivotIndex];

            int l = left;
            int r = right;

            Swap(inputArr, pivotIndex, right);
            r--;

            while (l <= r)
            {
                while (l <= r && inputArr[l] < pivot)
                {
                    l++;
                }

                while (l <= r && inputArr[r] > pivot)
                {
                    r--;
                }

                if(l >= r)
                {
                    Swap(inputArr, left, right);

                    l++;
                    r--;
                }
            }

            return l;

        }

        public static void Swap(int[] inputArr, int left, int right)
        {
            int temp = inputArr[left];
            inputArr[left] = inputArr[right];
            inputArr[right] = temp;
        }
    }
}
