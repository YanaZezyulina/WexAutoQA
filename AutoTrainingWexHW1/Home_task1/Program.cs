using System;

namespace Home_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            byte byteMaxValue = byte.MaxValue;
            byte byteMinValue = byte.MinValue;
            short shortMaxValue = short.MaxValue;
            short shortMinValue = short.MinValue;
            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;
            long longMaxValue = long.MaxValue;
            long longMinValue = long.MinValue;
            float floatMaxValue = float.MaxValue;
            float floatMinValue = float.MinValue;
            double doulbeMaxValue = double.MaxValue;
            double doubleMinValue = double.MinValue;
            uint uintMaxValue = uint.MaxValue;
            uint uintMinValue = uint.MinValue;
            ulong ulongMaxValue = ulong.MaxValue;
            ulong ulongMinValue = ulong.MinValue;

            Console.WriteLine("       Max Values                  Min Values\n" + "byte   " + byteMaxValue + "                         " + byteMinValue
               + "\n" + "short  " + shortMaxValue + "                       " + shortMinValue
               + "\n" + "int    " + intMaxValue + "                  " + intMinValue
               + "\n" + "long   " + longMaxValue + "         " + longMinValue
               + "\n" + "float  " + floatMaxValue + "               " + floatMinValue
               + "\n" + "double " + doulbeMaxValue + "     " + doubleMinValue
               + "\n" + "uint   " + uintMaxValue + "                  " + uintMinValue
               + "\n" + "ulong  " + ulongMaxValue + "        " + ulongMinValue);
        }
    }
}
