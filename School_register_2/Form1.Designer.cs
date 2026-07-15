namespace School_register_2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			labelGradeLevel = new Label();
			listBoxGradeLevels = new ListBox();
			textBoxGradeLevel = new TextBox();
			buttonNewGradeLevel = new Button();
			buttonCreateNewSchoolClass = new Button();
			textBoxSchoolClass = new TextBox();
			listBoxSchoolClasses = new ListBox();
			label1 = new Label();
			buttonCreateNewStudent = new Button();
			textBoxStudent = new TextBox();
			listBoxStudents = new ListBox();
			label2 = new Label();
			buttonListAllStudents = new Button();
			buttonStudentInSchoolClass = new Button();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			buttonStudentInGradeLevel = new Button();
			SuspendLayout();
			// 
			// labelGradeLevel
			// 
			labelGradeLevel.AutoSize = true;
			labelGradeLevel.Location = new Point(12, 19);
			labelGradeLevel.Name = "labelGradeLevel";
			labelGradeLevel.Size = new Size(56, 15);
			labelGradeLevel.TabIndex = 0;
			labelGradeLevel.Text = "Årskurser";
			// 
			// listBoxGradeLevels
			// 
			listBoxGradeLevels.FormattingEnabled = true;
			listBoxGradeLevels.ItemHeight = 15;
			listBoxGradeLevels.Location = new Point(12, 47);
			listBoxGradeLevels.Name = "listBoxGradeLevels";
			listBoxGradeLevels.Size = new Size(100, 94);
			listBoxGradeLevels.TabIndex = 1;
			listBoxGradeLevels.SelectedIndexChanged += listBoxGradeLevels_SelectedIndexChanged;
			// 
			// textBoxGradeLevel
			// 
			textBoxGradeLevel.Location = new Point(12, 162);
			textBoxGradeLevel.Name = "textBoxGradeLevel";
			textBoxGradeLevel.Size = new Size(100, 23);
			textBoxGradeLevel.TabIndex = 2;
			// 
			// buttonNewGradeLevel
			// 
			buttonNewGradeLevel.Location = new Point(39, 200);
			buttonNewGradeLevel.Name = "buttonNewGradeLevel";
			buttonNewGradeLevel.Size = new Size(73, 23);
			buttonNewGradeLevel.TabIndex = 3;
			buttonNewGradeLevel.Text = "Lägg till";
			buttonNewGradeLevel.UseVisualStyleBackColor = true;
			buttonNewGradeLevel.Click += buttonNewGradeLevel_Click;
			// 
			// buttonCreateNewSchoolClass
			// 
			buttonCreateNewSchoolClass.Location = new Point(172, 200);
			buttonCreateNewSchoolClass.Name = "buttonCreateNewSchoolClass";
			buttonCreateNewSchoolClass.Size = new Size(70, 23);
			buttonCreateNewSchoolClass.TabIndex = 7;
			buttonCreateNewSchoolClass.Text = "Lägg till";
			buttonCreateNewSchoolClass.UseVisualStyleBackColor = true;
			buttonCreateNewSchoolClass.Click += buttonCreateNewSchoolClass_Click;
			// 
			// textBoxSchoolClass
			// 
			textBoxSchoolClass.Location = new Point(142, 162);
			textBoxSchoolClass.Name = "textBoxSchoolClass";
			textBoxSchoolClass.Size = new Size(100, 23);
			textBoxSchoolClass.TabIndex = 6;
			// 
			// listBoxSchoolClasses
			// 
			listBoxSchoolClasses.FormattingEnabled = true;
			listBoxSchoolClasses.ItemHeight = 15;
			listBoxSchoolClasses.Location = new Point(142, 47);
			listBoxSchoolClasses.Name = "listBoxSchoolClasses";
			listBoxSchoolClasses.Size = new Size(100, 94);
			listBoxSchoolClasses.TabIndex = 5;
			listBoxSchoolClasses.SelectedIndexChanged += listBoxSchoolClasses_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(142, 19);
			label1.Name = "label1";
			label1.Size = new Size(43, 15);
			label1.TabIndex = 4;
			label1.Text = "Klasser";
			// 
			// buttonCreateNewStudent
			// 
			buttonCreateNewStudent.Location = new Point(301, 200);
			buttonCreateNewStudent.Name = "buttonCreateNewStudent";
			buttonCreateNewStudent.Size = new Size(70, 23);
			buttonCreateNewStudent.TabIndex = 11;
			buttonCreateNewStudent.Text = "Lägg till";
			buttonCreateNewStudent.UseVisualStyleBackColor = true;
			buttonCreateNewStudent.Click += buttonCreateNewStudent_Click;
			// 
			// textBoxStudent
			// 
			textBoxStudent.Location = new Point(271, 162);
			textBoxStudent.Name = "textBoxStudent";
			textBoxStudent.Size = new Size(100, 23);
			textBoxStudent.TabIndex = 10;
			// 
			// listBoxStudents
			// 
			listBoxStudents.FormattingEnabled = true;
			listBoxStudents.ItemHeight = 15;
			listBoxStudents.Location = new Point(271, 47);
			listBoxStudents.Name = "listBoxStudents";
			listBoxStudents.Size = new Size(100, 94);
			listBoxStudents.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(271, 19);
			label2.Name = "label2";
			label2.Size = new Size(38, 15);
			label2.TabIndex = 8;
			label2.Text = "Elever";
			// 
			// buttonListAllStudents
			// 
			buttonListAllStudents.Location = new Point(126, 311);
			buttonListAllStudents.Name = "buttonListAllStudents";
			buttonListAllStudents.Size = new Size(40, 23);
			buttonListAllStudents.TabIndex = 12;
			buttonListAllStudents.Text = "Visa";
			buttonListAllStudents.UseVisualStyleBackColor = true;
			buttonListAllStudents.Click += buttonListAllStudents_Click;
			// 
			// buttonStudentInSchoolClass
			// 
			buttonStudentInSchoolClass.Location = new Point(126, 247);
			buttonStudentInSchoolClass.Name = "buttonStudentInSchoolClass";
			buttonStudentInSchoolClass.Size = new Size(42, 23);
			buttonStudentInSchoolClass.TabIndex = 13;
			buttonStudentInSchoolClass.Text = "Visa";
			buttonStudentInSchoolClass.UseVisualStyleBackColor = true;
			buttonStudentInSchoolClass.Click += buttonStudentInSchoolClass_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(11, 251);
			label3.Name = "label3";
			label3.Size = new Size(97, 15);
			label3.TabIndex = 14;
			label3.Text = "Elever i vald klass";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(11, 315);
			label4.Name = "label4";
			label4.Size = new Size(61, 15);
			label4.TabIndex = 15;
			label4.Text = "Alla elever";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(11, 282);
			label5.Name = "label5";
			label5.Size = new Size(109, 15);
			label5.TabIndex = 17;
			label5.Text = "Elever i vald årskurs";
			// 
			// buttonStudentInGradeLevel
			// 
			buttonStudentInGradeLevel.Location = new Point(126, 278);
			buttonStudentInGradeLevel.Name = "buttonStudentInGradeLevel";
			buttonStudentInGradeLevel.Size = new Size(42, 23);
			buttonStudentInGradeLevel.TabIndex = 16;
			buttonStudentInGradeLevel.Text = "Visa";
			buttonStudentInGradeLevel.UseVisualStyleBackColor = true;
			buttonStudentInGradeLevel.Click += buttonStudentInGradeLevel_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(391, 374);
			Controls.Add(label5);
			Controls.Add(buttonStudentInGradeLevel);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(buttonStudentInSchoolClass);
			Controls.Add(buttonListAllStudents);
			Controls.Add(buttonCreateNewStudent);
			Controls.Add(textBoxStudent);
			Controls.Add(listBoxStudents);
			Controls.Add(label2);
			Controls.Add(buttonCreateNewSchoolClass);
			Controls.Add(textBoxSchoolClass);
			Controls.Add(listBoxSchoolClasses);
			Controls.Add(label1);
			Controls.Add(buttonNewGradeLevel);
			Controls.Add(textBoxGradeLevel);
			Controls.Add(listBoxGradeLevels);
			Controls.Add(labelGradeLevel);
			Name = "Form1";
			Text = "Skolregister";
			Click += Form1_Click;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelGradeLevel;
		private ListBox listBoxGradeLevels;
		private TextBox textBoxGradeLevel;
		private Button buttonNewGradeLevel;
		private Button buttonCreateNewSchoolClass;
		private TextBox textBoxSchoolClass;
		private ListBox listBoxSchoolClasses;
		private Label label1;
		private Button buttonCreateNewStudent;
		private TextBox textBoxStudent;
		private ListBox listBoxStudents;
		private Label label2;
		private Button buttonListAllStudents;
		private Button buttonStudentInSchoolClass;
		private Label label3;
		private Label label4;
		private Label label5;
		private Button buttonStudentInGradeLevel;
	}
}
