using System;

namespace Task1
{
    class Program
    { 
        static void Main(string[] args)
        {
            sbyte NumSbyte = -5;
            short NumShort = NumSbyte;
            int NumInt = NumShort;
            long NumLong = NumInt;
            Console.WriteLine($" implicit conversion: \n sbyte {NumSbyte} to short {NumShort} to int {NumInt} to long {NumLong}");

            ulong NumUlong = (ulong) NumLong;
            NumSbyte = (sbyte) NumUlong;
            float NumFloat = 10f/3;
            NumInt = (int) NumFloat;
            object ObjectInt = NumInt;
            NumInt = (int) ObjectInt;
            Console.WriteLine($" explicit conversion: \n long {NumLong} to ulong {NumUlong} to sbyte {NumSbyte} \n float {NumFloat} to int {NumInt}");
            Console.WriteLine($" boxing: int {NumInt} to object {ObjectInt} \n unboxing: object {ObjectInt} to int {NumInt}");
            Console.ReadLine();
        }
    }
}
