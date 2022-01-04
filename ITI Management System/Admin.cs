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
    public partial class Admin : Form
    {
        public string username { get; set; }
        public string password { get; set; }

        List<Tuple<int, string>> depts;
        List<Tuple<int, string>> supers;
        List<Tuple<int, string>> topics;
        Form parentForm;
        public Admin(string uname , string pass , Form login)
        {
            InitializeComponent();
            username = uname;
            password = pass;
            parentForm = login;

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            tbx_uname.Text = username;
            tbx_pass.Text = password;   
            tbx_pass.isPassword = true;

            btn_cancelstu.Visible = btn_deletestu.Visible = btn_updatestu.Visible = false;

            dgv_stud.DataSource = Business_Layer.getStudents();

            depts = Business_Layer.getDepartments();
            depts.Insert(0, new Tuple<int, string>(0, "Select Department"));
            ddl_dept.DisplayMember = "Item2";
            ddl_dept.ValueMember = "Item1";
            ddl_dept.DataSource = depts;

            supers = Business_Layer.getSupers();
            supers.Insert(0, new Tuple<int, string>(0, "Select Supervisor"));
            ddl_super.DisplayMember = "Item2";
            ddl_super.ValueMember = "Item1";
            ddl_super.DataSource = supers;


        }


        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if(tbx_id.Text =="")
            {
                tbx_id.Focus();
                tbx_id.LineFocusedColor = Color.Red;
            }
            else if (tbx_fname.Text == "" )
            {
                tbx_fname.Focus();
                tbx_fname.LineFocusedColor = Color.Red;
            }
            else if (tbx_uname.Text == "" )
            {
                tbx_uname.Focus();
                tbx_uname.LineFocusedColor = Color.Red;

            }
            else if (tbx_pass.Text == "")
            {
                tbx_password.Focus();   
                tbx_password.LineFocusedColor = Color.Red;
            }
            else
            {
             
                Business_Layer.addStudent(int.Parse(tbx_id.Text), tbx_fname.Text, tbx_lname.Text, tbx_address.Text ,Business_Layer.ToNullableInt( tbx_age.Text),(int) ddl_dept.SelectedValue, (int) ddl_super.SelectedValue, tbx_username.Text, tbx_password.Text);
                dgv_stud.DataSource = Business_Layer.getStudents();

                tbx_id.LineFocusedColor = Color.DodgerBlue;
                tbx_fname.LineFocusedColor = Color.DodgerBlue;
                tbx_uname.LineFocusedColor = Color.DodgerBlue;
                tbx_password.LineFocusedColor = Color.DodgerBlue;
            }

            tbx_id.Text =  tbx_fname.Text = tbx_lname.Text = tbx_address.Text = tbx_age.Text = tbx_username.Text = tbx_password.Text = "";
            ddl_dept.SelectedValue = ddl_super.SelectedValue = 0;

        }
        private void dgv_stud_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_id.Enabled = false;

            tbx_id.Text = dgv_stud.SelectedRows[0].Cells[0].Value.ToString();

            string[] names = dgv_stud.SelectedRows[0].Cells[1].Value.ToString().Split(' ');
            tbx_fname.Text = names[0];
            tbx_lname.Text = names[1];

            tbx_address.Text = dgv_stud.SelectedRows[0].Cells[2].Value.ToString();
            tbx_age.Text = dgv_stud.SelectedRows[0].Cells[3].Value.ToString();
            tbx_username.Text = dgv_stud.SelectedRows[0].Cells[4].Value.ToString();
            tbx_password.Text = dgv_stud.SelectedRows[0].Cells[5].Value.ToString();


            if (String.IsNullOrWhiteSpace(dgv_stud.SelectedRows[0].Cells[6].Value.ToString()))
                ddl_dept.SelectedValue =  0;
            else
                ddl_dept.SelectedValue = depts.Where(d => d.Item2.Equals(dgv_stud.SelectedRows[0].Cells[6].Value.ToString())).Select(d => d.Item1).SingleOrDefault();

            if (String.IsNullOrWhiteSpace(dgv_stud.SelectedRows[0].Cells[7].Value.ToString()))
                ddl_super.SelectedValue = 0;
            else
                ddl_super.SelectedValue = supers.Where(s => s.Item2.Equals(dgv_stud.SelectedRows[0].Cells[7].Value.ToString())).Select(s => s.Item1).SingleOrDefault();


        
            btn_addstu.Visible = false;
            btn_cancelstu.Visible = btn_deletestu.Visible = btn_updatestu.Visible = true;



        }

        private void bunifuPictureBox4_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex++;

            btn_cancelins.Visible = btn_deleteins.Visible = btn_updateins.Visible = false;
            ddl_ins_dept.DisplayMember = "Item2";
            ddl_ins_dept.ValueMember = "Item1";

            ddl_ins_dept.DataSource = depts;
            dgv_ins.DataSource = Business_Layer.getallInstructors();
        }

        private void bunifuPictureBox5_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex++;

            btn_cancel_crs.Visible = btn_delete_crs.Visible = btn_update_crs.Visible = false;
            ddl_topics.DisplayMember = "Item2";
            ddl_topics.ValueMember = "Item1";

            topics = Business_Layer.getTopicsList();
            topics.RemoveAt(0);
            topics.Insert(0,new Tuple<int, string>(0, "Select Topic"));

            ddl_topics.DataSource = topics;
            dgv_crss.DataSource = Business_Layer.getCourses();


        }

        private void bunifuPictureBox6_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex--;

        }

        private void bunifuPictureBox8_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex++;

            btn_cancel_topic.Visible = btn_delete_topic.Visible = btn_update_topic.Visible = false;
            dgv_topics.DataSource = Business_Layer.getTopics();

            btn_add_topic.Visible = true;
            btn_cancel_topic.Visible = btn_delete_topic.Visible = btn_update_topic.Visible = false;
        }

        private void bunifuPictureBox7_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex--;

        }

        private void bunifuPictureBox9_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex--;

        }

        private void btn_updatestu_Click(object sender, EventArgs e)
        {

           Business_Layer.updateStudent(int.Parse(tbx_id.Text), tbx_fname.Text, tbx_lname.Text, tbx_address.Text, Business_Layer.ToNullableInt(tbx_age.Text),(int) ddl_dept.SelectedValue, (int)ddl_super.SelectedValue, tbx_username.Text, tbx_password.Text);
           dgv_stud.DataSource = Business_Layer.getStudents();


            tbx_id.Enabled = true;
           tbx_id.Text = tbx_fname.Text = tbx_lname.Text = tbx_address.Text = tbx_age.Text = tbx_username.Text = tbx_password.Text = "";
           ddl_dept.SelectedValue = ddl_super.SelectedValue = 0;

            btn_addstu.Visible = true;
            btn_cancelstu.Visible = btn_deletestu.Visible = btn_updatestu.Visible = false;

        }

        private void btn_deletestu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure to Delete Student No.{tbx_id.Text} ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Business_Layer.deleteStudent(int.Parse(tbx_id.Text));
                dgv_stud.DataSource = Business_Layer.getStudents();

                tbx_id.Enabled = true;
                tbx_id.Text = tbx_fname.Text = tbx_lname.Text = tbx_address.Text = tbx_age.Text = tbx_username.Text = tbx_password.Text = "";
                ddl_dept.SelectedValue = ddl_super.SelectedValue = 0;

                btn_addstu.Visible = true;
                btn_cancelstu.Visible = btn_deletestu.Visible = btn_updatestu.Visible = false;
            }

            

        }

        private void btn_cancelstu_Click(object sender, EventArgs e)
        {
            tbx_id.Enabled = true;
            tbx_id.Text = tbx_fname.Text = tbx_lname.Text = tbx_address.Text = tbx_age.Text = tbx_username.Text = tbx_password.Text = "";
            ddl_dept.SelectedValue = ddl_super.SelectedValue = 0;

            btn_addstu.Visible = true;
            btn_cancelstu.Visible = btn_deletestu.Visible = btn_updatestu.Visible = false;
        }

        private void dgv_ins_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_ins_id.Enabled = false;

            tbx_ins_id.Text = dgv_ins.SelectedRows[0].Cells[0].Value.ToString();

            tbx_ins_name.Text = dgv_ins.SelectedRows[0].Cells[1].Value.ToString();

            tbx_ins_degree.Text = dgv_ins.SelectedRows[0].Cells[2].Value.ToString();

            tbx_ins_sal.Text = dgv_ins.SelectedRows[0].Cells[3].Value.ToString();

            tbx_ins_pass.Text = dgv_ins.SelectedRows[0].Cells[5].Value.ToString();

            ddl_ins_dept.SelectedValue = dgv_ins.SelectedRows[0].Cells[5].Value.ToString();


            if (String.IsNullOrWhiteSpace(dgv_ins.SelectedRows[0].Cells[5].Value.ToString()))
                ddl_ins_dept.SelectedValue = 0;
            else
                ddl_ins_dept.SelectedValue = depts.Where(d => d.Item2.Equals(dgv_stud.SelectedRows[0].Cells[5].Value.ToString())).Select(d => d.Item1).SingleOrDefault();



            btn_addins.Visible = false;
            btn_cancelins.Visible = btn_deleteins.Visible = btn_updateins.Visible = true;
        }

        private void btn_addins_Click(object sender, EventArgs e)
        {
            if (tbx_ins_id.Text == "")
            {
                tbx_ins_id.Focus();
                tbx_ins_id.LineFocusedColor = Color.Red;
            }
            else if (tbx_ins_name.Text == "")
            {
                tbx_ins_name.Focus();
                tbx_ins_name.LineFocusedColor = Color.Red;
            }
            else if (tbx_ins_pass.Text == "")
            {
                tbx_ins_pass.Focus();
                tbx_ins_pass.LineFocusedColor = Color.Red;

            }
            else
            {

                Business_Layer.addInstructor(int.Parse(tbx_ins_id.Text), tbx_ins_name.Text, tbx_ins_degree.Text, Business_Layer.ToNullableInt(tbx_ins_sal.Text), (int)ddl_ins_dept.SelectedValue, tbx_ins_pass.Text);

                dgv_ins.DataSource = Business_Layer.getallInstructors();

                tbx_ins_id.LineFocusedColor = Color.DodgerBlue;
                tbx_ins_name.LineFocusedColor = Color.DodgerBlue;
                tbx_ins_pass.LineFocusedColor = Color.DodgerBlue;
            }

            tbx_ins_id.Text = tbx_ins_name.Text = tbx_ins_degree.Text = tbx_ins_sal.Text = tbx_ins_pass.Text = "";
            ddl_ins_dept.SelectedValue =  0;
        }

        private void btn_updateins_Click(object sender, EventArgs e)
        {

            Business_Layer.updateInstructor(int.Parse(tbx_ins_id.Text), tbx_ins_name.Text, tbx_ins_degree.Text, Business_Layer.ToNullableInt(tbx_ins_sal.Text), (int)ddl_ins_dept.SelectedValue, tbx_ins_pass.Text);
            dgv_ins.DataSource = Business_Layer.getallInstructors();

            tbx_ins_id.Enabled = true;
            tbx_ins_id.Text = tbx_ins_name.Text = tbx_ins_degree.Text = tbx_ins_sal.Text = tbx_ins_pass.Text = "";
            ddl_ins_dept.SelectedValue = 0;

            btn_addins.Visible = true;
            btn_cancelins.Visible = btn_deleteins.Visible = btn_updateins.Visible = false;
        }

        private void btn_deleteins_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure to Delete Instructor No.{tbx_ins_id.Text} ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Business_Layer.deleteInstructor(int.Parse(tbx_ins_id.Text));
                dgv_ins.DataSource = Business_Layer.getallInstructors();

                tbx_ins_id.Enabled = true;
                tbx_ins_id.Text = tbx_ins_name.Text = tbx_ins_degree.Text = tbx_ins_sal.Text = tbx_ins_pass.Text = "";
                ddl_ins_dept.SelectedValue = 0;

                btn_addins.Visible = true;
                btn_cancelins.Visible = btn_deleteins.Visible = btn_updateins.Visible = false;
            }
        }

        private void btn_cancelins_Click(object sender, EventArgs e)
        {
            tbx_ins_id.Enabled = true;
            tbx_ins_id.Text = tbx_ins_name.Text = tbx_ins_degree.Text = tbx_ins_sal.Text = tbx_ins_pass.Text = "";
            ddl_ins_dept.SelectedValue = 0;

            btn_addins.Visible = true;
            btn_cancelins.Visible = btn_deleteins.Visible = btn_updateins.Visible = false;
        }


        private void bunifuButton21_Click_1(object sender, EventArgs e)
        {
            tbx_crs_id.Enabled = true;
            btn_add_crs.Visible = true;
            btn_cancel_crs.Visible = btn_delete_crs.Visible = btn_update_crs.Visible = false;

            tbx_crs_id.Text = tbx_crs_name.Text = tbx_crs_duration.Text = "";
            ddl_topics.SelectedValue = 0;
        }

        private void btn_add_crs_Click(object sender, EventArgs e)
        {
            if (tbx_crs_id.Text == "")
            {
                tbx_crs_id.Focus();
                tbx_crs_id.LineFocusedColor = Color.Red;
            }
            else if (tbx_crs_name.Text == "")
            {
                tbx_crs_name.Focus();
                tbx_crs_name.LineFocusedColor = Color.Red;
            }
            else
            {
                Business_Layer.addCourse(int.Parse(tbx_crs_id.Text), tbx_crs_name.Text, Business_Layer.ToNullableInt(tbx_crs_duration.Text), (int)ddl_topics.SelectedValue);
                dgv_crss.DataSource = Business_Layer.getCourses();

                tbx_crs_id.LineFocusedColor = Color.DodgerBlue;
                tbx_crs_name.LineFocusedColor = Color.DodgerBlue;
               
            }

            tbx_crs_id.Text = tbx_crs_name.Text =  tbx_crs_duration.Text = "";
            ddl_topics.SelectedValue = 0;
        }

        private void btn_update_crs_Click(object sender, EventArgs e)
        {
            Business_Layer.updateCourse(int.Parse(tbx_crs_id.Text), tbx_crs_name.Text, Business_Layer.ToNullableInt(tbx_crs_duration.Text), (int)ddl_topics.SelectedValue);
            dgv_crss.DataSource = Business_Layer.getCourses();

            tbx_crs_id.Enabled = true;
            btn_add_crs.Visible = true;
            btn_cancel_crs.Visible = btn_delete_crs.Visible = btn_update_crs.Visible = false;

            tbx_crs_id.Text = tbx_crs_name.Text = tbx_crs_duration.Text = "";
            ddl_topics.SelectedValue = 0;
        }

        private void btn_delete_crs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure to Delete Course No.{tbx_crs_id.Text} ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Business_Layer.deleteCourse(int.Parse(tbx_crs_id.Text));
                dgv_crss.DataSource = Business_Layer.getCourses();

                tbx_crs_id.Enabled = true;
                btn_add_crs.Visible = true;
                btn_cancel_crs.Visible = btn_delete_crs.Visible = btn_update_crs.Visible = false;

                tbx_crs_id.Text = tbx_crs_name.Text = tbx_crs_duration.Text = "";
                ddl_topics.SelectedValue = 0;
            }
        }

        private void dgv_crss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_crs_id.Enabled = false;

            tbx_crs_id.Text = dgv_crss.SelectedRows[0].Cells[0].Value.ToString();

            tbx_crs_name.Text = dgv_crss.SelectedRows[0].Cells[1].Value.ToString();

            tbx_crs_duration.Text = dgv_crss.SelectedRows[0].Cells[2].Value.ToString();


            if (String.IsNullOrWhiteSpace(dgv_ins.SelectedRows[0].Cells[3].Value.ToString()))
                ddl_topics.SelectedValue = 0;
            else
                ddl_topics.SelectedValue = topics.Where(topic => topic.Item2.Equals(dgv_stud.SelectedRows[0].Cells[3].Value.ToString())).Select(topic => topic.Item1).SingleOrDefault();

            btn_add_crs.Visible = false;
            btn_cancel_crs.Visible = btn_delete_crs.Visible = btn_update_crs.Visible = true;
        }


        private void dgv_topics_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_topic_id.Enabled = false;

            tbx_topic_id.Text = dgv_topics.SelectedRows[0].Cells[0].Value.ToString();

            tbx_topic_name.Text = dgv_topics.SelectedRows[0].Cells[1].Value.ToString();

            btn_add_topic.Visible = false;
            btn_cancel_topic.Visible = btn_delete_topic.Visible = btn_update_topic.Visible = true;

        }

        private void btn_add_topic_Click(object sender, EventArgs e)
        {
            if (tbx_topic_id.Text == "")
            {
                tbx_topic_id.Focus();
                tbx_topic_id.LineFocusedColor = Color.Red;
            }
            else if (tbx_topic_name.Text == "")
            {
                tbx_topic_name.Focus();
                tbx_topic_name.LineFocusedColor = Color.Red;
            }
            else
            {
                Business_Layer.addTopic(int.Parse(tbx_topic_id.Text), tbx_topic_name.Text);
                dgv_topics.DataSource = Business_Layer.getTopics();

                tbx_topic_id.LineFocusedColor = Color.DodgerBlue;
                tbx_topic_name.LineFocusedColor = Color.DodgerBlue;

            }

            tbx_topic_id.Text = tbx_topic_name.Text = "";
         
        }

        private void btn_update_topic_Click(object sender, EventArgs e)
        {
            Business_Layer.updateTopic(int.Parse(tbx_topic_id.Text), tbx_topic_name.Text);
            dgv_topics.DataSource = Business_Layer.getTopics();

            tbx_topic_id.Enabled = true;
            btn_add_topic.Visible = true ;
            btn_cancel_topic.Visible = btn_delete_topic.Visible = btn_update_topic.Visible = false;

            tbx_topic_id.Text = tbx_topic_name.Text = "";

        }

        private void btn_delete_topic_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure to Delete Topic No.{tbx_topic_id.Text} ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Business_Layer.deleteTopic(int.Parse(tbx_topic_id.Text));
                dgv_topics.DataSource = Business_Layer.getTopics();

                tbx_topic_id.Enabled = true;
                btn_add_topic.Visible = true;
                btn_cancel_topic.Visible = btn_delete_topic.Visible = btn_update_topic.Visible = false;

                tbx_topic_id.Text = tbx_topic_name.Text = "";
            }
        }

        private void btn_cancel_topic_Click(object sender, EventArgs e)
        {
            tbx_topic_id.Enabled = true;
            btn_add_topic.Visible = true;
            btn_cancel_topic.Visible = btn_delete_topic.Visible = btn_update_topic.Visible = false;

            tbx_topic_id.Text = tbx_topic_name.Text = "";
        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }
    }
}
