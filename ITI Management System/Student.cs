using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI_Management_System
{
    public partial class Student : Form
    {
        public string username { get; set; }
        public string pass { get; set; }
        public Form Login { get; set; }
        public Dictionary<string, string> stu {  get; set; }
        public Student(string username , string pass, Form login)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
            this.Login = login;  
        }

        private void Student_Load(object sender, EventArgs e)
        {
            stu = Business_Layer.getStudent(username, pass);
            Dictionary<string, string> dept = Business_Layer.getDepartmentById(stu["deptId"]);
            tbx_uname.Text = stu["username"];
            tbx_age.Text = stu["age"];
            tbx_address.Text = stu["address"];
            tbx_dept.Text = dept["dept_name"];


            //=========================================
           
            dgv_stu.DataSource = Business_Layer.getCourses();
            List<Tuple<int, string>> courses = Business_Layer.Courses(Business_Layer.getCourses());

            List<Tuple<int, string>> topics = Business_Layer.getTopicsList();
            ddl_topics.DisplayMember = "Item2";
            ddl_topics.ValueMember = "Item1";
            ddl_topics.DataSource = topics;

            ddl_Courses.DisplayMember = "Item2";
            ddl_Courses.ValueMember = "Item1";
            ddl_Courses.DataSource = courses;

            //=================================================
            List<Tuple<int, string>> instructors = Business_Layer.Instructors(Business_Layer.getInstructorsByCourse(ddl_Courses.Text));

            ddl_ins.DisplayMember = "Item2";
            ddl_ins.ValueMember = "Item1";
            ddl_ins.DataSource = instructors;
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        { 
            this.Close();   
            Application.Exit();
        }

 
        private void ddl_topics_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Tuple<int, string>> courses = Business_Layer.Courses(Business_Layer.getCourses(ddl_topics.Text));

            dgv_stu.DataSource = Business_Layer.getCourses(ddl_topics.Text);
            dgv_crss.DataSource = Business_Layer.getCrssForSpacificStu(username, pass);
            ddl_Courses.DataSource = courses;

        }



        private void bunifuPictureBox4_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex++;
            dgv_ins.DataSource = Business_Layer.getInstructors();

            //=========================================================================

            List<Tuple<int, string>> courses = Business_Layer.Courses(Business_Layer.getCourses());
            ddl_crss.DataSource = courses;
            ddl_crss.DisplayMember = "Item2";
            ddl_crss.ValueMember = "Item1";

            //=========================================================================

            dgv_myins.DataSource = Business_Layer.getInsForSpacificStu(username, pass);
        }

        private void bunifuPictureBox5_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex--; 

        }

        private void btn_enroll_Click(object sender, EventArgs e)
        {
            Business_Layer.StudentCourseEnrollment(int.Parse(stu["id"]), int.Parse(ddl_Courses.SelectedValue.ToString()),int.Parse(ddl_ins.SelectedValue.ToString()));
            dgv_crss.DataSource = Business_Layer.getCrssForSpacificStu(username, pass);

        }


        private void ddl_crss_SelectedValueChanged(object sender, EventArgs e)
        {
            dgv_ins.DataSource = Business_Layer.getInstructorsByCourse(ddl_crss.Text);

        }

        private void ddl_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Tuple<int, string>> instructors = Business_Layer.Instructors(Business_Layer.getInstructorsByCourse(ddl_Courses.Text));

            ddl_ins.DataSource = instructors;
        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Show();
        }
    }
}
