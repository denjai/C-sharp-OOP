using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle:Shape
    {
        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }

        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public override double CalculateSurface()
        {
            return this.height * this.width;
        }
    }
}
