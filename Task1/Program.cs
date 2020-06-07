using System;

namespace Task1
{
    class Program
    { 
        static void Main(string[] args)
        {
            sbyte numSbyte = -5;
            short numShort = numSbyte;
            int numInt = numShort;
            long numLong = numInt;
            Console.WriteLine($" implicit conversion result: \n sbyte {numSbyte} to short {numShort} to int {numInt} to long {numLong}");

            ulong numUlong = (ulong) numLong;
            numSbyte = (sbyte) numUlong;
            float numFloat = 10f/3;
            numInt = (int) numFloat;
            object objectInt = numInt;
            numInt = (int) objectInt;
            Console.WriteLine($" explicit conversion result: \n long {numLong} to ulong {numUlong} to sbyte {numSbyte} \n float {numFloat} to int {numInt}");
            Console.WriteLine($" boxing result: int {numInt} to object {objectInt} \n unboxing result: object {objectInt} to int {numInt}");
            Console.ReadLine();
        }
    }
}
