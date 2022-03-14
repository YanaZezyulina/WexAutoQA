using System;
using System.Linq;

namespace Home_task3
{
    
    class Program
    {
        static void InitArray(int[] array, int coeff)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Math.Pow(i, coeff));
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("\n");
        }
        //Задание- создать три массива по 10 элементов,
        //первый заполнить значениями индексов элементов,
        //второй - квадратами индексов, третий-кубами,
        //и вывести на экран средние значения элементов для всех массивов
        static void Main(string[] args)
        {
           int[] arr1 = new int[10];
            InitArray(arr1, 1);
            // Console.WriteLine("1st array " + arr1); - пучему если расположить вывод здесь,
            // не выводит ожидаемый результат?
            int[] arr2 = new int[10];
            InitArray(arr2, 2);

            int[] arr3 = new int[10];
            InitArray(arr3, 3);
        }
    }
}
