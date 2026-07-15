namespace School_register_2
{
	public class School
	{
		private string name;
		private List<GradeLevel> gradeLevels = new List<GradeLevel>();

		public School(string name)
		{
			this.name = name;
		}

		public List<GradeLevel> GradeLevels
		{
			get
			{
				return gradeLevels;
			}
		}

		public string Name { get { return name; } }
	}
}
