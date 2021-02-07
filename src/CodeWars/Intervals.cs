/*
Write a function called sumIntervals/sum_intervals() that accepts an array of intervals, 
and returns the sum of all the interval lengths. Overlapping intervals should only be 
counted once.

Intervals
Intervals are represented by a pair of integers in the form of an array. The first value 
of the interval will always be less than the second value. Interval example: [1, 5] is 
an interval from 1 to 5. The length of this interval is 4.

Overlapping Intervals
List containing overlapping intervals:

[
   [1,4],
   [7, 10],
   [3, 5]
]
The sum of the lengths of these intervals is 7. Since [1, 4] and [3, 5] overlap, we can treat 
the interval as [1, 5], which has a length of 4.

Examples:
sumIntervals( [
   [1,2],
   [6, 10],
   [11, 15]
] ); // => 9

sumIntervals( [
   [1,4],
   [7, 10],
   [3, 5]
] ); // => 7

sumIntervals( [
   [1,5],
   [10, 20],
   [1, 6],
   [16, 19],
   [5, 11]
] ); // => 19
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Intervals
    {
       public static int SumIntervals((int, int)[] intervals)
       {
          var orderedIntervals = intervals
             .OrderBy(i => i.Item1)
             .ThenBy(i => i.Item2)
             .ToList();
          var intervarlsWithoutOverlapped = new List<ValueTuple<int, int>> ();
          var jumpIndexes = new List<int> ();
          for (var i = 0; i < orderedIntervals.Count; i++) {
             if (jumpIndexes.Contains(i)) {
                continue;
             }
             var interval = orderedIntervals[i];
             for (var j = i + 1; j < orderedIntervals.Count; j++) {
                if ((orderedIntervals[j].Item1 >= interval.Item1 && orderedIntervals[j].Item1 <= interval.Item2)
                   || (orderedIntervals[j].Item2 <= interval.Item2 && orderedIntervals[j].Item2 >= interval.Item1) 
                   ) {
                   interval.Item1 = Math.Min (interval.Item1, orderedIntervals[j].Item1);
                   interval.Item2 = Math.Max (interval.Item2, orderedIntervals[j].Item2);
                   jumpIndexes.Add(j);
                }
             }

             intervarlsWithoutOverlapped.Add(interval);
          }
          return intervarlsWithoutOverlapped.Sum (interval => interval.Item2 - interval.Item1);
       }        
    }
}