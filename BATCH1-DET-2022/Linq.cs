using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class Linq
    {
        private static void Main()

        {
                var dates = new DateTime[] {
                new DateTime(2015, 3, 1),
                new DateTime(2014, 7, 1),
                new DateTime(2013, 5, 1),
                new DateTime(2015, 1, 1),
                new DateTime(2015, 7, 1)
    };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Debug.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Debug.WriteLine(dt.ToString("yyyy/MM/dd"));



            //string[] capitals = { "Bellary", "hospet", "davangere", "goa", "London" };

            //var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            //Debug.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            //foreach (string capital in result)
            //    Debug.WriteLine(capital);


            //char[] characters = { 'k', 'i', 'r', 'a', 'n' };

            //var result = characters.Reverse(); 

            //Debug.WriteLine("Characters in reverse order:");
            //foreach (char character in result)
            //    Debug.WriteLine(character);


            //string[] names = { "my", "name", "is" };

            //var result = names.OrderByDescending(n => n);

            //Debug.WriteLine("Descending ordered list of names:");
            //foreach (string name in result)
            //    Debug.WriteLine(name);

            //int[] numbers = { 7, 9, 5 };

            //var result = numbers.OrderBy(n => n);

            //Debug.WriteLine("Ordered list of numbers:");
            //foreach (int number in result)
            //    Debug.WriteLine(number);

            // // the three parts of a linqu query: differed execution
            // //1. date source
            // List <int> numbers = new List<int>();
            // numbers.Add(110);
            // numbers.Add(100);
            // numbers.Add(105);
            // numbers.Add(102);

            //  var numQuery = numbers.Select(x => x);

            // // var numQuery = from num in numbers select num;
            //// var numQuery = from num in numbers 
            //         //    where num > 102
            //        //    select num;

            //// var numQuery = numbers.Where(x => x > 102);


            foreach (var num in result)
            {
                Console.WriteLine("{0}", num);
            }
            Console.ReadLine();

        }
    }
}
