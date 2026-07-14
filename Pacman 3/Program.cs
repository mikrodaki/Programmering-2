using System;

namespace PacmanGame
{
	internal class Program
	{
		static Random random = new Random();
		static ConsoleColor[] colors =
		{
			ConsoleColor.Red,
			ConsoleColor.Green,
			ConsoleColor.Blue,
			ConsoleColor.Yellow,
			ConsoleColor.Cyan,
			ConsoleColor.Magenta
		};
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;      // Enables writing the ghost char

			Console.CursorVisible = false;

			Maze maze = new Maze();
			Pacman pacman = new Pacman(14, 9);
			List<Ghost> ghosts = new List<Ghost>();
			List<Ghost> ghostStorage = new List<Ghost>();
			bool levelCompleted = false;
			bool gameOver = false;
			bool quitGame = false;

			//Sound.LoadPellet();

			Intro();

			maze.Draw();

			pacman.LevelScore = 0;

			DrawScore(pacman.score);
			DrawLives(pacman.livesLeft);
			DrawLevel(pacman.level);

			//for (int i = 0; i < 10; i++)
			//{
			//	ghostStorage.Add(CreateRandomGhost(maze, pacman, ghostStorage));
			//}

			ghosts.Add(CreateRandomGhost(maze, pacman, ghosts));

			while (!quitGame)
			{
				levelCompleted = false;
				gameOver = false;

				while (true)
				{
					ReadKeys(pacman);
					pacman.ChangeDirection(maze.maze);

					foreach (Ghost ghost in ghosts)
					{
						if (ghost.ChasesPacman)
							ghost.ChangeDirectionChasingPacman(maze.maze, pacman);
						else
							ghost.ChangeDirection(maze.maze);
					}

					foreach (Ghost ghost in ghosts)
					{
						ghost.Delete(maze.maze);
					}

					pacman.Delete();

					pacman.Move(maze.maze);

					if (CheckCollision(pacman, ghosts))
					{
						gameOver = HandlePacmanDeath(maze, pacman, ghosts);
						if (gameOver) break;
					}

					foreach (Ghost ghost in ghosts)
					{
						ghost.Move(maze.maze);
					}

					if (CheckCollision(pacman, ghosts))
					{
						gameOver = HandlePacmanDeath(maze, pacman, ghosts);
						if (gameOver) break;
					}

					if (maze.IsPellet(pacman.x, pacman.y))
					{
						maze.DeletePellet(pacman.x, pacman.y);
						pacman.IncreaseScore();
						DrawScore(pacman.score);
					}

					pacman.Draw();

					foreach (Ghost ghost in ghosts)
					{
						ghost.Draw();
					}

					if (pacman.LevelScore == maze.maxPoints)
					{
						pacman.level++;
						levelCompleted = true;

						break;
					}
					Thread.Sleep(150);
				}

				if (gameOver)
				{
					GameOver();
					quitGame = true;
				}
				else if (levelCompleted)
				{
					LevelCompleted();
					StartNewLevel(maze, pacman, ghosts, ghostStorage);
				}
			}
		}

		static void StartNewLevel(Maze maze, Pacman pacman, List<Ghost> ghosts, List<Ghost> ghostStorage)
		{
			//Intro();
			maze.Reset();
			maze.Draw();
			IntroNewLevel();

			DrawScore(pacman.score);
			DrawLives(pacman.livesLeft);
			DrawLevel(pacman.level);

			pacman.ResetLevelScore();
			pacman.ResetPosition();
			pacman.ResetDirection();
			pacman.Draw();

			ghosts.Clear();
			//ghostStorage.Clear();

			//for (int i = 0; i < pacman.level; i++)
			//{
			//	ghostStorage.Add(CreateRandomGhost(maze, pacman, ghostStorage));
			//}

			for (int i = 0; i < pacman.level; i++)
			{
				ghosts.Add(CreateRandomGhost(maze, pacman, ghosts));
			}

			foreach (Ghost ghost in ghosts)
			{
				ghost.ResetPosition();
				ghost.Draw();
			}
		}

		static bool HandlePacmanDeath(Maze maze, Pacman pacman, List<Ghost> ghosts)
		{
			pacman.livesLeft--;

			ResetGameBoard(maze, pacman, ghosts);
			DrawLives(pacman.livesLeft);

			// Nollställ riktning (viktigt!)
			pacman.ResetDirection();

			// Kort paus så döden känns tydlig (valfritt men bra)
			Thread.Sleep(300);

			// Töm alla kvarhängande knapptryck
			while (Console.KeyAvailable)
			{
				Console.ReadKey(true);
			}

			return pacman.livesLeft == 0;
			Intro();
		}

