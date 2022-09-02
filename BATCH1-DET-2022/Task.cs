using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    public class Task
    {
        public static void Main()
        {
            String_Groupby();

        }
       public static void String_Groupby()

        //{
        //    Containing();
        //}
        //public static void Containing()
        //{
        //    string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };
        //    var result = names.Where(word => word.Contains("o"));
        //    foreach (var word in result)
        //    {
        //        Console.WriteLine(word);
        //    }
        //}

        {
            List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "abacus", "banana", "apple", "cheese"};
            var wordGroups = words.GroupBy(x => x[0]).Select
                (y => new { FirstLetter = y.Key, words = y});
            foreach (var item in wordGroups)
            {
                Console.WriteLine("words that start with the" + 
                    " letter '{0}' : ",
                    item.FirstLetter);
                foreach (var w in item.words)
                {
                    Console.WriteLine(w);
                }
            }
        }



    }
}

       
 