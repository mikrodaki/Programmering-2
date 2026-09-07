namespace SLASK
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ShowFolders(@"C:\Test");
		}

		static int Factorial(int n)
		{
			if (n == 1)
				return 1;

			return n * Factorial(n - 1);
		}

		static void CountDown(int n)
		{
			if (n < 0)
				return;

			Console.WriteLine(n);

			CountDown(n - 1);
		}

		static int Fibonacci(int n)
		{
			Console.WriteLine($"F({n})");

			if (n <= 1)
				return 1;

			return Fibonacci(n - 1) + Fibonacci(n - 2);
		}

		static double? FactorialDouble(double n)
		{
			if (n < 0 || n > 170)
				return null;

			if (n % 1 != 0)
				return null;

			if (n <= 1)
				return 1;

			return n * FactorialDouble(n - 1);
		}

		static int Pow(int a, int n)
		{
			if (n < 1)
				return 1;

			return a * Pow(a, n - 1);
		}

		static void ShowFolders(string path)
		{
			Console.WriteLine(path);

			foreach (string folder in Directory.GetDirectories(path))
			{
				ShowFolders(folder);
			}
		}
	}
}

// Ändrade lite i slask för att se om GIT fungerar som det ska.
