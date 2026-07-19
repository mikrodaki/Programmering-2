namespace MasterMind
{
	class Board     // Lägg klassen i separat fil
	{
		private int currentRow = 0;
		private static Random random = new Random();

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
			return new List<int>();
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
			return true;
		}

		/*
		 * IsLastRow
		 *
		 * Returns true if the user has used all rows, otherwise false.
		 *
		 */
		public bool IsLastRow()
		{
			return true;   // Temporär rad
		}

		/* 
		 * DrawPart
		 * 
		 * Draws the part at a specific coordinate.
		 * 
		 */
		private void DrawPart(int x, int y, string part)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(part);
		}
	}
}