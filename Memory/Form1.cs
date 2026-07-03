namespace Memory
{
    public partial class Form1 : Form
    {
        List<PictureBox> pictures = new List<PictureBox>();
        Random rnd = new Random();
        List<bool> cardTurned = new List<bool>();
        PictureBox currentCard = null;
        PictureBox previousCard = null;

        public Form1()
        {
            InitializeComponent();
            InitBoard();
            ShuffleCardsFisherYates();
            ShowCards();
            for (int i = 0; i < 16; i++)
            {
                cardTurned.Add(false);
            }
        }


        private void SetCurrentCard(PictureBox newCard)
        {
            previousCard = currentCard;
            currentCard = newCard;
        }
        private int ConnectImageToCard(int name)
        {
            if (name == 1 || name == 2)
            {
                return 0;
            }
            if (name == 3 || name == 4)
            {
                return 1;
            }
            if (name == 5 || name == 6)
            {
                return 2;
            }
            if (name == 7 || name == 8)
            {
                return 3;
            }
            if (name == 9 || name == 10)
            {
                return 4;
            }
            if (name == 11 || name == 12)
            {
                return 5;
            }
            if (name == 13 || name == 14)
            {
                return 6;
            }
            if (name == 15 || name == 16)
            {
                return 7;
            }
            return -1;
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
            if (sender is not PictureBox picture)
                return;

            int cardNumber = Convert.ToInt32(picture.Name); // 1–16
            int index = cardNumber - 1;                     // 0–15

            cardTurned[index] = !cardTurned[index];

            if (cardTurned[index])
            {
                picture.Image = Image.FromFile(ConnectImageToCard(Convert.ToInt32(picture.Name)) + ".png");
                SetCurrentCard(picture);
                if (previousCard != null)
                {
                    int image1 = ConnectImageToCard(Convert.ToInt32(previousCard.Name));
                    int image2 = ConnectImageToCard(Convert.ToInt32(currentCard.Name));

                    if (image1 == image2)
                    {
                        MessageBox.Show("Par!");
                        picture.Visible = false;
                        previousCard.Visible = false;
                        currentCard = null;
                        previousCard = null;
                        
                    }
                    else
                    {
                        MessageBox.Show("Inte par!");
                        currentCard.Image = Image.FromFile("back.png");
                        previousCard.Image = Image.FromFile("back.png");
                        currentCard = null;
                        previousCard = null;
                    }
                }
            }
            else
            {
                picture.Image = Image.FromFile("back.png");
            }
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

        //private void ShuffleCards()
        //{
        //    List<PictureBox> shuffledPictures = new List<PictureBox>();
        //    int numberOfCardsInDeck = pictures.Count;
        //    for (int i = 0; i < numberOfCardsInDeck; i++)
        //    {
        //        int randomIndex = rnd.Next(pictures.Count);
        //        PictureBox randomPicture = pictures[randomIndex];
        //        shuffledPictures.Add(randomPicture);
        //        pictures.Remove(randomPicture);
        //    }
        //    pictures.Clear();
        //    foreach (PictureBox picture in shuffledPictures)
        //    {
        //        pictures.Add((PictureBox)picture);
        //    }
        //}

        //private void ShuffleCards2()
        //{
        //    List<PictureBox> shuffledPictures = new List<PictureBox>();

        //    while (pictures.Count > 0)
        //    {
        //        int randomIndex = rnd.Next(pictures.Count);
        //        shuffledPictures.Add(pictures[randomIndex]);
        //        pictures.RemoveAt(randomIndex);
        //    }

        //    pictures.AddRange(shuffledPictures);
        //}

    }
}
