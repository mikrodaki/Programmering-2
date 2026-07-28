# Sliding Puzzle – kodförklaring

## Grundidé

- `pieces[,]` håller reda på var brickorna finns i spelplanen.
- `Left` och `Top` bestämmer var brickornas bilder visas.
- `currentX` och `currentY` anger den tomma rutans position.

## Hela programmet med kommentarer

```csharp

namespace Sliding_puzzle
{
	public partial class Form1 : Form
	{
		// Ett gemensamt Random-objekt används för all slumpning i programmet.
		private static Random random = new Random();

		/*
		 * Tvådimensionell array som representerar spelplanen.
		 *
		 * Första indexet är rad (Y).
		 * Andra indexet är kolumn (X).
		 *
		 * Exempel:
		 * pieces[2, 3] betyder rutan på rad 2 och kolumn 3.
		 *
		 * Arrayen håller reda på vilken Piece som finns på varje position.
		 * PictureBoxarnas Left och Top avgör samtidigt var brickorna visas
		 * grafiskt på formuläret.
		 */
		private Piece[,] pieces;

		/*
		 * Koordinaterna för den tomma rutan i arrayen.
		 *
		 * currentX = kolumnen för den tomma rutan.
		 * currentY = raden för den tomma rutan.
		 */
		private int currentX;
		private int currentY;

		// Innehåller de slumpade talen 1–15 om InitRandomNumbers används.
		private List<int> randomNumbers = new List<int>();

		// Talen i löst ordning. Används när spelet först skapas löst
		// och därefter blandas genom giltiga drag.
		private List<int> solvedList = new List<int>
		{
			1, 2, 3, 4,
			5, 6, 7, 8,
			9, 10, 11, 12,
			13, 14, 15
		};

		// Blir true när pusslet är löst.
		// Då ignoreras fortsatta tangenttryckningar.
		private bool gameOver = false;

		// Storleken på varje pusselbit i pixlar.
		private const int pieceWidth = 137;
		private const int pieceHeight = 137;

		// Spelplanens storlek i antal rutor.
		private const int boardWidth = 4;
		private const int boardHeight = 4;

		// Konstanter som representerar de fyra rörelseriktningarna.
		private const int UP = 0;
		private const int RIGHT = 1;
		private const int DOWN = 2;
		private const int LEFT = 3;

		public Form1()
		{
			InitializeComponent();

			// Skapar en 4 × 4-array.
			// Själva arrayen finns nu, men rutorna innehåller ännu inga
			// Piece-objekt.
			pieces = new Piece[boardHeight, boardWidth];

			// Anpassar formulärets storlek efter spelplanens storlek.
			ClientSize = new Size(
				pieceWidth * boardWidth,
				pieceHeight * boardHeight);

			// Den tomma rutan börjar längst ned till höger.
			currentX = boardWidth - 1;
			currentY = boardHeight - 1;

			/*
			 * InitRandomNumbers skulle skapa en helt slumpmässig
			 * ordning av talen 1–15.
			 *
			 * Den används inte nu eftersom spelet i stället börjar
			 * löst och blandas genom giltiga drag.
			 */
			// InitRandomNumbers();

			// Skapar alla Piece-objekt och placerar dem i löst ordning.
			InitPieces();

			/*
			 * Blandar spelplanen genom att göra 100 slumpmässiga,
			 * tillåtna spelrörelser från den lösta positionen.
			 *
			 * Eftersom blandningen görs med vanliga spelrörelser
			 * är pusslet alltid möjligt att lösa.
			 */
			for (int i = 0; i < 100; i++)
			{
				RandomMove(random.Next(4));
			}
		}

		/*
		 * Skapar alla Piece-objekt och placerar dem i arrayen.
		 *
		 * De första 15 rutorna får talen 1–15 i löst ordning.
		 * Den sista rutan längst ned till höger får Number = null
		 * och fungerar som den tomma rutan.
		 */
		private void InitPieces()
		{
			// Anger vilket tal från solvedList som ska användas.
			int cardNumber = 0;

			// Går igenom arrayen rad för rad.
			for (int row = 0; row < pieces.GetLength(0); row++)
			{
				for (int col = 0; col < pieces.GetLength(1); col++)
				{
					// Kontrollerar om detta är den sista rutan
					// längst ned till höger.
					if (row == pieces.GetLength(0) - 1 &&
						col == pieces.GetLength(1) - 1)
					{
						// Den sista biten har inget nummer eller någon bild.
						// Den representerar den tomma rutan.
						Piece piece = new Piece(col, row, null);

						// Lägger den tomma biten i arrayen.
						pieces[row, col] = piece;
					}
					else
					{
						// Skapar en numrerad pusselbit på aktuell
						// kolumn och rad.
						Piece piece =
							new Piece(col, row, solvedList[cardNumber]);

						// Omvandlar brickans position i arrayen till
						// en position i pixlar på formuläret.
						piece.Left = piece.X * pieceWidth;
						piece.Top = piece.Y * pieceHeight;

						// PictureBoxen får samma storlek som bilden.
						piece.SizeMode = PictureBoxSizeMode.AutoSize;

						// Läser in den bildfil som hör till brickans nummer.
						piece.Image =
							Image.FromFile(piece.Number + ".png");

						// Lägger PictureBoxen på formuläret så att den syns.
						this.Controls.Add(piece);

						// Lägger samma Piece-objekt på rätt plats i arrayen.
						pieces[row, col] = piece;

						// Går vidare till nästa nummer i solvedList.
						cardNumber++;
					}
				}
			}
		}

		/*
		 * Skapar en lista med talen 1–15 i slumpmässig ordning
		 * utan några dubletter.
		 *
		 * Metoden används inte i den nuvarande versionen eftersom
		 * spelplanen i stället blandas genom giltiga rörelser.
		 */
		private void InitRandomNumbers()
		{
			// Tömmer listan om metoden skulle anropas flera gånger.
			randomNumbers.Clear();

			// Det ska finnas ett nummer för alla rutor utom den tomma.
			for (int i = 0; i < pieces.Length - 1; i++)
			{
				// Fortsätter slumpa tills ett oanvänt nummer hittas.
				while (true)
				{
					// Slumpar ett tal mellan 1 och 15.
					int randomNumber = random.Next(1, 16);

					// Lägger endast till talet om det inte redan används.
					if (!randomNumbers.Contains(randomNumber))
					{
						randomNumbers.Add(randomNumber);
						break;
					}
				}
			}
		}

		/*
		 * Händelsehanterare som körs när användaren trycker på en tangent.
		 *
		 * Piltangenten anger åt vilket håll en numrerad bricka ska röra sig.
		 * Brickan byter plats med den tomma rutan i arrayen och flyttas
		 * därefter grafiskt på formuläret.
		 *
		 * currentX och currentY följer alltid den tomma rutan,
		 * inte den numrerade brickan.
		 */
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			// Inga fler drag tillåts när pusslet är färdigt.
			if (gameOver)
				return;

			switch (e.KeyCode)
			{
				case Keys.Up:

					/*
					 * När spelaren trycker upp ska brickan under
					 * den tomma rutan flyttas upp.
					 *
					 * Därför kontrolleras positionen:
					 * currentY + 1.
					 */
					if (IsWithinBounds(currentX, currentY + 1))
					{
						/*
						 * Byter plats i arrayen mellan den tomma rutan
						 * och brickan under den.
						 *
						 * Efter bytet finns den numrerade brickan på den
						 * tomma rutans tidigare position.
						 */
						Swap(
							ref pieces[currentY, currentX],
							ref pieces[currentY + 1, currentX]);

						/*
						 * Flyttar den numrerade brickans PictureBox uppåt.
						 *
						 * Efter Swap finns brickan i:
						 * pieces[currentY, currentX].
						 */
						MovePiece(pieces[currentY, currentX], UP);

						// Den tomma rutan har flyttats en rad nedåt.
						currentY++;
					}
					else
					{
						// Draget går utanför spelplanen.
						return;
					}
					break;

				case Keys.Down:

					/*
					 * När spelaren trycker ned ska brickan ovanför
					 * den tomma rutan flyttas ned.
					 */
					if (IsWithinBounds(currentX, currentY - 1))
					{
						// Byter den tomma rutan med brickan ovanför.
						Swap(
							ref pieces[currentY, currentX],
							ref pieces[currentY - 1, currentX]);

						// Flyttar den numrerade brickan grafiskt nedåt.
						MovePiece(pieces[currentY, currentX], DOWN);

						// Den tomma rutan har flyttats en rad uppåt.
						currentY--;
					}
					else
					{
						return;
					}
					break;

				case Keys.Left:

					/*
					 * När spelaren trycker vänster ska brickan till
					 * höger om den tomma rutan flyttas åt vänster.
					 */
					if (IsWithinBounds(currentX + 1, currentY))
					{
						// Byter den tomma rutan med brickan till höger.
						Swap(
							ref pieces[currentY, currentX],
							ref pieces[currentY, currentX + 1]);

						// Flyttar den numrerade brickan grafiskt åt vänster.
						MovePiece(pieces[currentY, currentX], LEFT);

						// Den tomma rutan har flyttats en kolumn åt höger.
						currentX++;
					}
					else
					{
						return;
					}
					break;

				case Keys.Right:

					/*
					 * När spelaren trycker höger ska brickan till
					 * vänster om den tomma rutan flyttas åt höger.
					 */
					if (IsWithinBounds(currentX - 1, currentY))
					{
						// Byter den tomma rutan med brickan till vänster.
						Swap(
							ref pieces[currentY, currentX],
							ref pieces[currentY, currentX - 1]);

						// Flyttar den numrerade brickan grafiskt åt höger.
						MovePiece(pieces[currentY, currentX], RIGHT);

						// Den tomma rutan har flyttats en kolumn åt vänster.
						currentX--;
					}
					else
					{
						return;
					}
					break;

				default:
					// Alla andra tangenter ignoreras.
					return;
			}

			// Efter ett giltigt drag kontrolleras om pusslet är löst.
			if (IsCompleted())
			{
				// Stoppar fortsatta drag.
				gameOver = true;

				// Visar ett meddelande om att spelet är färdigt.
				MessageBox.Show("Voff!");
			}
		}

		/*
		 * Byter plats på två Piece-referenser.
		 *
		 * När arrayens två rutor skickas med ref byts objekten
		 * direkt inne i arrayen.
		 */
		private void Swap(ref Piece a, ref Piece b)
		{
			Piece temp = a;
			a = b;
			b = temp;
		}

		/*
		 * Kontrollerar om koordinaterna x och y ligger inom spelplanen.
		 *
		 * Returnerar true om positionen är giltig.
		 * Returnerar false om den ligger utanför arrayen.
		 */
		private bool IsWithinBounds(int x, int y)
		{
			return
				y >= 0 &&
				y < pieces.GetLength(0) &&
				x >= 0 &&
				x < pieces.GetLength(1);
		}

		/*
		 * Flyttar en numrerad bricks PictureBox i angiven riktning.
		 *
		 * dx anger förändringen i sidled för varje steg.
		 * dy anger förändringen i höjdled för varje steg.
		 *
		 * Brickan flyttas en pixel i taget tills den har flyttats
		 * en hel brickbredd eller brickhöjd.
		 */
		private void MovePiece(Piece piece, int direction)
		{
			// Ingen rörelse från början.
			int dx = 0;
			int dy = 0;

			// Bestämmer åt vilket håll brickan ska flyttas.
			switch (direction)
			{
				case UP:
					dy = -1;
					break;

				case RIGHT:
					dx = 1;
					break;

				case DOWN:
					dy = 1;
					break;

				case LEFT:
					dx = -1;
					break;
			}

			int distance;

			// Vid en vågrät rörelse används brickans bredd.
			if (dx != 0)
				distance = pieceWidth;

			// Vid en lodrät rörelse används brickans höjd.
			else
				distance = pieceHeight;

			// Flyttar PictureBoxen en pixel i taget.
			for (int i = 0; i < distance; i++)
			{
				piece.Left += dx;
				piece.Top += dy;
			}
		}

		/*
		 * Kontrollerar om pusslet är löst.
		 *
		 * Arrayen gås igenom från vänster till höger och uppifrån nedåt.
		 * Varje numrerad bricka måste ligga i ordningen 1–15.
		 *
		 * När alla 15 nummer har kontrollerats returneras true.
		 * Den sista rutan behöver inte jämföras eftersom den då måste
		 * vara den tomma rutan med Number = null.
		 */
		private bool IsCompleted()
		{
			// Numret som förväntas på aktuell position.
			int expectedNumber = 1;

			for (int row = 0; row < pieces.GetLength(0); row++)
			{
				for (int col = 0; col < pieces.GetLength(1); col++)
				{
					// Hämtar den Piece som ligger på aktuell position.
					Piece a = pieces[row, col];

					/*
					 * På en 4 × 4-plan är pieces.Length 16.
					 *
					 * När nummer 1–15 har kontrollerats har
					 * expectedNumber blivit 16. Då är pusslet löst
					 * och den sista tomma rutan behöver inte jämföras.
					 */
					if (expectedNumber == pieces.Length)
						return true;

					// Om brickans nummer inte är det förväntade
					// ligger minst en bricka fel.
					if (a.Number != expectedNumber)
						return false;

					// Nästa position ska innehålla nästa nummer.
					expectedNumber++;
				}
			}

			// Om hela kontrollen passerades är pusslet löst.
			return true;
		}

		/*
		 * Utför ett slumpmässigt spelardrag vid blandningen.
		 *
		 * Metoden använder samma regler som tangenthanteraren,
		 * men gör ingen kontroll av om pusslet är löst.
		 *
		 * Ett ogiltigt slumpat drag ignoreras. Det innebär att
		 * 100 anrop inte nödvändigtvis ger exakt 100 utförda drag.
		 */
		private void RandomMove(int direction)
		{
			switch (direction)
			{
				case UP:

					// Brickan under den tomma rutan kan flyttas upp.
					if (IsWithinBounds(currentX, currentY + 1))
					{
						Swap(
							ref pieces[currentY, currentX],
							ref pieces[currentY + 1, currentX]);

						MovePiece(pieces[currentY, currentX], UP);

						// Den tomma rutan hamnar en rad längre ned.
						currentY++;
					}
					else
					{
						return;
					}
					break;

				case DOWN:

					// Brickan ovanför den tomma rutan kan flyttas ned.
					if (IsWithinBounds(currentX, currentY - 1))
					{
						Swap(
							ref pieces[currentY, currentX],
							ref pieces[currentY - 1, currentX]);

						MovePiece(pieces[currentY, currentX], DOWN);

						// Den tomma rutan hamnar en rad längre upp.
						currentY--;
					}
					else
					{
						return;
					}
					break;

				case LEFT:

					// Brickan till höger om den tomma rutan
					// kan flyttas åt vänster.
					if (IsWithinBounds(currentX + 1, currentY))
					{
						Swap(
							ref pieces[currentY, currentX],
							ref pieces[currentY, currentX + 1]);

						MovePiece(pieces[currentY, currentX], LEFT);

						// Den tomma rutan hamnar en kolumn åt höger.
						currentX++;
					}
					else
					{
						return;
					}
					break;

				case RIGHT:

					// Brickan till vänster om den tomma rutan
					// kan flyttas åt höger.
					if (IsWithinBounds(currentX - 1, currentY))
					{
						Swap(
							ref pieces[currentY, currentX],
							ref pieces[currentY, currentX - 1]);

						MovePiece(pieces[currentY, currentX], RIGHT);

						// Den tomma rutan hamnar en kolumn åt vänster.
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
```