using System.Collections.Generic;
using static System.Console;

namespace Task_03
{
    internal class Program
    {
        static void Main()
        {
            HashSet<int> numSet = new HashSet<int>();
            while (true)
            {
                Write("Введите любое целое число: ");
                string numStr = ReadLine();

                if (numStr == string.Empty) break;

                int number = int.Parse(numStr);

                if (numSet.Contains(number))
                    WriteLine($"Число {number} уже вводилось ранее.\n");
                else
                {
                    numSet.Add(number);
                    WriteLine($"Число {number} успешно записано.\n");
                }
            }
        }
    }
}
