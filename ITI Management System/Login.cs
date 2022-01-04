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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            rdio_admin.Checked = false;
            rdio_instructor.Checked = false;
            rdio_student.Checked = false;
            this.ActiveControl = bunifuCards1;


            //////////////////////////////////////////
   
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            rdio_admin.Checked = true;
            rdio_instructor.Checked = false;
            rdio_student.Checked = false;
            rdio_admin.Focus();   
        }


        private void lbl_student_Click(object sender, EventArgs e)
        {
            rdio_admin.Checked = false;
            rdio_instructor.Checked = false;
            rdio_student.Checked = true;
            rdio_student.Focus();
        }

        private void lbl_instructor_Click(object sender, EventArgs e)
        {
            rdio_admin.Checked = false;
            rdio_instructor.Checked = true;
            rdio_student.Checked = false;
            rdio_instructor.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lbl_uname.Text = "";
            lbl_pass.Text = "";
            lbl_user.Text = "";

            string user = "";
            if (rdio_admin.Checked)
                user = "admin";
            else if (rdio_instructor.Checked)
                user = "instructor";
            else if (rdio_student.Checked)
                user = "student";


            if(user == "" || tbx_uname.Text == "" || tbx_pass.Text =="")
            {
                if (tbx_uname.Text == "")
                {
                    lbl_uname.Text = "Username Requierd";
                }
                if (tbx_pass.Text == "")
                {
                    lbl_pass.Text = "Password Required";
                }
                if (user == "")
                {
                    lbl_user.Text = "Field Required";
                }
            }
            else
            {
                if (Business_Layer.checkUser(user, tbx_uname.Text, tbx_pass.Text))
                {
                    if(user == "student")
                    {
                        Form student = new Student(tbx_uname.Text, tbx_pass.Text , this);
                        student.Show();
                        this.Hide();
                    }
                    else if (user == "instructor")
                    {
                        Form instructor = new Instructor(tbx_uname.Text, tbx_pass.Text , this);
                        instructor.Show();
                        this.Hide();
                    }
                    else if (user == "admin")
                    {
                        Form admin = new Admin(tbx_uname.Text, tbx_pass.Text , this);
                        admin.Show();
                        this.Hide();
                    }

                    tbx_uname.Text = tbx_pass.Text = "";
                    rdio_admin.Checked = rdio_instructor.Checked = rdio_student.Checked = false;

                    
                }
                else
                {
                    lbl_uname.Text = "Invalid Username";
                    lbl_pass.Text = "Invalid Password";
                    lbl_user.Text = "";

                }
            }



        }

        private void tbx_uname_OnValueChanged(object sender, EventArgs e)
        {
            lbl_uname.Text = "";
        }

        private void tbx_pass_OnValueChanged(object sender, EventArgs e)
        {
            lbl_pass.Text = "";

        }
    }
}
