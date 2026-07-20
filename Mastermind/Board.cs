using App.IO;
using System.Runtime.InteropServices;

namespace MasterMind
{
	class Board     // Lägg klassen i separat fil
	{
		private int currentRow = 0;
		private static Random random = new Random();
		private int firstX = 49;
		private int firstY = 29;

		/*
		 * Draw
		 * 
		 * Draw the game board
		 * 
		 */
		public void Draw()
		{
			Console.ForegroundColor = ConsoleColor.White;
			DrawPart(37, 3, " ---===  M  A  S  T  E  R  M  I  N  D  ===---");

			Console.ForegroundColor = ConsoleColor.Yellow;
			DrawPart(47, 6, "╔═══╦═══╦═══╦═══╗ ╔═╦═╦═╦═╗");

			for (int i = 0; i < 24; i += 2)
			{
				DrawPart(47, i + 7, "║   ║   ║   ║   ║ ║ ║ ║ ║ ║");

				if (i < 22)
					DrawPart(47, i + 8, "╠═══╬═══╬═══╬═══╣ ╠═╬═╬═╬═╣");
			}

			DrawPart(47, 30, "╚═══╩═══╩═══╩═══╝ ╚═╩═╩═╩═╝");
			Console.SetCursorPosition(39, 32);
			for (int i = 1; i <= Constants.NoOfColors; i++)
			{
				//Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write($" {i} = ");
				Console.BackgroundColor = GetConsoleColor(i);
				Console.Write("  ");
				Console.BackgroundColor = ConsoleColor.DarkGray;
				Console.Write(" ");
			}
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkGray;
		}

		private ConsoleColor GetConsoleColor(int color)
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

		/* 
		 * GenerateTargetColors
		 *
		 * GenerateTargetColors returns a list of 
		 * four random numbers representing the
		 * the four colors.
		 *
		 */
		public List<int> GenerateTargetColors()
		{
			List<int> colors = new List<int>();
			while (colors.Count < 4)
			{
				int color = random.Next(1, 7);

				if (!colors.Contains(color))
				{
					colors.Add(color);
				}
			}
			return colors;
		}

		/* 
		 * GetUserInput
		 *
		 * GetUserInput returns a list of 
		 * four valid numbers representing the
		 * the four colors the the user has enterned.
		 *
		 */
		public List<int> GetUserInput()
		{
			string userInput = string.Empty;
			while (string.IsNullOrEmpty(userInput))
			{
				userInput = ConsoleHelper.ReadIntString("Ange fyra siffror enligt färgerna ovan: ", Constants.INPUT_X_SCREEN_POS, Constants.INPUT_Y_SCREEN_POS);
			}
			List<int> userInputList = new List<int>();
			foreach (char c in userInput)
				userInputList.Add(c - '0');
			return userInputList;
		}

		/*
		 * DisplayGuess
		 *
		 * DisplayGuess draws four colored blocked
		 * in the boxes at the current row based on
		 * the users current guess.
		 *
		 */
		public void DisplayQuess(List<int> guessColors)
		{
			firstX = 48;
			if (currentRow != 0)
				firstY -= 2;

			foreach (int item in guessColors)
			{
				Console.ForegroundColor = GetConsoleColor(item);
				string part = "███";
				DrawPart(firstX, firstY, part);
				firstX += 4;
			}
			Console.ForegroundColor = ConsoleColor.White;
			currentRow += 1;
		}

