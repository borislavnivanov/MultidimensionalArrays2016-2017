using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            Array.Sort(array);
            int result = Array.BinarySearch(array, k);
            if (result < 0 && array[array.Length - 1] > k)
            {
                result = array[array.Length - 1];
            }
            Console.WriteLine(result);
        }
    }
}
