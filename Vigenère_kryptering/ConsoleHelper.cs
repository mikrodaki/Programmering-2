namespace App.IO
{
	internal class ConsoleHelper
	{
		public static int ReadInt(string prompt, bool mustBeGreaterThanZero)
		{
			while (true)
			{
				Console.Write(prompt);
				string? input = Console.ReadLine();

				if (!int.TryParse(input, out int value))
				{
					Console.WriteLine("Fel: ange ett heltal.");
					continue;
				}

				if (mustBeGreaterThanZero && value < 1)
				{
					Console.WriteLine("Fel: värdet måste vara större än 0.");
					continue;
				}

				return value;
			}
		}

		public static int ReadInt(string text, int min, int max)
		{
			while (true)
			{
				Console.Write(text);
				string? input = Console.ReadLine();

				if (!int.TryParse(input, out int value))
				{
					Console.WriteLine("Fel: ange ett heltal.");
					continue;
				}

				if (value < min || value > max)
				{
					Console.WriteLine($"Fel: värdet måste vara inom intervallet {min} och {max}");
					continue;
				}

				return value;
			}
		}

		public static string ReadString(string text)
		{
			while (true)
			{
				Console.Write(text);
				string? input = Console.ReadLine();

				if (!string.IsNullOrEmpty(input))
				{
					bool ok = true;

					for (int i = 0; i < input.Length; i++)
					{
						char c = input[i];
						if (!char.IsLetter(c) && c != ' ')
						{
							ok = false;
							break;
						}
					}

					if (ok)
						return input;
				}

				Console.WriteLine("Du måste ange en sträng med bara bokstäver och mellanslag");
			}
		}

		public static string ReadStringOnlyLowerCase(string text)
		{
			while (true)
			{
				Console.Write(text);
				string? input = Console.ReadLine();

				if (!string.IsNullOrEmpty(input))
				{
					bool ok = true;

					for (int i = 0; i < input.Length; i++)
					{
						char c = input[i];
						if (!ExistsInAlphabet(c))
						{
							ok = false;
							break;
						}
					}
					if (ok)
						return input;
				}
				Console.WriteLine("Du måste ange en sträng med bara små bokstäver");
			}
		}

		public static bool ExistsInAlphabet(char c)
		{
			string alphabet = "abcdefghijklmnopqrstuvxyzåäö";
			for (int i = 0; i < alphabet.Length; i++)
			{
				if (c == alphabet[i])
					return true;
			}
			return false;
		}

		public static string ReadIntString(string text, int x, int y)
		{
			string emptyString = string.Empty;
			while (true)
			{
				Console.SetCursorPosition(x, y);
				Console.Write(new string(' ', 50));
				Console.SetCursorPosition(x, y);
				Console.Write(text);
				string? input = Console.ReadLine();

				if (!string.IsNullOrEmpty(input))
				{
					bool ok = true;

					for (int i = 0; i < input.Length; i++)
					{
						char c = input[i];
						if (!char.IsDigit(c))
						{
							ok = false;
							break;
						}
						else if (c < '1' || c > '6')
						{
							ok = false;
							break;
						}
					}
					if (input.Length == 4 && IsUnique(input))
						return input;
				}

				Console.SetCursorPosition(x, y + 1);
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("Felaktig inmatning");
				Console.ReadKey();
				Console.SetCursorPosition(x, y + 1);
				Console.Write(new string(' ', 60));
				Console.ForegroundColor = ConsoleColor.White;
			}
		}

		public static bool IsUnique(string text)
		{
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				for (int j = i; j < text.Length - 1; j++)
				{
					char d = text[j + 1];
					if (c == d)
						return false;
				}
			}
			return true;
		}

		public static void ClearScreen(string heading)
		{
			Console.Clear();
			Console.WriteLine(heading + "\n----------------------------------------------\n");
		}

		public static void PrintOptions()
		{
			Console.WriteLine("Gör ett val");
			string[] options = new string[] { "Ändra ett namn", "Lista alla namn", "Avsluta" };
			for (int i = 0; i < options.Length; i++)
			{
				Console.WriteLine($"{i + 1}. {options[i]}");
			}
		}

		public static string ReadStringNotEmpty(string text)
		{
			while (true)
			{
				Console.Write(text);
				string userInput = Console.ReadLine();
				if (!string.IsNullOrEmpty(userInput))
					return userInput;
				else
					Console.WriteLine("Du måste ange minst ett tecken!");
			}
		}
	}
}