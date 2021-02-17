using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace Exception_Handling_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrintNumbers();
            }            
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                throw;
            }
            
            
        }


        public static void PrintNumbers()
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arr[i+1] = i;
            }

            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
