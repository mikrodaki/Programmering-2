using System;

namespace PacmanGame
{
	public class Ghost : Character
	{
		private static Random random = new Random();

		public bool ChasesPacman { get; private set; }

		public Ghost(int startX, int startY, bool chasesPacman) : base (startX, startY)
		{
			ChasesPacman = chasesPacman;

			color = ChasesPacman
			? ConsoleColor.Red
			: ConsoleColor.Green;

			symbol = "ᗣ";
		}

		private List<int> GetPossibleDirections(int[,] maze)
		{
			List<int> possibleDirections = new List<int>();

			if (maze[Y - 1, X] != Constants.WALL)
				possibleDirections.Add(Constants.UP);

			if (maze[Y + 1, X] != Constants.WALL)
				possibleDirections.Add(Constants.DOWN);

			if (maze[Y, X - 1] != Constants.WALL)
				possibleDirections.Add(Constants.LEFT);

			if (maze[Y, X + 1] != Constants.WALL)
				possibleDirections.Add(Constants.RIGHT);

			int opposite = GetOpposite(direction);
			possibleDirections.Remove(opposite);

			return possibleDirections;
		}

		private int GetOpposite(int direction)
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
			List<int> possibleDirections = GetPossibleDirections(maze);

			// Om ingen riktning mot Pac-Man fungerade:
			// välj en slumpmässig tillåten riktning.
			// Ifall det finns återvändsgränder så sätt direction till opposite.
			// Finns inte i detta spel just nu men ändå. 
			if (possibleDirections.Count > 0)
			{
				direction = possibleDirections[random.Next(possibleDirections.Count)];
			}
			else
			{
				direction = GetOpposite(direction);
			}
		}

		public void ChangeDirectionChasingPacman(int[,] maze, Pacman pacman)
		{
			List<int> possibleDirections = GetPossibleDirections(maze);

			// Försök först gå horisontellt mot Pac-Man.
			if (pacman.X > X &&
				possibleDirections.Contains(Constants.RIGHT))
			{
				direction = Constants.RIGHT;
				return;
			}

			if (pacman.X < X &&
				possibleDirections.Contains(Constants.LEFT))
			{
				direction = Constants.LEFT;
				return;
			}

			// Om horisontell rörelse inte gick,
			// försök gå vertikalt mot Pac-Man.
			if (pacman.Y > Y &&
				possibleDirections.Contains(Constants.DOWN))
			{
				direction = Constants.DOWN;
				return;
			}

			if (pacman.Y < Y &&
				possibleDirections.Contains(Constants.UP))
			{
				direction = Constants.UP;
				return;
			}

			// Om ingen riktning mot Pac-Man fungerade:
			// välj en slumpmässig tillåten riktning.
			// Ifall det finns återvändsgränder så sätt direction till opposite.
			// Finns inte i detta spel just nu men ändå. 
			if (possibleDirections.Count > 0)
			{
				direction = possibleDirections[random.Next(possibleDirections.Count)];
			}
			else
			{
				direction = GetOpposite(direction);
			}
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
			int newX = X;
			int newY = Y;

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
				X = newX;
				Y = newY;
			}
		}

		/*
         * Delete
         *
         * Deletes @ at (x, y) coordinate
         *
         */
		public void Delete(int[,] maze)
		{
			if (maze[Y, X] == Constants.PELLET)
			{
				Console.ForegroundColor = ConsoleColor.White;
				WriteAt(".");
			}
			else
				WriteAt(" ");
		}
	}
}
