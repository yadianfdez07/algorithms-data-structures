using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[5];
            int[] array2 = { 1, 3, 5, 7, 9 };

            Console.WriteLine(arrayOne.Length);

            string[] arrayTwo = new string[] { "itemOne", "itemTwo" };
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            Console.WriteLine(arrayTwo.Length);

            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }

            var result = ArrayOperator.Merge<string>(arrayTwo, weekDays);

            for (int i = 0; i < result.Length; i++)
            {
                System.Console.WriteLine(result[i]);
            }
        }
    }

}

