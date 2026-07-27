namespace Sliding_puzzle
{
	public partial class Form1 : Form
	{
		private static Random random = new Random();

		private Piece[,] pieces;
		private int currentX;
		private int currentY;
		private List<int> randomNumbers = new List<int>();

		private const int tileWidth = 137;
		private const int tileHeight = 137;
		private const int boardWidth = 548;
		private const int boardHeight = 548;

		public Form1()
		{
			pieces = new Piece[4, 4];
			currentX = 0;
			currentY = 0;
			InitializeComponent();
			this.Width = boardWidth;
			this.Height = boardHeight;
			InitRandomNumbers();
			InitPieces();
		}

		private void InitPieces()
		{
			int x = 0;
			int y = 0;
			int cardNumber = 0;
			for (int row = 0; row < pieces.GetLength(0); row++)
			{
				for (int col = 0; col < pieces.GetLength(1); col++)
				{
					if (row == pieces.GetLength(0) - 1 && col == pieces.GetLength(1) - 1)
					{
						Piece piece = new Piece(x, y, null);
						piece.Left = piece.X;
						piece.Top = piece.Y;
						piece.SizeMode = PictureBoxSizeMode.AutoSize;
						pieces[row, col] = piece;
					}
					else
					{
						Piece piece = new Piece(x, y, randomNumbers[cardNumber]);
						piece.Left = piece.X;
						piece.Top = piece.Y;
						piece.SizeMode = PictureBoxSizeMode.AutoSize;
						piece.Image = Image.FromFile(piece.Number + ".png");
						this.Controls.Add(piece);
						pieces[row, col] = piece;
						y += tileWidth;
						cardNumber++;
					}
				}
				x += tileHeight;
				y = 0;
			}
		}

		private void InitRandomNumbers()
		{
			List<int> usedNumbers = new List<int>();
			for (int i = 0; i < 15; i++)
			{
				bool ok = false;
				while (!ok)
				{
					int randomNumber = random.Next(1, 16);
					if (!usedNumbers.Contains(randomNumber))
					{
						usedNumbers.Add(randomNumber);
						randomNumbers.Add(randomNumber);
						ok = true;
					}
				}
			}
		}
	}
}
