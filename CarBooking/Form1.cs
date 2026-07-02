using System.Data;

namespace CarBooking
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>
        {
            new Car("ABC123", "Car1.png"),
            new Car("EFD123", "Car2.png"),
            new Car("KJT123", "Car3.png"),
            new Car("LOP123", "Car4.png"),
        };

        List<Booking> bookings = new List<Booking>();

        DataTable dataTable = new DataTable();


        public Form1()
        {
            InitializeComponent();

            DataColumn columnSpec = new DataColumn();
            columnSpec.DataType = typeof(string);
            columnSpec.ColumnName = "Fordon";
            dataTable.Columns.Add(columnSpec);

            DataColumn columnFrom = new DataColumn();
            columnFrom.DataType = typeof(DateTime);
            columnFrom.ColumnName = "Från";
            dataTable.Columns.Add(columnFrom);

            DataColumn columnTo = new DataColumn();
            columnTo.DataType = typeof(DateTime);
            columnTo.ColumnName = "Till";
            dataTable.Columns.Add(columnTo);

            dataGridView1.DataSource = dataTable;


        }

        private void bokaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form bookForm = new BookForm(cars, bookings);
            bookForm.ShowDialog();
        }

        private void UpdateBookings()
        {
            dataTable.Rows.Clear();
            foreach (Booking booking in bookings)
            {
                Car car = cars[booking.CarId];
                dataTable.Rows.Add(car.LicensePlate, booking.From.ToShortDateString(), booking.To.ToShortDateString());

            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            UpdateBookings();
        }
    }
}
