using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_register_2
{
	public partial class ListForm : Form
	{
		string listName;
		public ListForm(string listName)
		{
			InitializeComponent();
			this.Text = listName;
		}

		public ListForm(string listName, string schoolName, List<Student> students)
		{
			InitializeComponent();
			this.Text = schoolName;
			label1.Text = listName;
			foreach (Student student in students)
			{
				listBox1.Items.Add(student);
			}
		}

		public ListForm(string listName, string schoolName, List<SchoolClass> schoolClasses)
		{
			InitializeComponent();
			this.Text = schoolName;
			label1.Text = listName;
			foreach (SchoolClass schoolClass in schoolClasses)
			{
				foreach (Student student in schoolClass.Students)
				{
					listBox1.Items.Add(student);
				}
			}
		}

		public ListForm(string listName, string schoolName, School school)
		{
			InitializeComponent();
			this.Text = schoolName;
			label1.Text = listName;
			foreach(GradeLevel gradeLevel in school.GradeLevels) 
			{ 
				foreach(SchoolClass schoolClass in gradeLevel.SchoolClasses) 
				{
					foreach (Student student in schoolClass.Students)
					{
						listBox1.Items.Add(student);
					}
				}
			}
		}
	}
}
