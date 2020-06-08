using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a stream reader to read the file at the adress C:\Temp\image.txt
            //2. Read the file to the end as string then close stream reader
            //3. Split (by space) the solid string into array of srings
            //4. Create a byte array, launch cycle "for" to convert string array elements into byte array elements
            //5. Create a new file (C:\Temp\image.png), write the byte array to the file

            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            textReader.Dispose();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
        }
    }
}
