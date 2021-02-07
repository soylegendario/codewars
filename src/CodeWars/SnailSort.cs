/*
Snail Sort

Given an n x n array, return the array elements arranged from outermost elements to the 
middle element, traveling clockwise.

array = [[1,2,3],
         [4,5,6],
         [7,8,9]]
snail(array) #=> [1,2,3,6,9,8,7,4,5]
For better understanding, please follow the numbers of the next array consecutively:

array = [[1,2,3],
         [8,9,4],
         [7,6,5]]
snail(array) #=> [1,2,3,4,5,6,7,8,9]
 */

using System;
using System.Collections.Generic;

namespace CodeWars
{
    public static class SnailSort
    {
        public static int[] Snail (int[][] array)
        {
            if (array.Length == 0 || array[0].Length == 0) {
                return Array.Empty<int>();
            }
            var snail = new List<int> ();
            var init = 0;
            var size = array.Length - 1;

            // Loop to insert in snail the outbound ring
            while (init <= size) {
                // Top row
                for (var i = init; i < size; i++) {
                    snail.Add(array[init][i]);
                }
                // Last column
                for (var i = init; i < size; i++) {
                    snail.Add(array[i][size]);
                }
                // Last row
                for (var i = size; i >= init; i--) {
                    snail.Add(array[size][i]);
                }
                // First column (without first and last cell)
                for (var i = size - 1; i > init; i--) {
                    snail.Add(array[i][init]);
                }

                // Update variables to catch the next ring
                ++init;
                --size;
            }
            
            return snail.ToArray ();
        }
    }
}