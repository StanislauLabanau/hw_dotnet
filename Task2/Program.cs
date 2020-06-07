using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numSbyteCSh = 1;
            SByte numSbyteMSIL = 2;
            short numShortCSh = 1;
            Int16 numShortMSIL = 2;
            int numIntCSh = 1;
            Int32 numIntMSIL = 2;
            long numLongCSh = 1;
            Int64 numLongMSIL = 2;
            byte numByteCSh = 1;
            Byte numByteMSIL = 2;
            ushort numUshortCSh = 1;
            UInt16 numUshortMSIL = 2;
            uint numUintCSh = 1;
            UInt32 numUintMSIL = 2;
            ulong numUlongCSh = 1;
            UInt64 numUlongMSIL = 2;
            float numFloatCSh = 1;
            Single numFloatMSIL = 2;
            double numDoubleCSh = 1;
            Double numDoubleMSIL = 2;
            decimal numDecimalCSh = 1;
            Decimal numDecimalMSIL = 2;
            char numCharCSh = '1';
            Char numCharMSIL = '2';
            string strStringCSh = "111";
            String strStringMSIL = "222";
            object objObjectCSh = new object();
            Object objObjectMSIL = new object();

            Console.WriteLine($" numSbyteCSh type is {numSbyteCSh.GetType()}, numSbyteMSIL type is {numSbyteMSIL.GetType()} \n numShortCSh type is {numShortCSh.GetType()}, numShort2 type is {numShortMSIL.GetType()} \n" +
                $" numIntCSh type is {numIntCSh.GetType()}, numIntMSIL type is {numIntMSIL.GetType()} \n numLongCSh type is {numLongCSh.GetType()}, numLongMSIL type is {numLongMSIL.GetType()} \n" +
                $" numByteCSh type is {numByteCSh.GetType()}, numByteMSIL type is {numByteMSIL.GetType()} \n numUshortCSh type is {numUshortCSh.GetType()}, numUshortMSIL type is {numUshortMSIL.GetType()} \n" +
                $" numUintCSh type is {numUintCSh.GetType()}, numUintMSIL type is {numUintMSIL.GetType()} \n numUlongCSh type is {numUlongCSh.GetType()}, numUlongMSIL type is {numUlongMSIL.GetType()} \n" +
                $" numFloatCSh type is {numFloatCSh.GetType()}, numFloatMSIL type is {numFloatMSIL.GetType()} \n numDoubleCSh type is {numDoubleCSh.GetType()}, numDoubleMSIL type is {numDoubleMSIL.GetType()} \n" +
                $" numDecimalCSh type is {numDecimalCSh.GetType()}, numDecimalMSIL type is {numDecimalMSIL.GetType()} \n numCharCSh type is {numCharCSh.GetType()}, numCharMSIL type is {numCharMSIL.GetType()} \n" +
                $" strStringCSh type is {strStringCSh.GetType()}, strStringMSIL type is {strStringMSIL.GetType()} \n objObjectCSh type is {objObjectCSh.GetType()}, objObjectMSIL type is {objObjectMSIL.GetType()} \n");
            Console.ReadLine();
        }
    }
}
