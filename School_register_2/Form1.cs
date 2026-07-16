using System.Windows.Forms;

namespace School_register_2
{
	public partial class Form1 : Form
	{

		School school = new School("Testskolan");
		public Form1()
		{
			InitializeComponent();
			this.Text = school.Name;
			PopulateLists();
			PopulateForm();
		}

		private void listBoxGradeLevels_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBoxSchoolClasses.Items.Clear();
			listBoxStudents.Items.Clear();

			if (listBoxGradeLevels.SelectedItem != null)
			{
				var gradeLevel = (GradeLevel)listBoxGradeLevels.SelectedItem;
				foreach (SchoolClass schoolClass in gradeLevel.SchoolClasses)
				{
					listBoxSchoolClasses.Items.Add(schoolClass);
				}
			}
		}

		private void listBoxSchoolClasses_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBoxStudents.Items.Clear();

			if (listBoxSchoolClasses.SelectedItem != null)
			{
				SchoolClass schoolClass = (SchoolClass)listBoxSchoolClasses.SelectedItem;
				foreach (Student student in schoolClass.Students)
				{
					listBoxStudents.Items.Add(student);
				}
			}
		}

		private void buttonNewGradeLevel_Click(object sender, EventArgs e)
		{
			string name = textBoxGradeLevel.Text;

			if (!string.IsNullOrWhiteSpace(name))
			{
				GradeLevel gradeLevel = new GradeLevel(name);

				school.GradeLevels.Add(gradeLevel);
				listBoxGradeLevels.Items.Add(gradeLevel);

				textBoxGradeLevel.Clear();
			}
		}

		private void buttonCreateNewSchoolClass_Click(object sender, EventArgs e)
		{
			string name = textBoxSchoolClass.Text;
			if (!string.IsNullOrEmpty(name))
			{
				if (listBoxGradeLevels.SelectedIndex != -1)
				{
					// Hämta GradeLevel-objektet från listboxen och inte listan. 
					GradeLevel gradeLevel = (GradeLevel)listBoxGradeLevels.SelectedItem;

					SchoolClass schoolClass = new SchoolClass(name);

					gradeLevel.SchoolClasses.Add(schoolClass);
					listBoxSchoolClasses.Items.Add(schoolClass);

					textBoxSchoolClass.Clear();
				}
				else
				{
					MessageBox.Show("Du måste välja en årskurs");
				}
			}
		}

		private void buttonCreateNewStudent_Click(object sender, EventArgs e)
		{
			string name = textBoxStudent.Text;
			if (!string.IsNullOrEmpty(name))
			{
				if (listBoxSchoolClasses.SelectedIndex != -1)
				{
					SchoolClass schoolClass = (SchoolClass)listBoxSchoolClasses.SelectedItem;

					Student student = new Student(name);

					schoolClass.Students.Add(student);
					listBoxStudents.Items.Add(student);

					textBoxStudent.Clear();
				}
				else
				{
					MessageBox.Show("Du måste välja en klass");
				}
			}
		}
		private void Form1_Click(object sender, EventArgs e)
		{
			ClearAll();
		}

		private void ClearAll()
		{
			listBoxGradeLevels.ClearSelected();
			listBoxSchoolClasses.ClearSelected();
			listBoxStudents.ClearSelected();
		}

		private void buttonStudentsInSchoolClass_Click(object sender, EventArgs e)
		{
			SchoolClass schoolClass = (SchoolClass)listBoxSchoolClasses.SelectedItem;
			GradeLevel gradeLevel = (GradeLevel)listBoxGradeLevels.SelectedItem;
			if (schoolClass != null && gradeLevel != null)
			{
				ListForm listForm = new ListForm($"Studenter i {gradeLevel.Name} {schoolClass.Name}", school.Name, schoolClass.Students);
				listForm.Show();
			}
		}

		private void buttonStudentsInGradeLevel_Click(object sender, EventArgs e)
		{
			GradeLevel gradeLevel = (GradeLevel)listBoxGradeLevels.SelectedItem;
			if (gradeLevel != null)
			{
				ListForm listForm = new ListForm($"Studenter i {gradeLevel.Name}", school.Name, gradeLevel.SchoolClasses);
				listForm.Show();
			}
		}
		private void buttonAllStudents_Click(object sender, EventArgs e)
		{
			ListForm listForm = new ListForm($"Alla studenter i {school.Name}", school.Name, school.GradeLevels);
			listForm.Show();
		}

		public void PopulateLists()
		{
			school.GradeLevels.Add(new GradeLevel("Åk 1"));
			school.GradeLevels.Add(new GradeLevel("Åk 2"));
			school.GradeLevels.Add(new GradeLevel("Åk 3"));

			GradeLevel gradeLevel1 = school.GradeLevels[0];
			GradeLevel gradeLevel2 = school.GradeLevels[1];
			GradeLevel gradeLevel3 = school.GradeLevels[2];

			// Åk 1
			gradeLevel1.SchoolClasses.Add(new SchoolClass("Nat"));
			gradeLevel1.SchoolClasses.Add(new SchoolClass("Sam"));

			// Åk 2
			gradeLevel2.SchoolClasses.Add(new SchoolClass("Estet"));
			gradeLevel2.SchoolClasses.Add(new SchoolClass("Hum"));

			// Åk 3
			gradeLevel3.SchoolClasses.Add(new SchoolClass("Teknik"));
			gradeLevel3.SchoolClasses.Add(new SchoolClass("Ekonomi"));

			// Elever i Åk 1
			gradeLevel1.SchoolClasses[0].Students.Add(new Student("Anna"));
			gradeLevel1.SchoolClasses[0].Students.Add(new Student("Erik"));

			gradeLevel1.SchoolClasses[1].Students.Add(new Student("Lisa"));
			gradeLevel1.SchoolClasses[1].Students.Add(new Student("Johan"));

			// Elever i Åk 2
			gradeLevel2.SchoolClasses[0].Students.Add(new Student("Sara"));
			gradeLevel2.SchoolClasses[0].Students.Add(new Student("David"));

			gradeLevel2.SchoolClasses[1].Students.Add(new Student("Emma"));
			gradeLevel2.SchoolClasses[1].Students.Add(new Student("Oscar"));

			// Elever i Åk 3
			gradeLevel3.SchoolClasses[0].Students.Add(new Student("Maja"));
			gradeLevel3.SchoolClasses[0].Students.Add(new Student("Lucas"));

			gradeLevel3.SchoolClasses[1].Students.Add(new Student("Nora"));
			gradeLevel3.SchoolClasses[1].Students.Add(new Student("William"));
		}

		public void PopulateForm()
		{
			foreach (GradeLevel gradeLevel in school.GradeLevels)
			{
				listBoxGradeLevels.Items.Add(gradeLevel);
			}
		}

	}
}
