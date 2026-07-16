namespace _2_Circle
{
	internal class Circle
	{
		double radius;
		public Circle(double radius)
		{
			this.radius = radius;
		}

		public virtual double Area()
		{
			return Math.PI * (Math.Pow(radius, 2));
		}

		public double Radius { get { return radius; } }
	}
}
