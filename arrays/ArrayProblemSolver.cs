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

        public OperationOutput BubbleSort(int[] source, bool descending = false)
        {
            int counter = 0;

            for (int i = 0; i < source.Length; i++)
            {
                counter++;
                bool swap = false;

                if (!descending)
                {
                    for (int j = 0; j < source.Length - 1; j++)
                    {
                        int tmp;

                        if (source[j] > source[j + 1])
                        {
                            tmp = source[j + 1];
                            source[j + 1] = source[j];
                            source[j] = tmp;
                            swap = true;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < source.Length - 1; j++)
                    {
                        int tmp;

                        if (source[j] < source[j + 1])
                        {
                            tmp = source[j + 1];
                            source[j + 1] = source[j];
                            source[j] = tmp;
                            swap = true;
                        }
                    }
                }

                if (!swap)
                {
                    break;
                }
            }

            /*
bool isNotSorted = true;
do
{
    counter++;
    isNotSorted = false;
    for (int j = 0; j < source.Length - 1; j++)
    {
        int tmp;

        if (source[j] > source[j + 1])
        {
            tmp = source[j + 1];
            source[j + 1] = source[j];
            source[j] = tmp;
            isNotSorted = true;
        }
    }

} while (isNotSorted);
            */


            return new OperationOutput { SortedArray = source, IterationCount = counter * source.Length, Optimized = counter != source.Length };
        }

    }

    public class OperationOutput
    {
        public int[] SortedArray { get; set; }

        public int IterationCount { get; set; }

        public bool Optimized { get; set; }
    }
}