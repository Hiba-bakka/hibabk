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

namespace Protobyte2
{
    public partial class Form1 : Form
    {
        SqlConnection connect
         = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sony\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;");
        public Form1()
        {
            InitializeComponent();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_userename.Text == ""
                || login_password.Text == "")
            {
                MessageBox.Show("قم بتعبئة الحقول",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectDate = "SELECT * FROM users2 WHERE username = @username" +
                             " AND password = @password";
                        using(SqlCommand cmd = new SqlCommand(selectDate, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_userename.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);


                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("تم التسجيل بنجاح",
                               "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                        
                            else
                            {
                                MessageBox.Show("incorect username/password",
                             "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }



                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error" + ex,
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
