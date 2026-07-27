namespace Sliding_puzzle
{
	internal class Piece : PictureBox
	{
		private int x;
		private int y;
		private int? number;

		public int X
		{
			get
			{
				return x;
			}
			set
			{
				x = value;
			}
		}
		public int Y
		{
			get 
			{
				return y;
			}
			set 
			{
				y = value;
			}
		}
		public int? Number
		{
			get 
			{
				return number;
			}
			set 
			{ 
				number = value;
			}
		}

		public Piece(int x, int y, int? number)
		{
			this.x = x;
			this.y = y; 
			this.number = number;
		}
	}
}
