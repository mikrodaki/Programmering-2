using System.Xml.Linq;

namespace School_register_2
{
	public class SchoolClass
	{
		private string name;
		private List<Student> students = new List<Student>();

		public SchoolClass(string name)
		{
			this.name = name;
		}

		public List<Student> Students { get { return students; } }

		public string Name { get { return name; } }

		public override string ToString()
		{
			return Name;
		}
	}
}
