using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 20, 12, 942, -29, 92, -100 };
            Sort(array, AscendingCondition); //passing only name without parentheses
            Console.WriteLine(string.Join(", ", array));

        }

        delegate bool ConditionalDelegate(int a, int b);
        static bool AscendingCondition(int a, int b)
        {
            return a < b;
        }

        static bool DescendingCondition(int a, int b)
        {
            return a > b;
        }
        static void Sort(int[] array, ConditionalDelegate condition)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j <array.Length; j++)
                {
                    if (condition(array[i], array[j]))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        
    }
}