		/*
		 * DisplayHints
		 *
		 * DisplayHints draws black and/or white colored blocks
		 * in the hint boxes to the right at the current row
		 * based on the users current guess. Nothing will be 
		 * displayed if non of the guessed colors exists in
		 * the correct answer. For a correct color at a 
		 * correct position a black block will be displayed.
		 * For a correct color at an incorrect position a
		 * white block will be displayed. 
		 *
		 */
		public void DisplayHints(List<int> guessColors, List<int> targetColors)
		{
			List<int> hintColorsInt = new List<int>();
			int numberOfWhites = 0;
			List<ConsoleColor> hintColors = new List<ConsoleColor>();

			for (int i = 0; i < guessColors.Count; i++)
			{
				int guessColor = guessColors[i];
				if (guessColor == targetColors[i])
				{
					hintColorsInt.Add(2);
					hintColors.Add(ConsoleColor.Black);
				}
				else
				{
					if (ColorExists(guessColor, targetColors))
					{
						hintColorsInt.Add(1);
						numberOfWhites++;
						hintColors.Add(ConsoleColor.White);
					}
					else
					{
						hintColorsInt.Add(0);
						hintColors.Add(ConsoleColor.DarkGray);
					}
				}
			}

			for (int j = 0; j < hintColors.Count; j++)
			{
				if (hintColors[j] == ConsoleColor.White)
				{
					hintColors[j] = ConsoleColor.DarkGray;
				}
			}

			for (int j = 0; j < hintColors.Count; j++)
			{
				if (numberOfWhites == 0)
					break;
				if (hintColors[j] == ConsoleColor.Black)
				{
					continue;
				}
				else if (hintColors[j] == ConsoleColor.DarkGray)
					hintColors[j] = ConsoleColor.White;
				numberOfWhites--;
			}

			Console.SetCursorPosition(0, 3);
			foreach (int i in hintColorsInt)
			{
				Console.Write(i);
			}

			firstX = 66;

			foreach (ConsoleColor item in hintColors)
			{
				Console.ForegroundColor = item;
				string part = "█";
				DrawPart(firstX, firstY, part);
				firstX += 2;
			}
			Console.ForegroundColor = ConsoleColor.White;
		}

		public void DisplayHintsImproved(List<int> guessColors, List<int> targetColors)
		{
			List<ConsoleColor> hintColors = new List<ConsoleColor>();
			int noOfBlack = 0;
			int noOfWhite = 0;

			for (int i = 0; i < guessColors.Count; i++)
			{
				int color = guessColors[i];
				int targetColor = targetColors[i];
				if (color == targetColor)
				{
					noOfBlack++;
					continue;
				}
				if (ColorExists(color, targetColors))
					noOfWhite++;
			}

			for (int i = 0; i < noOfBlack; i++)
			{
				hintColors.Add(ConsoleColor.Black);
			}

			for (int i = 0; i < noOfWhite; i++)
			{
				hintColors.Add(ConsoleColor.White);
			}

			firstX = 66;
			//if (currentRow != 0)
			//	firstYHints -= 2;

			foreach (ConsoleColor item in hintColors)
			{
				Console.ForegroundColor = item;
				string part = "█";
				DrawPart(firstX, firstY, part);
				firstX += 2;
			}
			Console.ForegroundColor = ConsoleColor.White;
		}

		private bool ColorExists(int color, List<int> targetColors)
		{
			for (int i = 0; i < targetColors.Count; i++)
			{
				for (int j = 0; j < targetColors.Count; j++)
				{
					if (color == targetColors[j])
						return true;
				}
			}
			return false;
		}

		/*
		 * IsCorrect
		 *
		 * IsCorrect returns true if the current guess was the correct answer,
		 * otherwise false.
		 *
		 */
		public bool IsCorrect(List<int> guessColors, List<int> targetColors)
		{
			bool same = true;

			if (guessColors.Count != targetColors.Count)
				same = false;
			else
			{
				for (int i = 0; i < guessColors.Count; i++)
				{
					if (guessColors[i] != targetColors[i])
						same = false;
				}
			}
			return same;
		}

		/*
		 * IsLastRow
		 *
		 * Returns true if the user has used all rows, otherwise false.
		 *
		 */
		public bool IsLastRow()
		{
			return currentRow == 12;
		}

		/* 
		 * DrawPart
		 * 
		 * Draws the part at a specific coordinate.
		 * 
		 */

		public void DrawKey(List<int> targetColors)
		{
			int x = 48;
			int y = 5;
			foreach (int item in targetColors)
			{
				Console.ForegroundColor = GetConsoleColor(item);
				string part = "███";
				DrawPart(x, y, part);
				x += 4;
			}
			Console.CursorVisible = false;
		}
		private void DrawPart(int x, int y, string part)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(part);
		}
	}
}