using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_register
{
	internal class GradeLevel
	{
		private string name;
		public List<Student> students;
		public GradeLevel(string name)
		{
			this.name = name;
		}

		public string Name 
		{ 
			get 
			{ 
				return name; 
			} 
		}
	}
}
