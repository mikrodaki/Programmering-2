namespace Minesweeper
{
	public partial class Form1 : Form
	{
		private readonly int BOARD_WIDTH = 18;
		private readonly int BOARD_HEIGHT = 16;
		private readonly int CELL_WIDTH = 47;
		private readonly int CELL_HEIGHT = 47;
		private readonly int MINES = 40;
		private Cell[,] cells;
		private Random random = new Random();
		public Form1()
		{
			InitializeComponent();
			cells = new Cell[BOARD_HEIGHT, BOARD_WIDTH];
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			InitBoard();
		}

		private void AddCells()
		{
			int top = 50;
			int left = 15;
			for (int row = 0; row < cells.GetLength(0); row++)
			{
				for (int col = 0; col < cells.GetLength(1); col++)
				{
					Cell c = new Cell(row, col);

					c.Top = top;
					c.Left = left;
					c.Image = Image.FromFile("hidden.png");
					c.SizeMode = PictureBoxSizeMode.AutoSize;

					c.MouseDown += new MouseEventHandler(Cell_MouseDown);

					cells[row, col] = c;

					this.Controls.Add(c);

					left += CELL_WIDTH;
				}
				top += CELL_HEIGHT;
				left = 15;
			}
		}

		private void InitBoard()
		{
			AddCells();
			SetCellsToMines(MINES);
		}

		private void Cell_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void SetCellsToMines(int mines)
		{
			for (int i = 0; i < mines; i++)
			{
				while (true)
				{
					int row = random.Next(BOARD_HEIGHT - 1);
					int col = random.Next(BOARD_WIDTH - 1);

					Cell c = cells[row, col];

					if (!c.IsMine)
					{
						c.IsMine = true;
						break;
					}
				}
			}
		}
	}
}
