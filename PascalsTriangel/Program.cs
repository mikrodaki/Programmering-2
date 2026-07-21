using App.IO;

namespace PascalsTriangel
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = Console.WindowWidth / 2;
			int y = 5;
			List<int> previousRow = new List<int>();

			int numberOfRows = ConsoleHelper.ReadInt("Ange höjd på Pascals triangel (1-20): ", 1, 20);
			Console.Clear();

			previousRow.Add(1);

			for (int row = 1; row < numberOfRows + 1; row++)
			{
				Console.SetCursorPosition(x, y);
				List<int> currentRow = GetCurrentRow(previousRow, row);
				int tempX = x;
				for (int col = 0; col < currentRow.Count; col++)
				{
					Console.SetCursorPosition(tempX, y);
					Console.Write(currentRow[col]);
					tempX += 6;
				}
				previousRow = currentRow;
				y++;
				x -= 3;
			}
			Console.CursorVisible = false;
			Console.ReadKey();
		}

		private static List<int> GetCurrentRow(List<int> previousRow, int previousRowNumber)
		{
			List<int> currentRow = new List<int>();
			currentRow.Add(previousRow[0]);
			for (int i = 0; i < previousRow.Count - 1; i++)
			{
				currentRow.Add(previousRow[i] + previousRow[i + 1]);
			}
			if (previousRowNumber != 1)
				currentRow.Add(previousRow[0]);
			return currentRow;
		}
	}
}
