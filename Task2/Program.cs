using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte Sbyte1 = 1;
            SByte Sbyte2 = 2;
            short Short1 = 1;
            Int16 Short2 = 2;
            int Int1 = 1;
            Int32 Int2 = 2;
            long Long1 = 1;
            Int64 Long2 = 2;
            byte Byte1 = 1;
            Byte Byte2 = 2;
            ushort Ushort1 = 1;
            UInt16 Ushort2 = 2;
            uint Uint1 = 1;
            UInt32 Uint2 = 2;
            ulong Ulong1 = 1;
            UInt64 Ulong2 = 2;
            float Float1 = 1;
            Single Float2 = 2;
            double Double1 = 1;
            Double Double2 = 2;
            decimal Decimal1 = 1;
            Decimal Decimal2 = 2;
            char Char1 = '1';
            Char Char2 = '2';
            string String1 = "111";
            String String2 = "222";
            object Object1 = new object();
            Object Object2 = new object();

            Console.WriteLine($" Sbyte1 type is {Sbyte1.GetType()}, Sbyte2 type is {Sbyte2.GetType()} \n Short1 type is {Short1.GetType()}, Short2 type is {Short2.GetType()} \n" +
                $" Int1 type is {Int1.GetType()}, Int2 type is {Int2.GetType()} \n Long1 type is {Long1.GetType()}, Long2 type is {Long2.GetType()} \n" +
                $" Byte1 type is {Byte1.GetType()}, Byte2 type is {Byte2.GetType()} \n Ushort1 type is {Ushort1.GetType()}, Ushort2 type is {Ushort2.GetType()} \n" +
                $" Uint1 type is {Uint1.GetType()}, Uint2 type is {Uint2.GetType()} \n Ulong1 type is {Ulong1.GetType()}, Ulong2 type is {Ulong2.GetType()} \n" +
                $" Float1 type is {Float1.GetType()}, Float2 type is {Float2.GetType()} \n Double1 type is {Double1.GetType()}, Double2 type is {Double2.GetType()} \n" +
                $" Decimal1 type is {Decimal1.GetType()}, Decimal2 type is {Decimal2.GetType()} \n Char1 type is {Char1.GetType()}, Char2 type is {Char2.GetType()} \n" +
                $" String1 type is {String1.GetType()}, String2 type is {String2.GetType()} \n Object1 type is {Object1.GetType()}, Object2 type is {Object2.GetType()} \n");
            Console.ReadLine();
        }
    }
}
