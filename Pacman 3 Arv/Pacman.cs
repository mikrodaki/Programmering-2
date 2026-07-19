namespace PacmanGame
{
	public class Pacman : Character
	{
		private int nextDirection;

		public int Score { get; private set; }
		public int LevelScore { get; set; }
		public int LivesLeft { get; set; }
		public int Level { get; set; }

		public Pacman(int startX, int startY) : base (startX, startY)
		{
			direction = Constants.IDLE;
			nextDirection = Constants.IDLE;

			LivesLeft = 3;
			Level = 1;

			symbol = "O";
			color = ConsoleColor.Yellow;
		}

		public void IncreaseLevel() 
		{
			Level++;
		}

		public void LoseLife()
		{
			if (LivesLeft > 0)
			{
				LivesLeft--;
			}
		}

		public void IncreaseScore()
		{
			Score++;
			LevelScore++;
		}

		public void ResetLevelScore()
		{
			LevelScore = 0;
		}

		public void ResetDirection()
		{
			direction = Constants.IDLE;
			nextDirection = Constants.IDLE;
		}
		/*
         * Delete
         * 
         * Deletes Pacman from current coordinate
         * 
         */
		public void Delete()
		{
			WriteAt(" ");
		}

		/*
         * Move
         * 
         * Moves Pacman one step in current 
         * direction if possible
         * 
         */
		public void Move(int[,] maze)
		{
			switch (direction)
			{
				case Constants.UP:
					if (maze[Y - 1, X] != Constants.WALL)
						Y--;
					break;

				case Constants.DOWN:
					if (maze[Y + 1, X] != Constants.WALL)
						Y++;
					break;

				case Constants.LEFT:
					if (maze[Y, X - 1] != Constants.WALL)
						X--;
					break;

				case Constants.RIGHT:
					if (maze[Y, X + 1] != Constants.WALL)
						X++;
					break;

				default:
					break;
			}
		}

		/*
         * ChangeDirection
         * 
         * Checks if it it possible to change direction
         * to the stored next direction. The direction
         * is changed if possible to walk in the desired
         * direction at the current coordinate.
         * 
         */
		public void ChangeDirection(int[,] maze)
		{
			switch (nextDirection)
			{
				case Constants.UP:
					if (maze[Y - 1, X] != Constants.WALL)
						direction = Constants.UP;
					break;

				case Constants.DOWN:
					if (maze[Y + 1, X] != Constants.WALL)
						direction = Constants.DOWN;
					break;

				case Constants.LEFT:
					if (maze[Y, X - 1] != Constants.WALL)
						direction = Constants.LEFT;
					break;

				case Constants.RIGHT:
					if (maze[Y, X + 1] != Constants.WALL)
						direction = Constants.RIGHT;
					break;

				default:
					break;
			}
		}

		/*
         * SetNextDirection
         * 
         * Stores the next direction that the player
         * wants to go, whenever it is possible
         *
         */
		public void SetNextDirection(int _nextDirection)
		{
			nextDirection = _nextDirection;
		}

	}
}
