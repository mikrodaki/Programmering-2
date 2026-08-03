using System.Drawing.Printing;

namespace Minesweeper
{
	public partial class Form1 : Form
	{
		private readonly int BOARD_WIDTH = 18;
		private readonly int BOARD_HEIGHT = 16;
		private readonly int CELL_WIDTH = 47;
		private readonly int CELL_HEIGHT = 47;
		private readonly int MINES = 2;
		private readonly int MARGIN = 20;
		private Cell[,] cells;
		private Random random = new Random();
		private bool isGameOver = false;



		public Form1()
		{
			InitializeComponent();
			cells = new Cell[BOARD_HEIGHT, BOARD_WIDTH];

			int boardWidth = BOARD_WIDTH * CELL_WIDTH + MARGIN * 2;
			int boardHeight = BOARD_HEIGHT * CELL_HEIGHT;

			// Lite mellanrum mellan knappen och spelplanen
			// Anpassa klientytan
			ClientSize = new Size(
			boardWidth,
			buttonStart.Bottom + (MARGIN * 2) + boardHeight);

			buttonStart.Location = new Point((boardWidth - buttonStart.Width) / 2, MARGIN);
			labelWinOrLoose.Location = new Point(buttonStart.Left - MARGIN * 6, MARGIN);
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			InitBoard();
			buttonStart.Enabled = false;
		}

		private void AddCells()
		{
			int top = buttonStart.Bottom + MARGIN;
			int left = MARGIN;
			for (int y = 0; y < cells.GetLength(0); y++)
			{
				for (int x = 0; x < cells.GetLength(1); x++)
				{
					Cell c = new Cell(x, y);

					c.Top = top;
					c.Left = left;
					c.Image = Image.FromFile("hidden.png");
					c.SizeMode = PictureBoxSizeMode.AutoSize;

					c.MouseDown += new MouseEventHandler(Cell_MouseDown);

					cells[y, x] = c;

					this.Controls.Add(c);

					left += CELL_WIDTH;
				}
				top += CELL_HEIGHT;
				left = MARGIN;
			}

		}

		private void InitBoard()
		{
			AddCells();
			SetCellsToMines(MINES);
			SetNumberOfAdjacentMines();
			//ShowBoard();
		}

		private void Cell_MouseDown(object sender, MouseEventArgs e)
		{
			if (isGameOver)
				return;

			Cell c = (Cell)sender;
			if (c == null || c.IsClicked)
				return;



			if (e.Button == MouseButtons.Right)
			{
				if (!c.Flag)
				{
					c.Image = Image.FromFile("flag.png");
					c.Flag = true;
				}
				else
				{
					c.Image = Image.FromFile("hidden.png");
					c.Flag = false;
				}
			}

			if (e.Button == MouseButtons.Left)
			{
				if (c.IsMine)
				{
					c.Image = Image.FromFile("mineclicked.png");
					labelWinOrLoose.Text = "LOST!";
					buttonStart.Enabled = true;
					isGameOver = true;
					foreach (Cell cell in cells)
					{

						if (cell == c)
							continue;

						if (cell.IsMine)
							cell.Image = Image.FromFile("mine.png");
					}
				}
				else
				{
					c.IsClicked = true;
					switch (c.Number)
					{
						case 1:
							c.Image = Image.FromFile("1.png");
							break;
						case 2:
							c.Image = Image.FromFile("2.png");
							break;
						case 3:
							c.Image = Image.FromFile("3.png");
							break;
						case 4:
							c.Image = Image.FromFile("4.png");
							break;
						case 5:
							c.Image = Image.FromFile("5.png");
							break;
						case 6:
							c.Image = Image.FromFile("6.png");
							break;
						case 7:
							c.Image = Image.FromFile("7.png");
							break;
						case 8:
							c.Image = Image.FromFile("8.png");
							break;
						case 0:
							c.Image = Image.FromFile("0.png");

							// Rakt ovanför
							if (IsOnBoard(c.X, c.Y - 1))
							{
								Cell temp = cells[c.Y - 1, c.X];
								Cell_MouseDown(temp, e);
							}

							// Ovanför till höger
							if (IsOnBoard(c.X + 1, c.Y - 1))
							{
								Cell temp = cells[c.Y - 1, c.X + 1];
								Cell_MouseDown(temp, e);
							}

							// Till höger
							if (IsOnBoard(c.X + 1, c.Y))
							{
								Cell temp = cells[c.Y, c.X + 1];
								Cell_MouseDown(temp, e);
							}

							// Nedanför till höger
							if (IsOnBoard(c.X + 1, c.Y - 1))
							{
								Cell temp = cells[c.Y - 1, c.X + 1];
								Cell_MouseDown(temp, e);
							}

							// Rakt nedanför
							if (IsOnBoard(c.X, c.Y + 1))
							{
								Cell temp = cells[c.Y + 1, c.X];
								Cell_MouseDown(temp, e);
							}

							// Nedanför till vänster
							if (IsOnBoard(c.X - 1, c.Y + 1))
							{
								Cell temp = cells[c.Y + 1, c.X - 1];
								Cell_MouseDown(temp, e);
							}

							// Till vänster
							if (IsOnBoard(c.X - 1, c.Y))
							{
								Cell temp = cells[c.Y, c.X - 1];
								Cell_MouseDown(temp, e);
							}

							// Ovanför till vänster
							if (IsOnBoard(c.X - 1, c.Y - 1))
							{
								Cell temp = cells[c.Y - 1, c.X - 1];
								Cell_MouseDown(temp, e);
							}

							break;

						default:
							break;
					}
				}

				if (IsWinner())
				{
					labelWinOrLoose.Text = "WINNER!";
					SetWinnerGameBoard();
				}
			}

		}

