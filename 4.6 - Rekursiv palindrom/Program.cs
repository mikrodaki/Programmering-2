namespace _4._6___Rekursiv_palindrom
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(IsPalindrome("aabbccbbaa"));
		}

		static bool IsPalindrome(string str) 
		{
			if (string.IsNullOrEmpty(str) || str.Length == 1)
			{
				return true;
			}


			if (str[0] == str[str.Length - 1])
			{
				return IsPalindrome(str.Substring(1, str.Length - 2));
			}
			
			return false;
		}
	}
}
