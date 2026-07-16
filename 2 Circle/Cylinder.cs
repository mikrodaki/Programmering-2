namespace _2_Circle
{
	internal class Cylinder : Circle
	{
		double height;
		public Cylinder(double radius, double height) : base(radius)
		{
			this.height = height;
		}

		public double Volume() 
		{ 
			return this.Area() * height;
		}

		public override double Area()
		{
			return 2 * base.Area() + 2 * Math.PI * Radius * height;
		}
	}
}
