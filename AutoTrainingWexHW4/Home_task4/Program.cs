using System;
using System.Linq;

namespace Home_task4
{
    class Program
    {

        //task4 Создать два произвольных массива, подсчитать максимальное
        //и минимальное значение их элементов. Вывести на экран.
        //Поменять в каждом массиве максимальные и минимальные значения местами

        static int[] fillArrayRand(int lenghtOfArray)

        {
            //int[] array = new int[lenghtOfArray];
            Random RandNum = new Random();
            int[] arr1 = new int[lenghtOfArray];
            for (int i = 0; i < lenghtOfArray; i++)
            {
                arr1[i] = (int)RandNum.Next(lenghtOfArray);//RandNum.Next(Int32.MaxValue);

            }
            return arr1;
        }

        static void FindMaxArrValue(int[] array)
        {
            int maxNumber = array.Max();
            Console.WriteLine("\n" + "Max array Number is " + maxNumber);
        }
        // поиск минимальных значений
        static void FindMinArrValue(int[] array)
        {
            int minNumber = array.Min();
            Console.WriteLine("\n" + "Min array Number is " + minNumber);

        }
        //изменение мин и макс значений в массиве
        static void ChangeMaxMin(int[] array)
        {
            int imax = 0;
            int imin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[imin] > array[i])
                {
                    imin = i;
                }
                if (array[imax] < array[i])
                {
                    imax = i;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            int x = array[imin];
            array[imin] = array[imax];
            array[imax] = x;

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }

        static void Main(string[] args)
        {
            ////с заданием массива с клавиатуры  
            //int arraySize;
            //arraySize = Int32.Parse(Console.ReadLine());
            //int[] arr1 = fillArrayRand(arraySize);

            //с заданием массива в методе
            //fillArrayRand(int[] arr0, 2);
            int[] arr2 = fillArrayRand(10);
            int[] arr3 = fillArrayRand(12);
            ////проверить, что записалось в массивы
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //};
            //Console.WriteLine("\n");
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //};
            Console.WriteLine("arr2 ");
            FindMaxArrValue(arr2);
            FindMinArrValue(arr2);
            ChangeMaxMin(arr2);
            Console.WriteLine("\n" + "arr3 ");
            FindMinArrValue(arr3);
            FindMaxArrValue(arr3);
            ChangeMaxMin(arr3);

        }
    }
}
