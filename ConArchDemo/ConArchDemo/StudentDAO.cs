using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//For Ado.Net
using System.Data.SqlClient;
using System.Data;

namespace ConArchDemo
{
    /// <summary>
    /// Demo code for connected Architecture in StudentDAO class
    /// </summary>
    public class StudentDAO
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;

        public StudentDAO()
        {
            //For Old Version
            //string constr = "Data Source;Initial Catalog = LPU_Db;Integrated Security =True";
            con = new SqlConnection();

            // 3 Things - Server , Integrated Security , Database 
            con.ConnectionString = "Server=.\\sqlexpress;Integrated Security=SSPI;Database=LPU_Db;TrustServerCertificate=true";
        }


        public List<Student> ShowAllStudents()
        {
            List<Student> studList = null;

            //Code for Connected Architecture

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo";

                
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                //Holding data via Reader - Forward only Control -- Select command -- Execute reader
                sdr = cmd.ExecuteReader();
                
                DataTable myDt = new DataTable();

                myDt.Load(sdr);

                if(myDt.Rows.Count > 0)
                {
                    studList = new List<Student>();
                }
                //Convert table into list
                foreach (DataRow drow in myDt.Rows)
                {
                    Student sObj = new Student()
                    {
                        RollNo = Convert.ToInt32(drow[0].ToString()),
                        Name = drow[1].ToString(),
                        Address = drow[3].ToString(),
                        Age = Convert.ToInt32(drow[2].ToString())
                    };

                    if(sObj != null)
                    {
                        studList.Add(sObj);
                    }
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Program Completed!!");
                con.Close();
            }

            return studList;
        }
        public List<Student> SearchByName(string name)
        {
            List<Student> studList = null;
            SqlParameter param1 = new SqlParameter("@Name", name);

            //Code for Connected Architecture

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo where Name =@Name";


                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;


                //Param is to be added
                cmd.Parameters.Add(param1);

                //Holding data via Reader - Forward only Control -- Select command -- Execute reader
                sdr = cmd.ExecuteReader();

                DataTable myDt = new DataTable();

                myDt.Load(sdr);

                if (myDt.Rows.Count > 0)
                {
                    studList = new List<Student>();
                }
                //Convert table into list
                foreach (DataRow drow in myDt.Rows)
                {
                    Student sObj = new Student()
                    {
                        RollNo = Convert.ToInt32(drow[0].ToString()),
                        Name = drow[1].ToString(),
                        Address = drow[3].ToString(),
                        Age = Convert.ToInt32(drow[2].ToString())
                    };

                    if (sObj != null)
                    {
                        studList.Add(sObj);
                    }
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Program Completed!!");
                con.Close();
            }

            return studList;
        }

        public Student SearchByRollNo(string name)
        {
            Student tempObj = null;

            return tempObj;
        }
    }
}
