using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GA_BinarySearch_Ronda
{
    internal class BinarySearch
    {
        // This method takes an array of integers array and the target integer target as parameters.
        // It returns an integer representing the index of the target element in the array,
        // or -1 if the target element is not found.
        public static int IterativeBinarySearch(int[] array, int target)
        {
            // left reference starts at the first index of the array
            int left = 0;

            // right reference starts at the last index of the array
            int right = array.Length - 1; 

            // base case - check if left pointer is less than or equal to the right pointer
            while(left <= right)
            {   
                // find mid point of the portion of the array being searched
                int mid = left + (right - left) / 2;

                // if the target is found at the mid point, return the index of the mid point
                if (array[mid] == target) return mid;

                // if the value at the mid point is less than the search target,
                // make the index after the mid point the new left reference.
                // The next iteration will only search the right half.
                else if (array[mid] < target) left = mid + 1;

                // if the value at the mid point is more than the search target,
                // make the index before the mid point the new right reference.
                // The next iteration will only search the left half.
                else right = mid - 1;

            } // base case - if left pointer exceeds right pointer, the target was not found

            // return -1 if the search target is not found
            return -1;
        } // IterativeBinarySearch

        public static int RecursiveBinarySearch(int[] array, int target, int left, int right)
        {
            // base case - check if left pointer is less than or equal to the right pointer
            while (left <= right)
            {
                // find mid point of the portion of the array being searched
                int mid = left + (right - left) / 2;

                // if the target is found at the mid point, return the index of the mid point
                if (array[mid] == target) return mid;

                // if the value at the mid point is less than the search target,
                // search the right half recursively
                else if (array[mid] < target)
                {
                    return RecursiveBinarySearch(array, target, mid + 1, right);
                }

                // if the value at the mid point is more than the search target,
                // search the left half recursively
                else
                {
                    return RecursiveBinarySearch(array, target, left, mid - 1);
                }

            } // base case - if left pointer exceeds right pointer, the target was not found

            // return -1 if the search target is not found
            return -1;
        } // IterativeBinarySearch
    }
}
