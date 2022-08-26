using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
  internal  class Circal
    {
        int r;
        public Circal(int r)
        {
            this.r = r;
        }
        public double GetArea()
        {
            return Math.PI * r * r;
        }
   }
}
