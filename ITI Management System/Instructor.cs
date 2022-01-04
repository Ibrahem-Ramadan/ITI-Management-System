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
    public partial class Instructor : Form
    {
        public string username { get; set; }
        public string password { get; set; }
        public Dictionary<string, string> ins { get; set; }

        public Form Login { get; set; }

        public Dictionary<string, string> dept { get; set; }
        public Instructor(string uname , string pass, Form login)
        {
            InitializeComponent();
            username = uname;
            password = pass;
            this.Login = login;
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            btn_save.Visible = false;
            ddl_depts.Visible = false;

            tbx_uname.Text = username;
            tbx_pass.Text = password;
            tbx_pass.isPassword = true;
            ins = Business_Layer.getInstructor(username, password);
            dept = Business_Layer.getDepartmentById(ins["deptId"]);
            tbx_degree.Text = ins["degree"];
            tbx_dept.Text = dept["dept_name"];

            //====================================

            ddl_crss.DataSource = Business_Layer.instructorCourses(Business_Layer.getInstructorStudents(int.Parse(ins["id"])));
            dgv_mycrss.DataSource = Business_Layer.getInsructorCourses(int.Parse(ins["id"]));
            dgv_stu.DataSource = Business_Layer.getInstructorStudents(int.Parse(ins["id"]));

        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            Business_Layer.editInstructor(int.Parse(ins["id"]), tbx_uname.Text, tbx_pass.Text, tbx_degree.Text, (int)ddl_depts.SelectedValue);
            username = tbx_uname.Text;
            password = tbx_pass.Text;
            ins = Business_Layer.getInstructor(username, password);
            tbx_dept.Text = ddl_depts.Text;

            //=========================================================
            lbl_edit.ForeColor = Color.DodgerBlue;
            btn_save.Visible = false;
            tbx_uname.Enabled = false;
            tbx_degree.Enabled = false;
            tbx_dept.Enabled = false;
            tbx_pass.Enabled = false;
            tbx_pass.isPassword = true;
            ddl_depts.Visible = false;
            //==========================================================
          

        }


        private void lbl_edit_Click_1(object sender, EventArgs e)
        {
            btn_save.Visible = true;
            lbl_edit.ForeColor = Color.White;
            tbx_uname.Enabled = true;
            tbx_degree.Enabled = true;
            tbx_dept.Enabled = true;
            tbx_pass.Enabled = true;
            tbx_pass.isPassword = false;
            //======================================================
            ddl_depts.DataSource = Business_Layer.getDepartments();
            ddl_depts.DisplayMember = "Item2";
            ddl_depts.ValueMember = "Item1";
            ddl_depts.SelectedValue = int.Parse( ins["deptId"]);
            //=======================================================
            ddl_depts.Visible= true;

        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }



        private void ddl_crss_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_stu.DataSource = Business_Layer.getInstructorStudents(int.Parse(ins["id"]),ddl_crss.Text);

        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Show();
        }
    }
}
