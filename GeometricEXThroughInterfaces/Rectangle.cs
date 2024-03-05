namespace GeometricEXThroughInterfaces
{
    public class Rectangle:AreaGV
    {
		protected double width;

		public double Width
		{
			get { return width; }
			set { width = value; }
		}

		protected double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

        public Rectangle(double @width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
