namespace GeometricEXThroughInterfaces
{
    public class Triangle:AreaGV
    {
		private int height;

		public int Height
		{
			get { return height; }
			set { height = value; }
		}

		private int width;

		public int Width
		{
			get { return width; }
			set { width = value; }
		}

		public Triangle(int height, int width)
		{
			Width = width;
			Height = height;
		}

		public override double GetArea()
		{
			return (Height * Width) / 2;
		}
	}
}
