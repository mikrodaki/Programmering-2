using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_register
{
	internal class Year
	{
		private string name;
		public List<GradeLevel> gradeLevels;
		public Year(string name)
		{
			this.name = name;
		}

		public string Name 
		{  
			get 
			{ 
				return this.name; 
			} 
		}
	}
}
