namespace StudentGrades
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            listBox_StudentInfo.Items.Clear();

            int studentId;
            double grade;
            string name;

            if (int.TryParse(input_StudentID.Text, out studentId) && 
                double.TryParse(input_Grade.Text, out grade))
            {
                name = input_Name.Text;

                var student_info = new Student(studentId, name, grade);

                students.Add(student_info);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

            foreach (Student student in students)
            {
                listBox_StudentInfo.Items.Add($"Student ID: {student.StudentID}");
                listBox_StudentInfo.Items.Add($"Student Name: {student.Name}");
                listBox_StudentInfo.Items.Add($"Student Grade: {student.Grade}");
            }
        }
    }
}
