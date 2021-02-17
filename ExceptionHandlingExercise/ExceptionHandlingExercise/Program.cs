using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create a string variable with an empty string initializer - name it str
            // using a foeach loop, attempt to parse the elements in your char[] with int.Parse()            
            // and Exceptions will be thrown 
            // Below we will set this 

            //------------------------------------------------------------------------------
            //char[] arr1 = new char[] { '3','4','7','3','6','3','4','a','m','e','y' };
            //List<int> numbers = new List<int>();
            //string str = "";

            //foreach (var item in arr1)
            //{
            //    int.Parse(item);
            //}
            //-------------------------------------------------------------------------------

            // ------------------------------------------------------------------------------
            // Now create a try catch
            // Inside your try block set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list in your () of your catch, 
            // Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection


            // foreach (var num in numbers)
            // {
            //     Console.WriteLine(num);
            // }


            //TODO START HERE:
            char[] arr = new char[9] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            List<int> list = new List<int>();
            string str = "";

            // Make a foreach loop to iterate through your character array
            foreach (var num in arr)
            {
                try
                {
                    str = num.ToString();
                    int x = int.Parse(str);
                    list.Add(x);
                }
                catch (Exception )
                {
                    Console.WriteLine($"Unable to Parse '{num}'");
                }
            }

            foreach(var num in list)
            {
                Console.WriteLine(num);
            }

        }




        static void LoggerError(Exception error)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Environment.NewLine}-------------------------{Environment.NewLine}");
            sb.Append($"{error.Message} {DateTime.Now}");
            sb.Append($"{Environment.NewLine}-------------------------{Environment.NewLine}");
            var filePath = "";

            File.AppendAllText(filePath + "log.txt", sb.ToString());
        }
    }
}
