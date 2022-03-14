using System;

namespace Home_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //task2 Создать массив размером 10 элементов,
            //заполнить его квадратами индексов(в цикле), и вывести его содержимое на экран
            int[] array = { 1, -5, 17, 9, 6, 85, 1528, 6224, 2, 0 };
            int index = 0;
            for (index = 0; index < array.Length; index++)
            {

                int index2 = index * index;
                array[index] = array[index] * array[index];
                Console.WriteLine(/*array[index]*/ index2);
                //array[index] - какой - то по счету элемент в массиве
            }
        }
    }
}
