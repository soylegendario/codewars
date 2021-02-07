using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Diagonals
    {
        public static int DiagonalsDiff (List<List<int>> arr)
        {
            if (arr == null || arr.Any(r => r == null)) {
                throw new ArgumentException();
            }

            if (arr.Any(r => r.Count != arr[0].Count)) {
                throw new ArgumentException("The matrix must be square");
            }
            
            var d1 = 0;
            var d2 = 0;
            var contD1 = 0;
            var contD2 = arr[0].Count - 1;
            foreach (var row in arr) {
                d1 += row[contD1];
                ++contD1;
                d2 += row[contD2];
                --contD2;
            }
            return Math.Abs (d1 - d2);
        }  
    }
}