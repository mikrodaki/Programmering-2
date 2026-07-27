namespace Polymorfism
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Super> list = new List<Super>();
			list.Add(new Sub1());
			list.Add(new Sub2());
			list.Add(new Super());

			foreach (var element in list)
				element.Print();

			Console.ReadKey();
		}
	}

	class Super
	{
		public virtual void Print()
		{
			Console.WriteLine("Superklass");
		}

}

	class Sub1 : Super
	{
		public override void Print()
		{
			Console.WriteLine("Subklass 1");
		}
	}

	class Sub2 : Super
	{
		public override void Print()
		{
			Console.WriteLine("Subklass 2");
		}
	}
}
