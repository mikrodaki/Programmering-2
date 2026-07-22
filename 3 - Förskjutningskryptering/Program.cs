using App.IO;

namespace Encryption
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string plaintext = string.Empty;
			string key = string.Empty;
			string userInput = string.Empty;

			ConsoleHelper.ClearScreen("FÖRSKJUTNINGSKRYPTERING");

			plaintext = ConsoleHelper.ReadStringNotEmpty("Ange texten som ska krypteras: ");
			key = ConsoleHelper.ReadStringNotEmpty("Ange krypteringsnyckeln: ");
			Console.WriteLine();

			Console.WriteLine($"plaintext: {plaintext}");
			Console.WriteLine($"key: {key}");
			string encryptedText = (Encrypt(plaintext, key));
			Console.WriteLine($"krypterad text: {encryptedText}");
			string decryptedText = (Decrypt(encryptedText, key));
			Console.WriteLine($"avkrypterad text: {decryptedText}");
		}

		private static string Encrypt(string plaintext, string key)
		{
			int currentIndex = 0;
			string temp = string.Empty;
			for (int i = 0; i < plaintext.Length; i++)
			{
				char c = (char)(plaintext[i] + (key[currentIndex] - '0'));
				temp += c;
				currentIndex++;
				if (currentIndex == key.Length)
					currentIndex = 0;
			}
			return temp;
		}

		private static string Decrypt(string plaintext, string key)
		{
			int currentIndex = 0;
			string temp = string.Empty;
			for (int i = 0; i < plaintext.Length; i++)
			{
				char c = (char)(plaintext[i] - (key[currentIndex] - '0'));
				temp += c;
				currentIndex++;
				if (currentIndex == key.Length)
					currentIndex = 0;
			}
			return temp;
		}
	}


}
