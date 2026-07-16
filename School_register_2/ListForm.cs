namespace School_register_2
{
	public partial class ListForm : Form
	{
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

		public ListForm(string listName, string schoolName, List<GradeLevel> gradeLevels)
		{
			InitializeComponent();
			this.Text = schoolName;
			label1.Text = listName;
			foreach(GradeLevel gradeLevel in gradeLevels) 
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
