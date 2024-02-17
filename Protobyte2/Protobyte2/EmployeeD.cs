using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Resources;

namespace Protobyte2
{
    internal class EmployeeD
    {

        public int ID { set; get; }
        public string EmployeeID { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
        public string Contant { set; get; }
        public string Position { set; get; }
        public string Image { set; get; }
        public int Salary { set; get; }
        public string Status { set; get; }


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sony\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;");

        public List<EmployeeD> employeeListData()
        {
            List<EmployeeD> listdata = new List<EmployeeD>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectDate = "SELECT * FROM employes WHERE delete_date IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectDate, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            EmployeeD ed = new EmployeeD();
                            ed.ID = (int)reader["id"];
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contant = reader["contact_number"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Image = reader["image"].ToString();
                            ed.Salary = (int)reader["salary"];
                            ed.Status = reader["status"].ToString();

                            listdata.Add(ed);
                        }
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erorr: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listdata;
        }
    } 
}
