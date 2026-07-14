using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_register
{
	internal class School
	{
		private string name;
		public List<Year> years;
		public School(string name)
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
