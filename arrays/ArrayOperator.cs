namespace Arrays
{
    static class ArrayOperator
    {
        public static T[] Merge<T>(T[] inputOne, T[] inputTwo)
        {
            var newLength = inputOne.Length + inputTwo.Length;

            var output = new T[newLength];

            for (int i = 0; i < newLength;)
            {
                for (int j = 0; j < inputOne.Length; j++)
                {
                    output[i] = inputOne[j];
                    i++;
                }               
                
                for (int k = 0; k < inputTwo.Length; k++)
                {
                    output[i] = inputTwo[k];
                    i++;
                }               
            }

            return output;
        }
    }

}

