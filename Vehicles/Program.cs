using System.Runtime.CompilerServices;

namespace Vehicles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car(55, "Beige", 345, true);
			car.PrintInformation();
			Console.WriteLine();
			Boat boat = new Boat(45, "Grey", 45, false);
			boat.PrintInformation();
			Console.WriteLine();
			Airplane airplane = new Airplane(453, "White", 4562, true);
			airplane.PrintInformation();
			Console.WriteLine();
			Vehicle vehicle = new Vehicle(45, "Rosa", 23);
			vehicle.PrintInformation();
		}
	}

	class Vehicle
	{
		private int topSpeed;
		private string color;
		private int weight;

		public int TopSpeed
		{
			get { return topSpeed; }
		}
		public string Color
		{
			get { return color; }
		}
		public int Weight
		{
			get { return weight; }
		}

		public Vehicle(int topSpeed, string color, int weight)
		{
			this.topSpeed = topSpeed;
			this.color = color;
			this.weight = weight;
		}

		public void PrintInformation()
		{
			var name = GetType().Name;
			Console.WriteLine($"{name}\n Topfart = {topSpeed}\n Färg = {color}\n Vikt = {weight}");
		}
	}

	class Car : Vehicle
	{
		private bool hasFourWheelDrive;
		public bool HasFourWheelDrive
		{
			get { return hasFourWheelDrive; }
		}
		public Car(int topSpeed, string color, int weight, bool hasFourWheelDrive) : base(topSpeed, color, weight)
		{
			this.hasFourWheelDrive = hasFourWheelDrive;
		}

		public new void PrintInformation()
		{
			base.PrintInformation();
			Console.WriteLine($" Fyrhjulsdrift = {HasFourWheelDrive}");
		}
	}

	class Boat : Vehicle
	{
		private bool isMotorBoat;
		public bool IsMotorBoat
		{
			get { return isMotorBoat; }
		}

		public Boat(int topSpeed, string color, int weight, bool isMotorBoat) : base(topSpeed, color, weight)
		{
			this.isMotorBoat = isMotorBoat;
		}

		public new void PrintInformation()
		{
			base.PrintInformation();
			Console.WriteLine($" Motorbåt = {IsMotorBoat}");
		}
	}
	class Airplane : Vehicle
	{
		private bool hasJetEngines;
		public bool HasJetEngines
		{
			get { return hasJetEngines; }
		}

		public Airplane(int topSpeed, string color, int weight, bool hasJetEngines) : base(topSpeed, color, weight)
		{
			this.hasJetEngines = hasJetEngines;
		}

		public new void PrintInformation()
		{
			base.PrintInformation();
			Console.WriteLine($" Jetmotor = {HasJetEngines}");
		}
	}
}
