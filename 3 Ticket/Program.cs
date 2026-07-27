namespace _3_Ticket
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Ticket ticket = new Ticket(200);
			//TrainTicket trainTicket = new TrainTicket(450);
			//ticket.PrintPrice();
			//trainTicket.PrintPrice();
			//Ticket ticket = new Ticket(200);
			//ticket.PrintPrice();
			//ticket = new TrainTicket(450);
			//ticket.PrintPrice();
			Ticket trainTicket = new TrainTicket(45);
			trainTicket.PrintPrice();
			Ticket speedTrainTicket = new SpeedTrainTicket(234);
			speedTrainTicket.PrintPrice();
		}
	}

	class Ticket 
	{
		protected int price;

		public Ticket(int price)
		{
			this.price = price;
		}

		public virtual void PrintPrice() 
		{
			Console.WriteLine("Biljettpris: " + price + " kr");
		}
	}

	class TrainTicket : Ticket 
	{
		public TrainTicket(int price) : base (price)
		{
						
		}

		public override void PrintPrice() 
		{
			Console.WriteLine("Biljettpris tåg: " + price + " kr");
		}
	}

	class SpeedTrainTicket : TrainTicket
	{
		public SpeedTrainTicket(int price) : base(price)
		{

		}
	}
}
