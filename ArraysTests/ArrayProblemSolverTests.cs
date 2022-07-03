using Arrays;
using System;
using System.Diagnostics;
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
            int[] expected = {  };
            int[] source = { 1, 2, 3, 4, 5 };
            int sumValue = 11;

            int[] result = sut.GetSubArraySum(source, sumValue);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldSortArrayAscending()
        {
            int[] expected = { 1, 2, 3, 4, 5 };
            int[] source = { 2, 4, 5, 1, 3 };

            var result = sut.BubbleSort(source);

            Assert.Equal(expected, result);

        }

        [Fact]
        public void ShouldSortAnotherArrayAscending()
        {
            int[] expected = { 1, 4, 7, 8, 9 };
            int[] source = { 8, 9, 1, 4, 7 };

            var result = sut.BubbleSort(source);

            Assert.Equal(expected, result);

        }

    }
}
