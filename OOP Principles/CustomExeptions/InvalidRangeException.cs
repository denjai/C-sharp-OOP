using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExeptions
{
    class InvalidRangeException<T> :ApplicationException
    {

        public InvalidRangeException(string msg, int start, int end):base(msg)
        {
            this.Start = start;
            this.End=end;
        }
        public int Start { get; private set; }
        public int End { get; private set; }

    }
}
