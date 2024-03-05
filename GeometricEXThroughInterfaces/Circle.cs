namespace GeometricEXThroughInterfaces
{
    public class Circle:AreaGV
    {
        protected double radio;

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public Circle(double radio)
        {
            Radio = radio;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radio,2);
        }
    }
}
