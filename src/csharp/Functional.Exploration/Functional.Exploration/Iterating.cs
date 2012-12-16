using System;

namespace Functional.Exploration
{
    public class Iterating
    {
        public int[] Iterator(int[] input, Func<int, int> @operator)
        {
            var result = new int[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                result[i] = @operator(input[i]);
            }

            return result;
        }

        public int Square(int value)
        {
            return value*value;
        }

        public int Cubed(int value)
        {
            return value*value*value;
        }
    }
}