using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_NEW_Massive_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 3, 5, 6, 1, 9, 41, 32, 2, 4, 99, 21, 1567, 10, 1};
            int tempNumbers;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        tempNumbers = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tempNumbers;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
