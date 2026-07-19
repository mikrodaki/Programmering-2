namespace PacmanGame
{
	public class Character
	{
		protected int startX;
		protected int startY;
		protected int direction;
		protected ConsoleColor color;
		protected string? symbol;

		public int X { get; protected set; }
		public int Y { get; protected set; }
		public Character(int startX, int startY)
		{
			this.startX = startX;
			this.startY = startY;

			X = startX;
			Y = startY;
		}

		/*
         * WriteAt
         * 
         * Help method that writes a text at a specific coordinate
         * 
         */
		protected void WriteAt(string text)
		{
			Console.SetCursorPosition(X + Constants.X_SCREEN_POS, Y + Constants.Y_SCREEN_POS);
			Console.Write(text);
		}

		public void ResetPosition()
		{
			X = startX;
			Y = startY;
		}

		/*
         * Draw
         * 
         * Draw Pacman at current coordinate
         * 
         */
		public void Draw()
		{
			Console.ForegroundColor = color;
			WriteAt(symbol);
		}
	}
}
