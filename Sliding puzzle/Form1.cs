namespace Sliding_puzzle
{
	public partial class Form1 : Form
	{
		private static Random random = new Random();

		private Piece[,] pieces;
		private int currentX;
		private int currentY;
		private List<int> randomNumbers = new List<int>();
		private List<int> solvedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
		private bool gameOver = false;

		private const int pieceWidth = 137;
		private const int pieceHeight = 137;
		private const int boardWidth = 4;
		private const int boardHeight = 4;
		private const int UP = 0;
		private const int RIGHT = 1;
		private const int DOWN = 2;
		private const int LEFT = 3;

		public Form1()
		{
			InitializeComponent();
			pieces = new Piece[boardHeight, boardWidth];

			ClientSize = new Size(
				pieceWidth * boardWidth,
				pieceHeight * boardHeight);

			currentX = boardWidth - 1;
			currentY = boardHeight - 1;

			//InitRandomNumbers();
			InitPieces();
			/*
			 * Start from a solved list and make 
			 * random moves to make it a little easier. 
			 *
			 */
			for (int i = 0; i < 50; i++)
			{
				RandomMove(random.Next(4));
			}
		}

		private void InitPieces()
		{
			int cardNumber = 0;
			for (int row = 0; row < pieces.GetLength(0); row++)
			{
				for (int col = 0; col < pieces.GetLength(1); col++)
				{
					if (row == pieces.GetLength(0) - 1 && col == pieces.GetLength(1) - 1)
					{
						Piece piece = new Piece(col, row, null);
						pieces[row, col] = piece;
					}
					else
					{
						Piece piece = new Piece(col, row, solvedList[cardNumber]);
						piece.Left = piece.X * pieceWidth;
						piece.Top = piece.Y * pieceHeight;
						piece.SizeMode = PictureBoxSizeMode.AutoSize;
						piece.Image = Image.FromFile(piece.Number + ".png");
						this.Controls.Add(piece);
						pieces[row, col] = piece;
						cardNumber++;
					}
				}
			}
		}

		private void InitRandomNumbers()
		{
			randomNumbers.Clear();

			for (int i = 0; i < pieces.Length - 1; i++)
			{
				while (true)
				{
					int randomNumber = random.Next(1, 16);
					if (!randomNumbers.Contains(randomNumber))
					{
						randomNumbers.Add(randomNumber);
						break;
					}
				}
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (gameOver)
				return;

			switch (e.KeyCode)
			{
				case Keys.Up:

					if (IsWithinBounds(currentX, currentY + 1))
					{
						Swap(ref pieces[currentY, currentX], ref pieces[currentY + 1, currentX]);

						MovePiece(pieces[currentY, currentX], UP);

						currentY++;
					}
					else
					{
						return;
					}
					break;

				case Keys.Down:

					if (IsWithinBounds(currentX, currentY - 1))
					{
						Swap(ref pieces[currentY, currentX], ref pieces[currentY - 1, currentX]);

						MovePiece(pieces[currentY, currentX], DOWN);

						currentY--;
					}
					else
					{
						return;
					}
					break;

				case Keys.Left:

					if (IsWithinBounds(currentX + 1, currentY))
					{
						Swap(ref pieces[currentY, currentX], ref pieces[currentY, currentX + 1]);

						MovePiece(pieces[currentY, currentX], LEFT);

						currentX++;
					}
					else
					{
						return;
					}
					break;

				case Keys.Right:

					if (IsWithinBounds(currentX - 1, currentY))
					{
						Swap(ref pieces[currentY, currentX], ref pieces[currentY, currentX - 1]);

						MovePiece(pieces[currentY, currentX], RIGHT);

						currentX--;
					}
					else
					{
						return;
					}
					break;

				default:
					return;
			}
			if (IsCompleted())
			{
				gameOver = true;
				MessageBox.Show("Voff!");
			}
		}

		private void Swap(ref Piece a, ref Piece b)
		{
			Piece temp = a;
			a = b;
			b = temp;
		}

		private bool IsWithinBounds(int x, int y)
		{
			return
				y >= 0 &&
				y < pieces.GetLength(0) &&
				x >= 0 &&
				x < pieces.GetLength(1);
		}

		private void MovePiece(Piece piece, int direction)
		{
			int dx = 0;
			int dy = 0;

			switch (direction)
			{
				case UP:
					dy = -1;
					break;
				case RIGHT:
					dx = 1;
					break;
				case DOWN:
					dy = +1;
					break;
				case LEFT:
					dx = -1;
					break;
			}

			int distance;

			if (dx != 0)
				distance = pieceWidth;
			else
				distance = pieceHeight;

			for (int i = 0; i < distance; i++)
			{
				piece.Left += dx;
				piece.Top += dy;
			}
		}

		private bool IsCompleted()
		{
			int expectedNumber = 1;

			for (int row = 0; row < pieces.GetLength(0); row++)
			{
				for (int col = 0; col < pieces.GetLength(1); col++)
				{
					Piece a = pieces[row, col];

					if (expectedNumber == pieces.Length)
						return true;

					if (a.Number != expectedNumber)
						return false;

					expectedNumber++;
				}
			}
			return true;
		}

		private void RandomMove(int direction)
		{
			switch (direction)
			{
				case UP:

					if (IsWithinBounds(currentX, currentY + 1))
					{
						Swap(ref pieces[currentY, currentX], ref pieces[currentY + 1, currentX]);

						MovePiece(pieces[currentY, currentX], UP);

						currentY++;
					}
					else
					{
						return;
					}
					break;

				case DOWN:

					if (IsWithinBounds(currentX, currentY - 1))
					{
						Swap(ref pieces[currentY, currentX], ref pieces[currentY - 1, currentX]);

						MovePiece(pieces[currentY, currentX], DOWN);

						currentY--;
					}
					else
					{
						return;
					}
					break;

				case LEFT:

					if (IsWithinBounds(currentX + 1, currentY))
					{
						Swap(ref pieces[currentY, currentX], ref pieces[currentY, currentX + 1]);

						MovePiece(pieces[currentY, currentX], LEFT);

						currentX++;
					}
					else
					{
						return;
					}
					break;

				case RIGHT:

					if (IsWithinBounds(currentX - 1, currentY))
					{
						Swap(ref pieces[currentY, currentX], ref pieces[currentY, currentX - 1]);

						MovePiece(pieces[currentY, currentX], RIGHT);

						currentX--;
					}
					else
					{
						return;
					}
					break;

				default:
					return;
			}
		}
	}
}
