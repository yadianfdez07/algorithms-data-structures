using Arrays;
using Xunit;

namespace ArraysTests
{
    public class ArrayProblemSolverTests
    {
        ArrayProblemSolver sut;
        public ArrayProblemSolverTests()
        {
            sut = new ArrayProblemSolver();
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf1()
        {
            int[] expected = { 1 };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 1;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf2()
        {
            int[] expected = { 2 };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 2;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf3()
        {
            int[] expected = { 1, 2 };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 3;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf4()
        {
            int[] expected = { 4 };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 4;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf5()
        {
            int[] expected = { 2, 3 };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 5;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf6()
        {
            int[] expected = { 1, 2, 3 };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 6;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf7()
        {
            int[] expected = { 3, 4 };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 7;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf8()
        {
            int[] expected = { };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 8;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf9()
        {
            int[] expected = { 2, 3, 4 };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 9;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf10()
        {
            int[] expected = { 1, 2, 3, 4 };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 10;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldRetrieveSubArraySumOf11()
        {
            int[] expected = { };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 11;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldSortArrayIsAscendingOrder()
        {
            int[] expected = { 1, 2, 3, 4, 5 };
            int[] source = { 4, 3, 2, 5, 1 };

            var operationResult = sut.BubbleSort(source);

            Assert.Equal(expected, operationResult.SortedArray);
            Assert.Equal(25, operationResult.IterationCount);
            Assert.False(operationResult.Optimized);

        }

        [Fact]
        public void ShouldSortIsAscendingOrderWithLessIterationsWhenPossible()
        {
            int[] expected = { 1, 4, 7, 8, 9 };
            int[] source = { 8, 9, 1, 4, 7 };

            var operationResult = sut.BubbleSort(source);

            Assert.Equal(expected, operationResult.SortedArray);
            Assert.Equal(15, operationResult.IterationCount);
            Assert.True(operationResult.Optimized);

        }

        [Fact]
        public void ShouldIterateOnlyOnceWhenArrayIsSorted()
        {
            // arrange
            int[] expected = { 1, 2, 3, 4, 5 };
            int[] source = { 1, 2, 3, 4, 5 };

            // act
            var operationResult = sut.BubbleSort(source);

            // assert
            Assert.Equal(expected, operationResult.SortedArray);
            Assert.Equal(5, operationResult.IterationCount);
            Assert.True(operationResult.Optimized);
        }

        [Fact]
        public void ShouldIterateOnlyOnceWhenArrayIsSortedInDescendingOrder()
        {
            // arrange
            int[] expected = { 5, 4, 3, 2, 1 };
            int[] source = { 5, 4, 3, 2, 1 };

            // act
            var operationResult = sut.BubbleSort(source, true);

            // assert
            Assert.Equal(expected, operationResult.SortedArray);
            Assert.Equal(5, operationResult.IterationCount);
            Assert.True(operationResult.Optimized);
        }

        [Fact]
        public void ShouldSortArrayInDescendingOrder()
        {
            // arrange
            int[] expected = { 5, 4, 3, 2, 1 };
            int[] source = { 1, 2, 3, 4, 5 };


            // act
            var operationResult = sut.BubbleSort(source, true);

            // assert
            Assert.Equal(expected, operationResult.SortedArray);
            Assert.Equal(25, operationResult.IterationCount);
            Assert.False(operationResult.Optimized);
        }

        [Fact]
        public void ShouldSortInDescendingOrderOrderWithLessIterationsWhenPossible()
        {
            int[] expected = { 9, 8, 7, 4, 1 };
            int[] source = { 8, 9, 1, 4, 7 };

            var operationResult = sut.BubbleSort(source, true);

            Assert.Equal(expected, operationResult.SortedArray);
            Assert.Equal(15, operationResult.IterationCount);
            Assert.True(operationResult.Optimized);

        }

        [Fact]
        public void ShouldSortInDescendingOrderOrderWithLessIterationsWhenPossibleWithDuplicates()
        {
            int[] expected = { 9, 8, 7, 7, 4, 1 };
            int[] source = { 8, 9, 7, 1, 4, 7 };

            var operationResult = sut.BubbleSort(source, true);

            Assert.Equal(expected, operationResult.SortedArray);
            Assert.Equal(18, operationResult.IterationCount);
            Assert.True(operationResult.Optimized);

        }
    }
}
