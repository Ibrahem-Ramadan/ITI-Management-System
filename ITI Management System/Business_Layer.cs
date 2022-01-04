using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITI_Management_System
{
    internal class Business_Layer
    {
        public static bool checkUser(string user , string uname , string pass)
        {
            SqlCommand cmd;
            if (user == "admin")
               cmd = new SqlCommand($"Select ADMIN_UNAME, ADMIN_PASS from admin where ADMIN_UNAME = '{uname}' and ADMIN_PASS = '{pass}' ");
            else if(user == "instructor")
                cmd = new SqlCommand($"Select ins_name, ins_pass from instructor where ins_name  = '{uname}' and ins_pass = '{pass}'");
            else
                cmd = new SqlCommand($"Select st_uname ,st_pass from student where st_uname = '{uname}' and st_pass= '{pass}'");

            return DB_Layer.Select(cmd).Rows.Count == 1;
        }
        public static Dictionary<string, string> getStudent(string uname , string pass)
        {
            Dictionary<string , string> student = new Dictionary<string, string>();
            DataRow dr = DB_Layer.Select(new SqlCommand($"select * from student where st_uname = '{uname}' and st_pass = '{pass}'")).Rows[0];

            student.Add("id", dr.Field<int>("st_id").ToString());
            student.Add("fname", dr.Field<string>("st_fname"));
            student.Add("Lname",dr.Field<string>("st_lname"));
            student.Add("address", dr.Field<string>("st_address"));
            student.Add("age", dr.Field<int>("st_age").ToString());
            student.Add("deptId", dr.Field<int>("Dept_Id").ToString());
            student.Add("username", dr.Field<string>("st_uname"));
            student.Add("password", dr.Field<string>("st_pass"));

            return student;
        }
        public static Dictionary<string, string>  getDepartmentById(string deptId)
        {
            Dictionary<string, string> dept = new Dictionary<string, string>();
            DataRow dr = DB_Layer.Select(new SqlCommand($"select * from department where dept_id={int.Parse(deptId)} ")).Rows[0];
            dept.Add("dept_name", dr.Field<string>("dept_name"));

            return dept;

        }
        public static List<Tuple<int, string>> getDepartments()
        {
            List<Tuple<int, string>> depts = new List<Tuple<int, string>>();
            
            foreach (DataRow dr in DB_Layer.Select(new SqlCommand("Select dept_id, dept_name from Department")).Rows)
            {
                depts.Add(new Tuple<int, string>((int)dr["dept_id"], dr["dept_name"].ToString()));
            }
            return depts;

        }

        public static List<Tuple<int, string>> getSupers()
        {
            List<Tuple<int, string>> supers = new List<Tuple<int, string>>();

            foreach (DataRow dr in DB_Layer.Select(new SqlCommand("Select st_id as superid , Concat(st_fname,' ',st_lname) as supername from student")).Rows)
            {
                supers.Add(new Tuple<int, string>((int)dr["superid"], dr["supername"].ToString()));
            }
            return supers;

        }
        public static DataTable getCourses(  string top_name = "%")
        {
            if(top_name == "All Topics") top_name = "%";
            DataTable dt= DB_Layer.Select(new SqlCommand($"select c.crs_id as ID ,c.crs_name as Course , c.crs_duration as Duration , t.top_name as Topic  " +
                                                         $"from course c left join topic t " +
                                                         $"on t.top_id = c.top_id " +
                                                         $"where isnull(t.top_name ,'') like '{top_name}'"));

            return dt;
        }
        public static List<Tuple<int, string>> Courses( DataTable dt)
        {
            List<Tuple<int, string>> c = new List<Tuple<int, string>>();
            c.Add(new Tuple<int, string>(0, "All"));
            foreach (DataRow dr in dt.Rows)
            {
                c.Add(new Tuple<int, string>((int)dr["ID"], dr["Course"].ToString()));
            }
            return c;
        }
        public static DataTable getCrssForSpacificStu(string uname, string pass)
        {
            
            DataTable dr = DB_Layer.Select(new SqlCommand($"select c.crs_id as ID, c.crs_name as Course , c.crs_duration as Duration , sc.Grade " +
                                                          $"from course c , student s, Stud_Course sc " +
                                                          $"where c.Crs_Id = sc.Crs_Id and sc.St_Id = s.St_Id and s.St_Uname = '{uname}' and s.St_Pass = '{pass}' "));
            return dr;
        }
        public static DataTable getInstructors()
        {

            DataTable dr = DB_Layer.Select(new SqlCommand($"select i.ins_id as ID , i.Ins_Name as Instructor, i.Ins_Degree as Degree, c.Crs_Name as Course , ic.Evaluation " +
                                                          $"from instructor i, Course c, Ins_Course ic " +
                                                          $"where i.Ins_Id = ic.Ins_Id and c.Crs_Id = ic.Crs_Id"));
            return dr;
        }

        public static DataTable getInstructorsByCourse(string crsname)
        {
            if (crsname == "All") crsname = "%";
            DataTable dr = DB_Layer.Select(new SqlCommand($"select i.ins_id as ID ,i.Ins_Name as Instructor, i.Ins_Degree as Degree, c.Crs_Name as Course , ic.Evaluation   " +
                                                          $"from instructor i, Course c, Ins_Course ic " +
                                                          $"where i.Ins_Id = ic.Ins_Id and c.Crs_Id = ic.Crs_Id and c.Crs_Name like '{crsname}' "));
            return dr;
        }
        public static List<Tuple<int, string>> Instructors(DataTable dt)
        {
            List<Tuple<int, string>> ins = new List<Tuple<int, string>>();
          
            foreach (DataRow dr in dt.Rows)
            {
                if(!ins.Contains(new Tuple<int, string>((int)dr["ID"], dr["Instructor"].ToString())))
                    ins.Add(new Tuple<int, string>((int)dr["ID"], dr["Instructor"].ToString()));
            }
            return ins;
        }
        public static DataTable getInsForSpacificStu(string uname, string pass)
        {
            DataTable dr = DB_Layer.Select(new SqlCommand($"select i.Ins_Name as Instructor , c.Crs_Name as Course " +
                                                          $"from Instructor i , Ins_Course ic, Course c, Stud_Course sc, Student s " +
                                                          $"where s.St_Id = sc.St_Id and sc.Crs_Id = c.Crs_Id and ic.Ins_Id = i.Ins_Id and ic.Crs_Id = c.Crs_Id " +
                                                          $"and sc.ins_id = i.Ins_Id and s.St_Uname = '{uname}' and s.St_Pass = '{pass}'"));
            return dr;
        }
        public static List<Tuple<int, string>> getTopicsList()
        {
            List<Tuple<int, string>> topics = new List<Tuple<int, string>>();
            topics.Add(new Tuple<int, string>((int)0, "All Topics"));

            foreach (DataRow dr in DB_Layer.Select(new SqlCommand($"select * from topic ")).Rows)
            {
                topics.Add(new Tuple<int, string>((int)dr["top_id"], dr["top_name"].ToString()));
            }
            return topics;
        }
        public static int StudentCourseEnrollment(int stu_id , int crs_id , int ins_id)
        {
            if (DB_Layer.Select(new SqlCommand($"select * from stud_course where crs_id = {crs_id} and st_id = {stu_id}" )).Rows.Count > 0)
            {
                MessageBox.Show("You Already Enrolled in this Course" , "",MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
                return 0;
            }
            else
            {
                if(MessageBox.Show("Are You Sure to Enroll in this Course ? ","Confirmation",MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return DB_Layer.DML(new SqlCommand($"insert into stud_course(crs_id,st_id ,ins_id) values ({crs_id},{stu_id},{ins_id})"));
                }
                return 0; 
            }
            
        }

        public static Dictionary<string, string> getInstructor(string uname, string pass)
        {
            Dictionary<string, string> instructor = new Dictionary<string, string>();
            DataRow dr = DB_Layer.Select(new SqlCommand($"select * from instructor where ins_name = '{uname}' and ins_pass = '{pass}'")).Rows[0];

            instructor.Add("id", dr.Field<int>("ins_id").ToString());
            instructor.Add("name", dr.Field<string>("ins_name"));
            instructor.Add("degree", dr.Field<string>("ins_degree"));
            instructor.Add("salary", dr.Field<decimal>("salary").ToString());
            instructor.Add("deptId", dr.Field<int>("Dept_Id").ToString());
            instructor.Add("password", dr.Field<string>("ins_pass"));

            return instructor;
        }
        public static int editInstructor(int id , string uname , string pass , string degree, int deptId)
        {
            return DB_Layer.DML(new SqlCommand($"update instructor " +
                                        $"Set ins_name = '{uname}' , ins_degree = '{degree}' ,  ins_pass = '{pass}' , dept_id = {deptId} " +
                                        $"where ins_id={id} "));
        }


        public static DataTable getInsructorCourses( int ins_id)
        {
           return DB_Layer.Select(new SqlCommand($"select c.Crs_Name as Course , c.Crs_Duration as Duration , ic.Evaluation  " +
                                                 $"from Instructor i , Course c, Ins_Course ic " +
                                                 $"where i.Ins_Id = ic.Ins_Id and c.Crs_Id = ic.Crs_Id and i.Ins_Id = {ins_id}" +
                                                 $"order by Course"));
        }

        public static DataTable getInstructorStudents(int ins_id, string crs ="%")
        {
            if(crs == "All Courses" ) crs = "%" ;
            return DB_Layer.Select(new SqlCommand($"select Concat(s.St_Fname,' ', s.St_Lname) as Student ,  c.Crs_Name as Course  " +
                $"from Instructor i , Ins_Course ic, Course c, Stud_Course sc, Student s " +
                $"where i.Ins_Id = ic.Ins_Id and ic.Crs_Id = c.Crs_Id and c.Crs_Id = sc.Crs_Id and sc.St_Id = s.St_Id and sc.Ins_Id = i.Ins_Id and i.Ins_Id = {ins_id } and c.Crs_Name like '{crs}' " +
                $"order by Course"));
        }

        public static List<string> instructorCourses(DataTable dt)
        {
            List<string> c = new List<string>();
            c.Add("All Courses");
            foreach (DataRow dr in dt.Rows)
            {
                c.Add(dr["Course"].ToString());
            }
            return c;
        }

        public static DataTable getStudents()
        {
            return DB_Layer.Select(new SqlCommand($"  Select s.st_id as ID , Concat(s.st_fname,' ', s.st_lname) as Name ,s.st_address as Address , s.st_age as Age, s.st_uname as Username, s.st_pass as Password, d.Dept_Name as Department, CONCAT(super.St_Fname, ' ', super.St_Lname) as Supervisor " +
                                                    $"from Student s left join Department d " +
                                                    $"on s.Dept_Id = d.Dept_Id " +
                                                    $"left join Student super " +
                                                    $"on s.St_super = super.St_Id"));
        }



        public static int addStudent(int id , string fname , string lname , string address , int? age ,int deptid, int super, string uname , string pass )
        {
            
            SqlCommand cmd = new SqlCommand($"insert into student" +
                                                $" values ({id},'{fname}','{lname}','{address}',@age,@dept,@super,'{uname}','{pass}')");
            if (age == null)
                cmd.Parameters.AddWithValue("age", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("age", age);
            if (deptid == 0)
                cmd.Parameters.AddWithValue("dept", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dept", deptid);
            if (super == 0)
                cmd.Parameters.AddWithValue("super", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("super", super);

            return DB_Layer.DML(cmd);
        }

        public static int updateStudent(int id, string fname, string lname, string address, int? age, int deptid, int super, string uname, string pass)
        {
            SqlCommand cmd = new SqlCommand($"update student " +
                                              $"Set st_fname='{fname}', st_lname='{lname}', st_address='{address}', st_age=@age,dept_id=@dept,st_super=@super,st_uname='{uname}',st_pass='{pass}'" +
                                              $"where st_id={id}");
            if (age == null)
                cmd.Parameters.AddWithValue("age", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("age", age);

            if (deptid == 0)
                cmd.Parameters.AddWithValue("dept", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dept", deptid);
            if (super == 0)
                cmd.Parameters.AddWithValue("super", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("super", super);

            return DB_Layer.DML(cmd);
        }



        public static int deleteStudent(int id)
        {
            SqlCommand cmd = new SqlCommand($"delete from student " +
                                             $"where st_id={id}");

            return DB_Layer.DML(cmd);
        }

        public static DataTable getallInstructors()
        {
            return  DB_Layer.Select(new SqlCommand($"select i.Ins_Id as ID, i.Ins_Name as Name , i.Ins_Degree as Degree , i.Salary as Salary,d.Dept_Name as Department, i.Ins_Pass as Password " +
                                                   $"from Instructor i left join Department d on i.Dept_Id = d.Dept_Id"));
        }
        public static int? ToNullableInt(string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }

        public static int addInstructor(int id, string name, string degree, int? sal, int deptid, string pass)
        {

            SqlCommand cmd = new SqlCommand($"insert into instructor" +
                                                $" values ({id},'{name}','{degree}',@sal,@dept,'{pass}')");
            if (sal == null)
                cmd.Parameters.AddWithValue("sal", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("sal", sal);
            if (deptid == 0)
                cmd.Parameters.AddWithValue("dept", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dept", deptid);

            return DB_Layer.DML(cmd);
        }

        public static int updateInstructor(int id, string name, string degree, int? sal, int deptid, string pass)
        {
            SqlCommand cmd = new SqlCommand($"update instructor " +
                                              $"Set ins_name='{name}', ins_degree='{degree}', Salary=@sal,dept_id=@dept,ins_pass='{pass}'" +
                                              $"where ins_id={id}");
            if (sal == null)
                cmd.Parameters.AddWithValue("sal", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("sal", sal);

            if (deptid == 0)
                cmd.Parameters.AddWithValue("dept", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dept", deptid);
           

            return DB_Layer.DML(cmd);
        }

        public static int deleteInstructor(int id)
        {
            return DB_Layer.DML(new SqlCommand($"delete from instructor " +
                                               $"where ins_id={id}"));
        }

        public static int addCourse(int id, string name, int? dur, int topic)
        {
            SqlCommand cmd = new SqlCommand($"insert into Course" +
                                               $" values ({id},'{name}',@dur,@topic)");
            if (dur == null)
                cmd.Parameters.AddWithValue("dur", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dur", dur);
            if (topic == 0)
                cmd.Parameters.AddWithValue("topic", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("topic", topic);

            return DB_Layer.DML(cmd);
        }
        public static int updateCourse(int id, string name, int? dur, int topic)
        {
            SqlCommand cmd = new SqlCommand($"update course " +
                                              $"Set crs_name='{name}', crs_duration=@dur,top_id=@topic " +
                                              $"where crs_id={id}");
            if (dur == null)
                cmd.Parameters.AddWithValue("dur", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("dur", dur);

            if (topic == 0)
                cmd.Parameters.AddWithValue("topic", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("topic", topic);


            return DB_Layer.DML(cmd);
        }

        public static int deleteCourse(int id)
        {
            return DB_Layer.DML(new SqlCommand($"delete from Course " +
                                               $"where crs_id={id}"));
        }


        public static DataTable getTopics()
        {
            return DB_Layer.Select(new SqlCommand($"select top_id as [Topic ID] , top_name as [Topic Name] " +
                                                $" from topic"));
        }
        public static int addTopic(int id, string name)
        {
            return DB_Layer.DML(new SqlCommand($"insert into Topic" +
                                               $" values ({id},'{name}')"));
        }
        public static int updateTopic(int id, string name)
        {
            return DB_Layer.DML(new SqlCommand($"update topic " +
                                              $"Set top_name='{name}' " +
                                              $"where top_id={id}"));
        }

        public static int deleteTopic(int id)
        {
            return DB_Layer.DML(new SqlCommand($"delete from topic " +
                                               $"where top_id={id}"));
        }
    }
}
