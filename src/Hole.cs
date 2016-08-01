using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OS_MemoryBF_FF
{
    class Hole
    {
        public int value;
        public int startIndex;
        public int endIndex;

        public Hole()
        {
            value = 0;
            startIndex = 0;
            endIndex = 0;
        }

        public void getstart() //to calculate the start index of a hole after knowing its end and its size(value)
        {
            startIndex = endIndex - (value - 1);
        }
    }
}
