namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Output "\n" is for new line
            MessageBox.Show("Student Profile    — GitHub Beginner Lab.\nContact Number: — 09171234567");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;

            if (studentID == "12345")
            {
                lblName.Text = "Name: John Doe";
                lblID.Text = "ID: 12345";

                lblYear.Text = "Year: 4th Year";

            }

            else if (studentID == "12344"){
                lblName.Text = "Name: Jane Doe";
                lblID.Text = "ID: 12344";
                lblYear.Text = "Year: 4th Year";
            }
            else if (studentID == "12343")
            {
                lblName.Text = "Name: Miss Mo";
                lblID.Text = "ID: 12343";
                lblYear.Text = "Year: 3rd Year";
            }
            else if (studentID == "12342")
            {
                lblName.Text = "Name: Syempre Naman";
                lblID.Text = "ID: 12342";
                lblYear.Text = "Year: 2nd Year";
            }
            else if (studentID == "12340")
            {
                lblName.Text = "Name: Sinong Hindi";
                lblID.Text = "ID: 12340";
                lblYear.Text = "Year: 1st Year";
            }
            else
            {
                MessageBox.Show("Student not found.");
                lblName.Text = "Name: Student not found";
                lblID.Text = "ID: Student not found";
                lblYear.Text = "Year: Student not found";
            }
        }
    }
}
