using App.IO;

namespace MasterMind
{
	class Program
	{
		private static List<int> targetColors = new List<int>();
		private static bool gameWon = false;

		static void Main(string[] args)
		{
			Console.SetWindowSize(120, 40);
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.Clear();

			Board board = new Board();
			board.Draw();
			foreach (var item in board.GenerateTargetColors())
			{
				targetColors.Add(item);
			}
			Console.SetCursorPosition(0, 0);
			Console.Write("Key: ");
			foreach (int i in targetColors)
			{
				Console.Write(i);
			}
			while (!board.IsLastRow() && !gameWon)
			{
				List<int> userGuess = board.GetUserInput();
				Console.SetCursorPosition(0, 1);
				string userGuessString = string.Empty;
				foreach (var item in userGuess) 
				{
					userGuessString += item;
				}
				Console.Write("Gss: " + userGuessString);
				if (board.IsCorrect(userGuess, targetColors))
					gameWon = true;
				board.DisplayQuess(userGuess);
				board.DisplayHintsImproved(userGuess, targetColors);
			}
			Console.SetCursorPosition(Constants.INPUT_X_SCREEN_POS, Constants.INPUT_Y_SCREEN_POS);
			Console.Write(new string(' ', 60));
			Console.SetCursorPosition(Constants.INPUT_X_SCREEN_POS, Constants.INPUT_Y_SCREEN_POS);
			if (gameWon)
				Console.WriteLine("Du klarade spelet!");
			else 
			{ 
				Console.WriteLine("Du förlorade.");
				board.DrawKey(targetColors);
			}
			Console.ReadKey();
		}
	}
}
