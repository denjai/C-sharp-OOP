using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Display
    {
        private float? size;
        private int? numberOfColors;

        public Display()
        {
            this.size = null;
            this.numberOfColors = null;
        }
        public Display(float size, int numColors)
        {
            this.size = size;
            this.numberOfColors = numColors;
        }
    }
}
