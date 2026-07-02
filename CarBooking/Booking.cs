namespace CarBooking
{
    public class Booking
    {
        public int CarId { get; set; }
        public DateTime To { get; set; }
        public DateTime From { get; set; }

        public Booking(int carId, DateTime from, DateTime to)
        {
            CarId = carId;
            To = to;
            From = from;
        }
    }
}
