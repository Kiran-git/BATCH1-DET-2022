﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal abstract class Student
    {
        public int regno { get; set; }
        public string Name { get; set; }



        public abstract double GetAvgMarks();
    }
}
