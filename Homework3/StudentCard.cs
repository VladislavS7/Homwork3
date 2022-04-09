using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public class StudentCard
    {
        public int Count { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
