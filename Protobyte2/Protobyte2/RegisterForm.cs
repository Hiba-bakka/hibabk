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
    public partial class RegisterForm : Form 
    {
        //ربط قاعدة بيانات


        SqlConnection connect
         = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sony\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        //----------------------------------------


        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
        signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(signup_userename.Text) || string.IsNullOrWhiteSpace(signup_password.Text))
            {
                MessageBox.Show("قم بتعبئة الحقول",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if(connect.State != ConnectionState.Open)

                {
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT COUNT(id) FROM users2 WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))

                        {
                            checkUser.Parameters.AddWithValue("@user", signup_userename.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if(count >= 1)
                            {

                                MessageBox.Show(signup_userename.Text.Trim() + "هادا المستخدم متوفر  سجل ب اسم  اخر",
                                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        //--------------------------------------------------




                       DateTime today = DateTime.Today;

                        string insertData = "INSERT INTO users2" +
                            "(username, password, date_register)" +
                            "VALUES(@username, @password, @dateReg)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", signup_userename.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@dateReg", today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("DONE!",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            Form1 loginForm = new Form1();
                            loginForm.Show();
                            this.Hide();

                        }

                    }
                    catch (Exception ex)
                    {
                        // Write the exception details to the console
                        Console.WriteLine(ex.ToString());

                        // Display a generic error message to the user
                        MessageBox.Show("An error occurred. Please try again.",
                             "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    finally
                    {
                        connect.Close();

                    }
                }
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
