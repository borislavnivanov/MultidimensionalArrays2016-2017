using System;


namespace Maximal_um
{
    class MaximalSum
    {
        static void Main()
        {
            string[] sizes = Console.ReadLine().Split(' ');
            int[,] array = new int[int.Parse(sizes[0]), int.Parse(sizes[1])];
            int maxSum = 0;
            bool isNegative = false;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(numbers[j]);
                }
            }

            for (int i = 0; i < array.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < array.GetLength(1) - 2; j++)
                {
                    int sum = array[i, j] + array[i, j + 1] + array[i + 1, j] + array[i + 1, j + 1] + array[i, j + 2] + array[i + 2, j] + array[i + 2, j + 2] + array[i + 1, j + 2] + array[i + 2, j + 1];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        isNegative = false;
                    }
                }
            }
            
            Console.WriteLine(maxSum);
        }
    }
}
