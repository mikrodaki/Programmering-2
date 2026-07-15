namespace School_register_2
{
	public class GradeLevel
	{
		private string name;
		private List<SchoolClass> schoolClasses = new List<SchoolClass>();
		public GradeLevel(string name)
		{
			this.name = name;
		}

		public string Name {  get { return name; } }

		public List<SchoolClass> SchoolClasses { get { return schoolClasses; } }

		// Gör så att Name visas i ListBoxen
		public override string ToString()
		{
			return Name;
		}
	}
}
