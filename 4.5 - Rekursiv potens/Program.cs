namespace _4._5___Rekursiv_potens
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
		}

		static int Pow(int a, int n)
		{
			if (n < 1)
				return 1;

			return a * Pow(a, n - 1);
		}
	}
}
