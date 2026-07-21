namespace SLASK
{
	internal class Program
	{
		static void Main(string[] args)
		{
			StaticClass myClass1 = new StaticClass();
			StaticClass myClass2 = new StaticClass();
			StaticClass.Increase();
			myClass1.Print();
			StaticClass.Increase();
			myClass2.Print();
			Console.ReadKey();
		}
	}

	class StaticClass
	{
		static int x;

		public static void Increase() 
		{ 
			x++;
		}

		public void Print() 
		{
			Console.WriteLine(x);
		}
	}
}