		static bool CheckCollision(Pacman pacman, List<Ghost> ghosts)
		{
			foreach (Ghost ghost in ghosts)
			{
				if (ghost.x == pacman.x && ghost.y == pacman.y)
				{
					Hit(ghost.x, ghost.y);
					return true;
				}
			}
			return false;
		}

		static void ResetGameBoard(Maze maze, Pacman pacman, List<Ghost> ghosts)
		{
			pacman.ResetPosition();
			pacman.ResetDirection();
			foreach (Ghost ghost in ghosts)
			{
				ghost.ResetPosition();
			}
		}

		/*
         * Draw Score
         *
         * 
         */
		static void DrawScore(int score)
		{
			Console.SetCursorPosition(Constants.X_SCREEN_POS + 20, Constants.Y_SCREEN_POS - 1);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Score: " + score);
		}

		static void DrawLives(int noOfLives)
		{
			Console.SetCursorPosition(Constants.X_SCREEN_POS + 10, Constants.Y_SCREEN_POS - 1);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Lives: " + noOfLives);
		}

		static void DrawLevel(int currentLevel)
		{
			Console.SetCursorPosition(Constants.X_SCREEN_POS, Constants.Y_SCREEN_POS - 1);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Level: " + currentLevel);
		}



		/*
         * ReadKeys
         *
         * Checks for user key strokes. If an arrow 
         * keys has been hit, store pacmans next
         * turn direction.
         * 
         */
		static void ReadKeys(Pacman pacman)
		{
			ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

			if (Console.KeyAvailable)
				keyInfo = Console.ReadKey(true);

			switch (keyInfo.Key)
			{
				case ConsoleKey.UpArrow:
					pacman.SetNextDirection(Constants.UP);
					break;

				case ConsoleKey.DownArrow:
					pacman.SetNextDirection(Constants.DOWN);
					break;

				case ConsoleKey.LeftArrow:
					pacman.SetNextDirection(Constants.LEFT);
					break;

				case ConsoleKey.RightArrow:
					pacman.SetNextDirection(Constants.RIGHT);
					break;

				default:
					break;
			}
		}



		/*
         * Intro
         *
         * Draws four ghosts in different colors
         * and prints the game label at four 
         * positions.
         * 
         */
		static void Intro()
		{
			//Sound.PlayIntro();
			Console.ForegroundColor = ConsoleColor.Yellow;

			DrawPacmanTitles();

			DrawGhost(12, 13, ConsoleColor.Red);
			DrawGhost(25, 13, ConsoleColor.Cyan);
			DrawGhost(89, 13, ConsoleColor.Green);
			DrawGhost(102, 13, ConsoleColor.Magenta);

			Console.ForegroundColor = ConsoleColor.Yellow;
			WriteAt(50, 13, "Press any key to start");
			Console.ReadKey(true);
			WriteAt(50, 13, "                      ");
		}

		/*
         * IntroNewLevel
         *
         * Draws four ghosts in different colors
         * and prints the game label at four 
         * positions. A modified version of Intro()
         * 
         */
		static void IntroNewLevel()
		{
			//Sound.PlayIntro();
			Console.ForegroundColor = ConsoleColor.Yellow;

			DrawPacmanTitles();

			DrawGhost(12, 13, ConsoleColor.Red);
			DrawGhost(25, 13, ConsoleColor.Cyan);
			DrawGhost(89, 13, ConsoleColor.Green);
			DrawGhost(102, 13, ConsoleColor.Magenta);

			//Console.ForegroundColor = ConsoleColor.Yellow;
			//WriteAt(50, 13, "Press any key to start");
			//Console.ReadKey(true);
			//WriteAt(50, 13, "                      ");
		}



		/*
         * DrawPacmanTitles
         * 
         * Draws the game title at four different positions.
         * 
         */
		static void DrawPacmanTitles()
		{
			for (int i = 0; i < 4; i++)
			{
				int xPos = i % 2;
				int yPos = i / 2;
				WriteAt(xPos * 77 + 4, yPos * 11 + 7, "  ___   _   ___  __  __   _   _  _ ");
				WriteAt(xPos * 77 + 4, yPos * 11 + 8, " | _ \\ /_\\ / __||  \\/  | /_\\ | \\| |");
				WriteAt(xPos * 77 + 4, yPos * 11 + 9, " |  _// _ \\ (__ | |\\/| |/ _ \\| .  |");
				WriteAt(xPos * 77 + 4, yPos * 11 + 10, " |_| /_/ \\_\\___||_|  |_/_/ \\_\\_|\\_|");
			}
		}



