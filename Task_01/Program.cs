using System;
using System.Collections.Generic;
using static System.Console;

namespace Task_01
{
    internal class Program
    {
        static void Main()
        {
            List<byte> curList = ListInit();

            WriteLine("Сгенерированный список:");
            PrintList(curList);

            WriteLine("\n\nОтфильтрованный список: ");
            PrintList(FilterList(curList));
            ReadKey(true);
        }

        //Инициализация списка
        static List<byte> ListInit()
        {
            Random rndmNum = new Random();

            List<byte> numList= new List<byte>();

            for (byte step = 0; step <= 100; step++)
                numList.Add((byte)rndmNum.Next(0, 101));

            return numList;
        }

        //Вывод данных списка
        static void PrintList(List<byte> srcList)
        {
            foreach (byte item in srcList)
            {
                Write($" {item, 3}");
            }
        }

        //Фильтрование списка
        static List<byte> FilterList(List<byte> srcList)
        {
            for (byte step=0; step<srcList.Count; step++)
                if (srcList[step] > 25 && srcList[step] < 50)
                {
                    srcList.RemoveAt(step);
                    step--;
                }

            return srcList;
        }
    }
}
