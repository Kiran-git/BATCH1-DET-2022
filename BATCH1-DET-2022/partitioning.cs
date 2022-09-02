using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class partitioning
    {
        private static void Main()
        {

            //string[] words = { "kannada", "english", "hindi", "telugu", "tamil", "spanish" };

            //var result = words.Skip(4);

            //Debug.WriteLine("Skips the first 4 words:");
            //foreach (string word in result)
            //    Debug.WriteLine(word);



            //string[] words = { "kannada", "english", "hindi", "telugu", "tamil", "spanish" };

            //var result = words.SkipWhile(w => w.Length == 7);

            //Debug.WriteLine("Skips words while the condition is met:");
            //foreach (string word in result)
            //    Debug.WriteLine(word);


            //int[] numbers = { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };

            //var result = numbers.Take(5);

            //Debug.WriteLine("Takes the first 5 numbers only:");
            //foreach (int number in result)
            //    Debug.WriteLine(number);


            int[] numbers = { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };

            var result = numbers.TakeWhile(n => n < 55);

            Debug.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in result)
                Debug.WriteLine(number);




            foreach (var num in result)
            {
                Console.WriteLine("{0}", num);
            }
            Console.ReadLine();


        }
    }
}
