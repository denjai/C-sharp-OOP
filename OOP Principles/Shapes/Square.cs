namespace Shapes
{
    public class Square : Shape
    {
        public Square(int h)
        {
            this.Height = h;
            this.Width = h;
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
            return this.Height * this.Width;
        }
    }

}
