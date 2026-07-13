namespace PacmanGame
{
    class Pacman
    {
        public int x;
        public int y;
        int direction;
        int nextdirection;
        public int score = 0;
        public int livesLeft = 3;
        public int level = 1;
        private int startX;
        private int startY;
        public int LevelScore { get; set; }



        public Pacman(int startX, int startY)
        {
            this.startX = startX;
            this.startY = startY;

            x = startX;
            y = startY;

            direction = Constants.IDLE;
            nextdirection = Constants.IDLE;
        }

        public void IncreaseScore() 
        {
            score++;
            LevelScore++;
        }

        public void ResetLevelScore()
        {
            LevelScore = 0;
        }


        public void ResetPosition()
        {
            this.x = startX;
            this.y = startY;
        }


        public void ResetDirection() 
        { 
            direction = Constants.IDLE;
            nextdirection = Constants.IDLE;
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
			int oldX = x;
			int oldY = y;

			switch (direction) 
            {
                case Constants.UP:
                    if (maze[y - 1, x] != Constants.WALL)
                        y--;
                    break;

                case Constants.DOWN:
                    if (maze[y + 1, x] != Constants.WALL)
                        y++;
                    break;

                case Constants.LEFT:
                    if (maze[y, x - 1] != Constants.WALL)
                        x--;
                    break;

                case Constants.RIGHT:
                    if (maze[y, x + 1] != Constants.WALL)
                        x++;
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
            switch (nextdirection)
            {
                case Constants.UP:
                    if (maze[y - 1, x] != Constants.WALL)
                        direction = Constants.UP;
                    break;

                case Constants.DOWN:
                    if (maze[y + 1, x] != Constants.WALL)
                        direction = Constants.DOWN;
                    break;

                case Constants.LEFT:
                    if (maze[y, x - 1] != Constants.WALL)
                        direction = Constants.LEFT;
                    break;

                case Constants.RIGHT:
                    if (maze[y, x + 1] != Constants.WALL)
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
            nextdirection = _nextDirection;
        }



        /*
         * WriteAt
         * 
         * Help method that writes a text at a specific coordinate
         * 
         */
        void WriteAt(string text)
        {
            Console.SetCursorPosition(x + Constants.X_SCREEN_POS, y + Constants.Y_SCREEN_POS);
            Console.Write(text);
        }
    }
}
