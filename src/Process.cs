using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OS_MemoryBF_FF
{
    class Process
    {
        public int ID;
        public int length;
        public int startIndex;
        public int endIndex;
        public bool ischecked;
        
        public Process()
        {
            ID = 0;
            ischecked = false;
            length = 0;
            startIndex = 0;
            endIndex = 0;
        }
    }
}
