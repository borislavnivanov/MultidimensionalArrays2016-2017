using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            
            while (true)
            {
                string a = Console.ReadLine();
                if (a != "")
                {
                    input.Add(a);
                    continue;
                }
                else
                {
                    break;
                }
            }

            input.Sort((a, b) => a.Length.CompareTo(b.Length));
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