		/*
         * DrawGhost
         *
         * Draws a ghost at the specific coordinate in the selected color.
         * 
         */
		static void DrawGhost(int x, int y, ConsoleColor color)
		{
			// Draw body
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = color;
			WriteAt(x, y, " ▄▄▄▄▄");
			WriteAt(x, y + 1, "▐  █  ▌");
			WriteAt(x, y + 2, "███████");
			WriteAt(x, y + 3, "▀ ▀ ▀ ▀");

			// Draw eyes
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.BackgroundColor = ConsoleColor.White;
			WriteAt(x + 1, y + 1, "▀ ");
			WriteAt(x + 4, y + 1, "▀ ");
			Console.BackgroundColor = ConsoleColor.Black;
		}



		/*
         * Hit
         * 
         * Animates a blinking O (Pacman) when Pacman
         * and a ghost has collides.
         * 
         */
		static void Hit(int x, int y)
		{
			Sound.PlayHit();
			Console.ForegroundColor = ConsoleColor.Yellow;

			for (int i = 0; i < 5; i++)
			{
				WriteAt(x + Constants.X_SCREEN_POS, y + Constants.Y_SCREEN_POS, "O");
				System.Threading.Thread.Sleep(70);
				WriteAt(x + Constants.X_SCREEN_POS, y + Constants.Y_SCREEN_POS, " ");
				System.Threading.Thread.Sleep(70);
			}
		}



		/*
         * GameOver
         * 
         * Writes the text Game over and
         * animates the intro ghosts eyes
         * 
         */
		static void GameOver()
		{
			string[] eyes = new string[4] { " ▀", " ▄", "▄ ", "▀ " };
			int[] xEyePos = new int[] { 13, 26, 90, 103 };

			//Sound.PlayGameOver();

			Console.ForegroundColor = ConsoleColor.Yellow;
			WriteAt(53, 24, "G A M E  O V E R ");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.BackgroundColor = ConsoleColor.White;

			for (int turns = 0; turns < 15; turns++)                   // Loop eyes 20 laps
				for (int eye = 0; eye < 4; eye++)                      // Next eye position
				{
					for (int ghost = 0; ghost < 4; ghost++)            // Change eye position for all for ghosts
					{
						WriteAt(xEyePos[ghost], 14, eyes[eye]);
						WriteAt(xEyePos[ghost] + 3, 14, eyes[eye]);
					}

					System.Threading.Thread.Sleep(80);
				}

			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.ReadKey();
			Console.Clear();
		}



		/*
         * LevelCompleted
         * 
         * Writes the text Level Completed and
         * animated flashing game titles in
         * different colors.
         * 
         */
		static void LevelCompleted()
		{
			Random rnd = new Random();

			//Sound.LevelCompleted();

			Console.ForegroundColor = ConsoleColor.Yellow;
			WriteAt(46, 24, "L E V E L   C O M P L E T E D");

			for (int i = 0; i < 75; i++)
			{
				int color = rnd.Next(1, 16);
				Console.ForegroundColor = (ConsoleColor)color;
				DrawPacmanTitles();
				System.Threading.Thread.Sleep(40);
			}

			Console.ForegroundColor = ConsoleColor.Black;
			Console.ReadKey();
			Console.Clear();
		}



		/*
         * WriteAt
         * 
         * Help method that writes a text 
         * at a specific coordinate
         * 
         */
		static void WriteAt(int x, int y, string text)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(text);
		}

		static (int x, int y) GetRandomEmptyPosition(Maze maze, Pacman pacman)
		{
			while (true)
			{
				int y = random.Next(maze.maze.GetLength(0));
				int x = random.Next(maze.maze.GetLength(1));

				if (maze.maze[y, x] == 2)
				{
					int distance = Math.Abs(x - pacman.x) + Math.Abs(y - pacman.y);

					if (distance >= 10)
						return (x, y);
				}
			}
		}

		static Ghost CreateRandomGhost(Maze maze, Pacman pacman, List<Ghost> ghosts)
		{
			var position = GetRandomEmptyPosition(maze, pacman);
			if (ghosts.Count < 2)
				return new Ghost(position.x, position.y, false);
			else
				
				return new Ghost(position.x, position.y, true);
		}
	}
}
