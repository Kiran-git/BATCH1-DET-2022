using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class Aggregate
    {
        private static void Main() 
        {
            // SampleForAggregate();
             Average();
            // Count();
            // Max();
            // Min();
             //  Sum();


        }
        //public static void SampleForAggregate()
        //{
        //    var numbers = new int[] { 1, 2, 3, 4, 5 };

        //    var result = numbers.Aggregate((a, b) => a * b);

        //    Console.WriteLine("Aggregated numbers by multiplication:");
        //    Console.WriteLine(result);
        //}

        public static void Average()
        {
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);
        }

        //public static void Count()
        //{
        //    string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

        //    var result = names.Count();

        //    Console.WriteLine("Counting names gives:");
        //    Console.WriteLine(result);
        //}

        //public static void Max()
        //{
        //    int[] numbers = { 2, 8, 5, 6, 1 };

        //    var result = numbers.Max();

        //    Console.WriteLine("Highest number is:");
        //    Console.WriteLine(result);
        //}

        //
        //{
        //    int[] numbers = { 6, 9, 3, 7, 5 };

        //    var result = numbers.Min();

        //    Console.WriteLine("Lowest number is:");
        //    Console.WriteLine(result);
        //}

        //public static void Sum()
        //{
        //    int[] numbers = { 2, 5, 10 };

        //    var result = numbers.Sum();

        //    Console.WriteLine("Summing the numbers yields:");
        //    Console.WriteLine(result);
        //}

    }
}
 