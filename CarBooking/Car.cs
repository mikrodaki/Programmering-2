namespace CarBooking
{
    public class Car
    {
        public string LicensePlate { get; }
        public string File { get; }

        public Car(string licensePlate, string file)
        {
            LicensePlate = licensePlate;
            File = file;
        }

        public override string ToString()
        {
            return LicensePlate;
        }
    }
}
