using System;
using System.Diagnostics;
using System.Linq;

namespace Arrays
{
    public class ArrayProblemSolver
    {

        public int[] GetSubArraySum(int[] source, int value)
        {
            bool found = false;

            int lowerIndex = 0;

            int upperIndex = 0;

            for (int i = 0; i < source.Length; i++)
            {
                lowerIndex = i;

                if (source[i] == value)
                {
                    return new int[] { source[i] };
                }

                int target = source[i];

                var nextVal = lowerIndex + 1;

                for (int j = nextVal; j < source.Length; j++)
                {
                    target += source[j];

                    if (target == value)
                    {
                        upperIndex = j;
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            int take = (upperIndex - lowerIndex) + 1;

            return source.Skip(lowerIndex)
                        .Take(take)
                        .ToArray();
        }

        public int[] BubbleSort(int[] source)
        {
            // sort direction ascending or descending
            // escape if already in order

            int tmp;
            for (int i = 0; i < source.Length; i++)
            {
                for (int j = 0; j < source.Length - 1; j++)
                {
                    if (source[j] > source[j + 1])
                    {
                        tmp = source[j + 1];
                        source[j + 1] = source[j];
                        source[j] = tmp;
                    }
                }
            }

            return source;
        }

    }
}