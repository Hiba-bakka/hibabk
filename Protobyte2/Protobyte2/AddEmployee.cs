using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace Protobyte2
{
    public partial class AddEmployee: UserControl
       
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sony\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;");
        public AddEmployee()
        {
            InitializeComponent();

            // to display  data from database to your data grid view

            displayEmployeeData();

        }

        //عرض البيانات من قاعدة البيانات في الجدول

        public void displayEmployeeData()
        {
            EmployeeD ed = new EmployeeD();
            List<EmployeeD> listData = ed.employeeListData();

            dataGridView2.DataSource = listData;
        }
        //------------------------------------------


        private void button2_Click(object sender, EventArgs e)
        {
             if(addemployee_id.Text == ""
                || addemployee_fullname.Text == "" 
                || addemployee_gender.Text == ""
                || addemployee_phone.Text == ""
                || addemployee_position.Text == ""
                || addemployee_status.Text == ""
                || addemployee_image.Image == null )
            {
                MessageBox.Show("please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM employes WHERE employee_id = @emID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect)) 
                        {
                            string paramName = "@emID";   
                            checkEm.Parameters.AddWithValue("@emID", addemployee_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addemployee_id.Text.Trim() + " is already taken"
                                , " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO employes" +
                                          "(employee_id, full_name, gender, contact_number, position," +
                                            "image, salary, insert_date, [status])" +
                                             "VALUES(@employeeID, @fullName, @gender, @contactnum" +
                                              ", @position, @image, @salary, @insertdate, @status)";

                                string path = Path.Combine(@"C:\Users\Sony\Desktop\Protobyte2\Protobyte2\directory\"
                                  + addemployee_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addemployee_image.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addemployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullname", addemployee_fullname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addemployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactnum", addemployee_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addemployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertdate", today);
                                    cmd.Parameters.AddWithValue("@status", addemployee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();
                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:"+ ex, "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Update_Click(object sender, EventArgs e)
        {
            if (addemployee_id.Text == ""
                || addemployee_fullname.Text == ""
                || addemployee_gender.Text == ""
                || addemployee_phone.Text == ""
                || addemployee_position.Text == ""
                || addemployee_status.Text == ""
                || addemployee_image.Image == null)
            {
                MessageBox.Show("please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + addemployee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employes SET full_name = @fullname" +
                                    ", gender = @gender, contact_number = @contactnum" +
                                    ", position = @position, update_date = @updatedate, [status] = @status" +
                                    " WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullname", addemployee_fullname.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addemployee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactnum", addemployee_phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", addemployee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updatedate", today); // Corrected parameter name
                            cmd.Parameters.AddWithValue("@status", addemployee_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", addemployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();
                            MessageBox.Show("Updated successfully!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                
        
                catch (Exception ex)
                {
                    MessageBox.Show("Erorr: "+ ex, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                        connect.Close();
                }
                else
                {
                   
                    MessageBox.Show("Cncelled.", "Information Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        
        private void AddEmployee_delete_Click(object sender, EventArgs e)
        {
            if(addemployee_id.Text == ""
                || addemployee_fullname.Text == ""
                || addemployee_gender.Text == ""
                || addemployee_phone.Text == ""
                || addemployee_position.Text == ""
                || addemployee_status.Text == ""
                || addemployee_image.Image == null)
            {
                MessageBox.Show("please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + addemployee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employes SET delete_date = @deletedat WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                           
                            cmd.Parameters.AddWithValue("@deletedat", today); // Corrected 
                            cmd.Parameters.AddWithValue("@employeeID", addemployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();
                            MessageBox.Show("Deleted successfully!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show("Erorr: " + ex, "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                else
                {

                    MessageBox.Show("Cncelled.", "Information Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                addemployee_id.Text = row.Cells[1].Value.ToString();
                addemployee_fullname.Text = row.Cells[2].Value.ToString();
                addemployee_gender.Text = row.Cells[3].Value.ToString();
                addemployee_phone.Text = row.Cells[4].Value.ToString();
                addemployee_position.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if(imagePath != null)
                {
                    addemployee_image.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addemployee_image.Image = null;
                }

                addemployee_status.Text = row.Cells[8].Value.ToString();
            }
        }

        public void clearFields()
        {
            addemployee_id.Text = "";
            addemployee_fullname.Text = "";
            addemployee_gender.Text = "";
            addemployee_phone.Text = "";
            addemployee_position.SelectedIndex = -1;
            addemployee_status.SelectedIndex = -1;
            addemployee_image.Image = null;


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void addemployee_importp_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png;)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addemployee_image.ImageLocation = imagePath;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erorr:" + ex,"Errorr message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void AddEmployee_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
