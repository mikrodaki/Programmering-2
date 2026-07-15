namespace School_register_2
{
	public class Student
	{
		private string name;
		public Student(string name)
		{
			this.name = name;
		}

		public string Name {  get { return name; } }

		public override string ToString()
		{
			return Name;
		}
	}
}
