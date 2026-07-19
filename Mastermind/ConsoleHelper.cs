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
	}
}