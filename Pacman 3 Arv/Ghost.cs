using System;

namespace PacmanGame
{
	class Ghost
	{
		public int x;
		public int y;
		ConsoleColor color;
		int direction;
		Random random = new Random();
		private int startX;
		private int startY;
		public bool ChasesPacman { get; set; }

		public Ghost(int startX, int startY, bool chasesPacman)
		{

			this.startX = startX;
			this.startY = startY;

			this.x = startX;
			this.y = startY;

			ChasesPacman = chasesPacman;

			this.color = ChasesPacman
			? ConsoleColor.Red
			: ConsoleColor.Green;

		}

		public int GetOpposite(int direction)
		{
			switch (direction)
			{
				case Constants.UP: return Constants.DOWN;
				case Constants.RIGHT: return Constants.LEFT;
				case Constants.DOWN: return Constants.UP;
				case Constants.LEFT: return Constants.RIGHT;
				default: return Constants.IDLE;
			}
		}

		public void ChangeDirection(int[,] maze)
		{
			List<int> possibleDirections = new List<int>();

			if (maze[y - 1, x] != Constants.WALL)
				possibleDirections.Add(Constants.UP);

			if (maze[y + 1, x] != Constants.WALL)
				possibleDirections.Add(Constants.DOWN);

			if (maze[y, x - 1] != Constants.WALL)
				possibleDirections.Add(Constants.LEFT);

			if (maze[y, x + 1] != Constants.WALL)
				possibleDirections.Add(Constants.RIGHT);

			// Ta bort bakåt
			int opposite = GetOpposite(direction);
			possibleDirections.Remove(opposite);

			// Slumpa ny riktning
			direction = possibleDirections[random.Next(possibleDirections.Count)];
		}

		public void ChangeDirectionChasingPacman(int[,] maze, Pacman pacman)
		{
			List<int> possibleDirections = new List<int>();

			if (maze[y - 1, x] != Constants.WALL)
				possibleDirections.Add(Constants.UP);

			if (maze[y + 1, x] != Constants.WALL)
				possibleDirections.Add(Constants.DOWN);

			if (maze[y, x - 1] != Constants.WALL)
				possibleDirections.Add(Constants.LEFT);

			if (maze[y, x + 1] != Constants.WALL)
				possibleDirections.Add(Constants.RIGHT);

			// Spöket ska helst inte gå tillbaka samma väg.
			int opposite = GetOpposite(direction);
			possibleDirections.Remove(opposite);

			// Försök först gå horisontellt mot Pac-Man.
			if (pacman.X > x &&
				possibleDirections.Contains(Constants.RIGHT))
			{
				direction = Constants.RIGHT;
				return;
			}

			if (pacman.X < x &&
				possibleDirections.Contains(Constants.LEFT))
			{
				direction = Constants.LEFT;
				return;
			}

			// Om horisontell rörelse inte gick,
			// försök gå vertikalt mot Pac-Man.
			if (pacman.Y > y &&
				possibleDirections.Contains(Constants.DOWN))
			{
				direction = Constants.DOWN;
				return;
			}

			if (pacman.Y < y &&
				possibleDirections.Contains(Constants.UP))
			{
				direction = Constants.UP;
				return;
			}

			// Om ingen riktning mot Pac-Man fungerade:
			// välj en slumpmässig tillåten riktning.
			direction = possibleDirections[
				random.Next(possibleDirections.Count)
			];
		}

		/*
         * Move
         *
         * Moves the @ one step in the current
         * direction if possible
         *
         */
		public void Move(int[,] maze)
		{
			int newX = x;
			int newY = y;

			switch (direction)
			{
				case Constants.UP:
					newY--;
					break;
				case Constants.RIGHT:
					newX++;
					break;
				case Constants.DOWN:
					newY++;
					break;
				case Constants.LEFT:
					newX--;
					break;
				case Constants.IDLE:
					return;
			}

			if (maze[newY, newX] != Constants.WALL)
			{
				x = newX;
				y = newY;
			}
		}

		/*
         * Draw
         *
         * Draws a red @ at (x, y) coordinate
         *
         */
		public void Draw()
		{
			Console.ForegroundColor = color;
			WriteAt("ᗣ");
		}

		/*
         * WriteAt
         *
         * WriteAt is a help method that writes
         * a text at a specific coordinate
         *
         */
		void WriteAt(string text)
		{
			Console.SetCursorPosition(x + Constants.X_SCREEN_POS, y + Constants.Y_SCREEN_POS);
			Console.Write(text);
		}

		/*
         * Delete
         *
         * Deletes @ at (x, y) coordinate
         *
         */
		public void Delete(int[,] maze)
		{
			if (maze[y, x] == Constants.PELLET)
			{
				Console.ForegroundColor = ConsoleColor.White;
				WriteAt(".");
			}
			else
				WriteAt(" ");
		}

		public void ResetPosition()
		{
			x = startX;
			y = startY;
		}

	}
}
