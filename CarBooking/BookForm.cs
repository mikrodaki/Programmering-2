namespace CarBooking
{
    public partial class BookForm : Form
    {
        List<Car> cars;
        List<Booking> bookings;
        public BookForm(List<Car> cars, List<Booking> bookings)
        {
            InitializeComponent();
            this.cars = cars;
            this.bookings = bookings;
            comboBox1.DataSource = cars;
            Car selectedCar = (Car)comboBox1.SelectedItem;
            pictureBox1.Image = Image.FromFile(selectedCar.File);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car selectedCar = (Car)comboBox1.SelectedItem;
            pictureBox1.Image = Image.FromFile(selectedCar.File);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Car selectedCar = (Car)comboBox1.SelectedItem;
            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;
            int carId = cars.IndexOf(selectedCar);
            bookings.Add(new Booking(carId, fromDate, toDate));
            this.Close();
        }
    }
}
