namespace Memory
{
    public partial class Form1 : Form
    {
        List<PictureBox> pictures = new List<PictureBox>();
        Random rnd = new Random();
        List<bool> cardTurned = new List<bool>();
        public Form1()
        {
            InitializeComponent();
            InitBoard();
            ShuffleCardsFisherYates();
            ShowCards();
            string text = "";
            foreach (var picture in pictures)
            {
                text += picture.Name + ", ";
            }
            MessageBox.Show(text);

        }

        private void ShowCards()
        {
            int y = 20;
            int x = 20;
            for (int i = 0; i < pictures.Count; i++)
            {
                if (i % 4 == 0 && i != 0)
                {
                    y += 180;
                    x = 20;
                }
                var picture = pictures[i];
                picture.Top = y;
                picture.Left = x;
                x += 180;
                this.Controls.Add(picture);
            }
        }
        private void InitBoard()
        {
            for (int i = 0; i < 16; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Height = 150;
                picture.Width = 150;
                picture.Image = Image.FromFile("back.png");
                picture.Name = (i + 1).ToString();
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Click += new EventHandler(Picture_Clicked);
                pictures.Add(picture);
            }
        }

        private void Picture_Clicked(object? sender, EventArgs e)
        {
            var picture = (PictureBox)sender;
            
        }

        private void ShuffleCards()
        {
            List<PictureBox> shuffledPictures = new List<PictureBox>();
            int numberOfCardsInDeck = pictures.Count;
            for (int i = 0; i < numberOfCardsInDeck; i++)
            {
                int randomIndex = rnd.Next(pictures.Count);
                PictureBox randomPicture = pictures[randomIndex];
                shuffledPictures.Add(randomPicture);
                pictures.Remove(randomPicture);
            }
            pictures.Clear();
            foreach (PictureBox picture in shuffledPictures)
            {
                pictures.Add((PictureBox)picture);
            }
        }

        private void ShuffleCards2()
        {
            List<PictureBox> shuffledPictures = new List<PictureBox>();

            while (pictures.Count > 0)
            {
                int randomIndex = rnd.Next(pictures.Count);
                shuffledPictures.Add(pictures[randomIndex]);
                pictures.RemoveAt(randomIndex);
            }

            pictures.AddRange(shuffledPictures);
        }

        private void ShuffleCardsFisherYates()
        {
            for (int i = pictures.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);

                PictureBox temp = pictures[i];
                pictures[i] = pictures[j];
                pictures[j] = temp;
            }
        }
    }
}
