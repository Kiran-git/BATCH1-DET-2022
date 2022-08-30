using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class Ageprogram
    {
        public static void Main()
        {
            int Age;
            try
            {
                Console.WriteLine("enter the age b.w 1-100");
                Age = int.Parse(Console.ReadLine());
                if (Age > 100)
                    throw new InvalidAgeException("entered age is Invalid");
            }
            catch (InvalidAgeException a)
            {
                Console.WriteLine(a.Message);
            }
            catch (Exception a)
            {  }

        }


    }
}
