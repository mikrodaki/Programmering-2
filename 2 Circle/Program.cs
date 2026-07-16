namespace _2_Circle
{
	internal class Program
	{
		static Random random = new Random();
		static List<Circle> circles = new List<Circle>();
		static void Main(string[] args)
		{
			//Circle circle = new Circle(3);
			//Console.WriteLine(circle.Area());
			//Cylinder cylinder = new Cylinder(3, 7);
			//Console.WriteLine(cylinder.Volume());
			circles.Add(new Cylinder(6, 4));
			for (int i = 0; i < 2; i++)
			{
				// Om du vill slumpa ett tal mellan till exempel 1,0 och 5,0 gör du så här:
				double value = 1.0 + random.NextDouble() * 4.0;
				circles.Add(new Circle(value));
			}
			circles.Add(new Cylinder(3, 4));
			foreach (Circle c in circles)
			{
				if (c is Cylinder)
				{
					Cylinder cylinder = (Cylinder)c;
					Console.WriteLine("Cylinderns volym är: " + cylinder.Volume().ToString("F2") + ", cylinderns area är " + cylinder.Area().ToString("F2"));
				}
				else
					Console.WriteLine("Cirkelns area är: " + c.Area().ToString("F2"));
				//Console.WriteLine($"Cirkeln med radien {c.Radius.ToString("F2")} har arean: {c.Area().ToString("F2")}");
			}
			Console.WriteLine("Antal objekt i listan: " + circles.Count);
		}
	}
}
