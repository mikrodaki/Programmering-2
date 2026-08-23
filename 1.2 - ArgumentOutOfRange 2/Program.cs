using App.IO;

namespace _1._2___ArgumentOutOfRange_2
{
	internal class Program
	{
		static int volume = 0;
		static void Main(string[] args)
		{
			while (true)
			{
				ConsoleHelper.ClearScreen("Set volume");
				Console.WriteLine($"Volymen just nu är {volume}");
				int newVolume = ConsoleHelper.ReadInt("Ange den nya volymen: ", false);
				try
				{
					SetVolume(newVolume);
					Console.WriteLine($"Den nya volymen är: {volume}");
				}
				catch (ArgumentOutOfRangeException e)
				{
					Console.WriteLine(e.Message);
					Console.ReadKey();
				}

				Console.WriteLine("Tryck ESC för att avsluta eller valfri tangent för att fortsätta.");

				if (Console.ReadKey(true).Key == ConsoleKey.Escape)
					break;
			}
		}

		static void SetVolume(int value)
		{
			if (value < 0 || value > 100)
				throw new ArgumentOutOfRangeException(null, "Volymen måste vara mellan 0 och 100");
			volume = value;
		}
	}
}
