using System;
using System.ComponentModel.Design;

namespace Maze
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Maze unsolvableMaze = new Maze(70, 4, false);
			Maze solvableMaze = new Maze(20, 4, true);

			Console.CursorVisible = false;

			PrintText(27, 2, "Lösbar labyrint");
			unsolvableMaze.Draw();

			PrintText(78, 2, "Olösbar labyrint");
			solvableMaze.Draw();

			PrintText(30, 26, "Lösbar: " + solvableMaze.IsSolvable(1, 1));
			PrintText(81, 26, "Lösbar: " + unsolvableMaze.IsSolvable(1, 1));

			Console.ReadKey();
		}



		/*
         * PrintText
         * 
         * Prints a text at specified coordinate
         * 
         */
		static void PrintText(int x, int y, string title)
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(x, y);
			Console.WriteLine(title);
		}
	}



	/*
     * Maze
     * 
     * This class contains the maze array, a method to draw the maze, 
     * a plot method and a method that checks if the maze i solvable.
     * 
     */
	class Maze
	{
		// Coordinate for block which will make the maze unsolvable
		const int BLOCK_X_COORDINATE = 15;
		const int BLOCK_Y_COORDINATE = 26;

		const int PATH = 0;
		const int WALL = 1;
		const int VISITED = 2;

		int x;
		int y;

		int[,] maze = new int[,]
		{
				{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
				{1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1},
				{1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1},
				{1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1},
				{1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1},
				{1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1},
				{1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1},
				{1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1},
				{1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1},
				{1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
				{1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1},
				{1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1},
				{1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1},
				{1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1},
				{1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1},
				{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
				{1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1},
				{1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1},
				{1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1},
				{1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
				{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
		};



		/*
         * Constructor
         *
         * Store the maze console upper lefter position.
         * Add a block if the maze should be unsolvable.
         *
         */
		public Maze(int x, int y, bool solvable)
		{
			this.x = x;
			this.y = y;

			if (!solvable)
				maze[BLOCK_X_COORDINATE, BLOCK_Y_COORDINATE] = WALL;
		}



		/*
         * Draw
         * 
         * Draws a dark green maze
         * 
         */
		public void Draw()
		{
			Console.BackgroundColor = ConsoleColor.DarkGreen;

			for (int i = 0; i < maze.GetLength(0); i++)
				for (int j = 0; j < maze.GetLength(1); j++)
					if (maze[i, j] == WALL)
					{
						Console.SetCursorPosition(j + x, i + y);
						Console.WriteLine(" ");
					}
		}



		/*
         * IsSolvable
         * 
         * Returns true if the maze is solvable, which means
         * that there exists a path in maze from the upper 
         * left corner to the lower right in the maze.
         * Otherwise return false.
         * 
         * x is the current x-position to exam.
         * y is the current y-position to exam.
         * 
         */
		public bool IsSolvable(int x, int y)
		{
			int rows = maze.GetLength(0);
			int cols = maze.GetLength(1);
			int goalX = cols - 2;
			int goalY = rows - 2;

			/*
             * Basfall: Kontrollera om vi har nått målet. Sätt isåfall:
             * Rita ett block
             * Markera positionen som besökt
             * Returnerna true
             * 
             */

			if (x == goalX && y == goalY)
			{
				Plot(x, y);
				maze[y, x] = VISITED;
				return true;
			}




			/* 
             * Kontrollera om positionen är giltig (inom labyrinten) och inte en vägg. Om så är fallet:
             * Rita ett block
             * Sätt positionen som besökt
             * Gör ett rekursivt anrop till positionen ovanför. Returnerna true om det anropet returnerade true.
             * Gör här också anrop åt de andra hållen på samma sätt.
             * 
             */

			if (x >= 0 && x < maze.GetLength(1) && 
				y >= 0 && y < maze.GetLength(0) &&
				maze[y,x] != WALL &&
				maze[y,x] != VISITED) 
			{ 
				Plot(x,y);
				Thread.Sleep(10);
				maze[y, x] = VISITED;
			}
			else 
			{
				return false;
			}


			if (IsSolvable(x, y - 1))
				return true;
			
			if (IsSolvable(x - 1, y))
				return true;
			
			if (IsSolvable(x, y + 1))
				return true;
			
			if (IsSolvable(x + 1, y))
				return true;



			/*
			 * Returnera slutligen false. Den här positionen är en vägg.
			 *
			 */


			return false; 
		}



		/*
         * Plot
         * 
         * Plots a yellow block att specified coordinate.
         * 
         */
		private void Plot(int x, int y)
		{
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(x + this.x, y + this.y);
			Console.WriteLine(" ");
		}
	}
}
