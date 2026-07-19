using App.IO;

namespace MasterMind
{
	class Program
	{
		private static List<int> key = new List<int>();
		static void Main(string[] args)
		{
			Console.SetWindowSize(120, 40);
			Console.BackgroundColor = ConsoleColor.DarkGreen;
			Console.Clear();

			Board board = new Board();
			board.Draw();
			foreach (var item in board.GenerateTargetColors())
			{
				key.Add(item);
			}
			GetUserInput();
			Console.ReadKey();
		}

		private static void GetUserInput()
		{
			WriteAt(37, 32, "Ange fyra färger: ");
		}

		/*
         * WriteAt
         * 
         * Help method that writes a text 
         * at a specific coordinate
         * 
         */
		static void WriteAt(int x, int y, string text)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(text);
		}

		static ConsoleColor ReturnColorFromInt(int color)
		{
			switch (color)
			{
				case Constants.Yellow:
					return ConsoleColor.Yellow;
				case Constants.Green:
					return ConsoleColor.Green;
				case Constants.Red:
					return ConsoleColor.Red;
				case Constants.Blue:
					return ConsoleColor.Blue;
				case Constants.Magenta: 
					return ConsoleColor.Magenta;
				case Constants.Cyan:
					return ConsoleColor.Cyan;
				default:
					return ConsoleColor.White;
			}
		}
	}
}
