using App.IO;

namespace Vigenère_kryptering
{
	internal class Program
	{
		static string alphabet = "abcdefghijklmnopqrstuvwxyzåäö";
		static string plaintext = string.Empty;
		static string key = string.Empty;
		static string encryptedText = string.Empty;
		static string decryptedText = string.Empty;
		static void Main(string[] args)
		{
			ConsoleHelper.ClearScreen("VIGENÈRE-KRYPTERING");
			plaintext = ConsoleHelper.ReadStringOnlyLowerCase("Ange en sträng med bara bokstäver små bokstäver: ");
			key = ConsoleHelper.ReadStringOnlyLowerCase("Ange en krypteringsnyckel med bara små bokstäver: ");
			Console.WriteLine();
			encryptedText = Encrypt(plaintext, key);
			Console.WriteLine($"Text:             {plaintext}");
			Console.WriteLine($"Nyckel:           {key}");
			Console.WriteLine($"Krypterad text:   {encryptedText}");
			decryptedText = Decrypt(encryptedText, key);
			Console.WriteLine($"Avkrypterad text: {decryptedText}");
			Console.CursorVisible = false;
			Console.ReadKey();
		}

		private static string Encrypt(string plaintext, string key)
		{
			int currentIndex = 0;
			string encryptedText = string.Empty;
			for (int i = 0; i < plaintext.Length; i++)
			{
				int plainIndex = GetIndex(plaintext[i]);
				int keyIndex = GetIndex(key[currentIndex]);
				encryptedText += GetEncryptedChar(plainIndex, keyIndex);
				currentIndex = (currentIndex + 1) % key.Length;
			}
			return encryptedText;
		}

		private static string Decrypt(string encryptedText, string key)
		{
			int currentIndex = 0;
			string plainText = string.Empty;
			for (int i = 0; i < encryptedText.Length; i++)
			{
				int encryptedIndex = GetIndex(encryptedText[i]);
				int keyIndex = GetIndex(key[currentIndex]);
				plainText += GetDecryptedChar(encryptedIndex, keyIndex);
				currentIndex = (currentIndex + 1) % key.Length;
			}
			return plainText;
		}

		private static char GetDecryptedChar(int plainIndex, int keyIndex)
		{
			int newIndex = plainIndex - keyIndex;

			//if (newIndex < 0)
			//{
			//	newIndex = Math.Abs(newIndex);
			//	newIndex = alphabet.Length - newIndex;
			//}

			// Samma som ovan
			newIndex = (plainIndex - keyIndex + alphabet.Length) % alphabet.Length;

			return alphabet[newIndex];
		}

		private static char GetEncryptedChar(int plainIndex, int keyIndex)
		{
			int newIndex = plainIndex + keyIndex;

			//if (newIndex > alphabet.Length - 1)
			//{
			//	newIndex = newIndex % alphabet.Length;
			//}

			// Samma som ovan
			newIndex %= alphabet.Length;

			return alphabet[newIndex];
		}

		private static int GetIndex(char c)
		{
			for (int i = 0; i < alphabet.Length; i++)
			{
				if (c == alphabet[i])
					return i;
			}
			return -1;
		}

		// Obsolete methods
		//private static char GetEncryptedChar(char plainChar, char keyChar)
		//{
		//	int firstIndex = 0;
		//	int secondIndex = 0;

		//	for (firstIndex = 0; firstIndex < alphabet.Length; firstIndex++)
		//	{
		//		if (alphabet[firstIndex] == plainChar)
		//			break;
		//	}

		//	for (secondIndex = 0; secondIndex < alphabet.Length; secondIndex++)
		//	{
		//		if (alphabet[secondIndex] == keyChar)
		//			break;
		//	}

		//	int newIndex = firstIndex + secondIndex;

		//	if (newIndex > alphabet.Length - 1)
		//	{
		//		newIndex = newIndex % alphabet.Length;
		//	}

		//	return alphabet[newIndex];
		//}

		//private static char GetDecryptedChar(char encryptedChar, char keyChar)
		//{
		//	int firstIndex = 0;
		//	int secondIndex = 0;

		//	for (firstIndex = 0; firstIndex < alphabet.Length; firstIndex++)
		//	{
		//		if (alphabet[firstIndex] == encryptedChar)
		//			break;
		//	}

		//	for (secondIndex = 0; secondIndex < alphabet.Length; secondIndex++)
		//	{
		//		if (alphabet[secondIndex] == keyChar)
		//			break;
		//	}

		//	int newIndex = firstIndex - secondIndex;

		//	if (newIndex < 0)
		//	{
		//		newIndex = Math.Abs(newIndex);
		//		newIndex = alphabet.Length - newIndex;
		//	}

		//	return alphabet[newIndex];
		//}


	}
}
