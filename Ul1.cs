using System;

namespace Iseseiv
{
	class Ul1
	{
        // Varinat 7
        // В двухмерном массиве переставьте попарно соседние строки, т.е. 1-ю со 2-ой, 3-ю с 4-й и т.д. Результат выведите на экран.


        /*static void ReplaceArr(int[,] arr)
        {
            for (int i = 1; i < arr.GetLength(0); i += 2)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i - 1, j];
                    arr[i - 1, j] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                { 1, 2, 3 },
                { 2, 3, 4 },
                { 5, 6, 7 },
                { 7, 9, 5 },
                //{ 3, 8, 1 },
                //{ 4, 7, 2 },
                //{ 5, 4, 9 },
                //{ 1, 1, 8 }
            };
            ReplaceArr(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }*/
    }
}