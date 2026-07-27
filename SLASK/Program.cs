namespace SLASK
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TrainTicket c = new TrainTicket(1300, "Göteborg");
			c.PrintPrice();
			c.PrintDestination();
			Console.ReadKey();
		}
	}

	abstract class Ticket
	{
		public int price;
		public string destination;

		public abstract void PrintPrice();

		public void PrintDestination() 
		{
			Console.WriteLine("Destination: " + destination);
		}
	}

	class TrainTicket : Ticket 
	{
		public TrainTicket(int price, string destination)
		{
			this.price = price;
			this.destination = destination;
		}
		public override void PrintPrice()
		{
			Console.WriteLine("Biljettpris: " + price);
		}
	}
}
