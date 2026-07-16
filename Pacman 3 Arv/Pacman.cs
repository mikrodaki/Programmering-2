namespace PacmanGame
{
    class Pacman
    {
        public int X;
        public int Y;
        private int direction;
        private int nextDirection;
        public int Score = 0;
        public int LivesLeft = 3;
        public int Level = 1;
        private int startX;
        private int startY;
        public int LevelScore { get; set; }

        public Pacman(int startX, int startY)
        {
            this.startX = startX;
            this.startY = startY;

            X = startX;
            Y = startY;

            direction = Constants.IDLE;
            nextDirection = Constants.IDLE;
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

        public void ResetPosition()
        {
            this.X = startX;
            this.Y = startY;
        }

        public void ResetDirection() 
        { 
            direction = Constants.IDLE;
            nextDirection = Constants.IDLE;
        }

		/*
         * Draw
         * 
         * Draw Pacman at current coordinate
         * 
         */
		public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteAt("O");
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

        /*
         * WriteAt
         * 
         * Help method that writes a text at a specific coordinate
         * 
         */
        void WriteAt(string text)
        {
            Console.SetCursorPosition(X + Constants.X_SCREEN_POS, Y + Constants.Y_SCREEN_POS);
            Console.Write(text);
        }
    }
}
