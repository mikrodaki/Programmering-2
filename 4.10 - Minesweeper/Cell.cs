namespace Minesweeper
{
	public class Cell : PictureBox
	{
		public int X {  get; set; }
		public int Y { get; set; }
		public bool Flag {  get; set; }
		public bool IsClicked {  get; set; }
		public bool IsMine {  get; set; }
		public int? Number {  get; set; }

		public Cell(int x, int y)
		{
			X = x; 
			Y = y;
			Flag = false;
			IsClicked = false;
			IsMine = false;
			Number = null;
		}

	}
}