		private void SetCellsToMines(int mines)
		{
			//cells[0, 0].IsMine = true;

			for (int i = 0; i < mines; i++)
			{
				while (true)
				{
					int y = random.Next(BOARD_HEIGHT - 1);
					int x = random.Next(BOARD_WIDTH - 1);

					Cell c = cells[y, x];

					if (!c.IsMine)
					{
						c.IsMine = true;
						break;
					}
				}
			}
		}

		private int CountAdjectentMines(int x, int y)
		{
			int noOfMines = 0;

			// Rakt ovanför
			if (IsOnBoard(x, y - 1))
			{
				Cell c = cells[y - 1, x];
				if (c.IsMine)
					noOfMines++;
			}

			// Till höger
			if (IsOnBoard(x + 1, y))
			{
				Cell c = cells[y, x + 1];
				if (c.IsMine)
					noOfMines++;
			}

			// Rakt nedanför
			if (IsOnBoard(x, y + 1))
			{
				Cell c = cells[y + 1, x];
				if (c.IsMine)
					noOfMines++;
			}

			// Till vänster
			if (IsOnBoard(x - 1, y))
			{
				Cell c = cells[y, x - 1];
				if (c.IsMine)
					noOfMines++;
			}

			// Ovanför till höger
			if (IsOnBoard(x + 1, y - 1))
			{
				Cell c = cells[y - 1, x + 1];
				if (c.IsMine)
					noOfMines++;
			}

			// Nedanför till höger
			if (IsOnBoard(x + 1, y + 1))
			{
				Cell c = cells[y + 1, x + 1];
				if (c.IsMine)
					noOfMines++;
			}


			// Nedanför till vänster
			if (IsOnBoard(x - 1, y - 1))
			{
				Cell c = cells[y - 1, x - 1];
				if (c.IsMine)
					noOfMines++;
			}


			// Ovanför till vänster
			if (IsOnBoard(x - 1, y + 1))
			{
				Cell c = cells[y + 1, x - 1];
				if (c.IsMine)
					noOfMines++;
			}

			return noOfMines;
		}

		// Checks if the coordinates are on the board. 
		private bool IsOnBoard(int x, int y)
		{
			return (x >= 0 && y >= 0 && x < BOARD_WIDTH && y < BOARD_HEIGHT);
		}

		private void SetNumberOfAdjacentMines()
		{

			for (int y = 0; y < cells.GetLength(0); y++)
			{
				for (int x = 0; x < cells.GetLength(1); x++)
				{
					Cell c = cells[y, x];
					if (c.IsMine)
						c.Number = null;
					else
						c.Number = CountAdjectentMines(c.X, c.Y);
				}
			}

		}

		private void ShowBoard()
		{
			foreach (Cell cell in cells)
			{
				if (cell.IsMine)
					cell.Image = Image.FromFile("mine.png");
				if (cell.Number == 0)
					cell.Image = Image.FromFile("0.png");
				if (cell.Number == 1)
					cell.Image = Image.FromFile("1.png");
				if (cell.Number == 2)
					cell.Image = Image.FromFile("2.png");
				if (cell.Number == 3)
					cell.Image = Image.FromFile("3.png");
				if (cell.Number == 4)
					cell.Image = Image.FromFile("4.png");
				if (cell.Number == 5)
					cell.Image = Image.FromFile("5.png");
				if (cell.Number == 6)
					cell.Image = Image.FromFile("6.png");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private bool IsWinner()
		{
			int noOfNotClickedCells = 0;
			foreach (Cell cell in cells)
			{
				if (cell.IsClicked)
					noOfNotClickedCells++;
			}

			return noOfNotClickedCells == BOARD_HEIGHT * BOARD_WIDTH - MINES;
		}

		private void SetWinnerGameBoard()
		{
			foreach (Cell cell in cells)
			{
				cell.Enabled = false;
				if (cell.IsMine)
				{
					cell.Image = Image.FromFile("flag.png");
				}
				buttonStart.Enabled = true;
			}
		}

	}
}
