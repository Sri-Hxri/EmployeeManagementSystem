using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace EmployeeManagementSystem
{


    public partial class AddEmployee : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HAI\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public AddEmployee()
        {
            InitializeComponent();

            displayeEmployeeData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void displayeEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeelisData();

            dataGridView1.DataSource = listData;
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayeEmployeeData();
        }

        public void clearFields()
        {
            AddEmloyee_employeeid.Text = "";
            AddEmployee_fullname.Text = "";
            AddEmployee_gender.SelectedIndex = -1;
            AddEmployee_phonenumber.Text = "";
            AddEmployee_position.SelectedIndex = -1;
            AddEmployee_status.SelectedIndex = -1;
            AddEmployee_picture.Image = null;
        }

        private void AddEmployee_addbtn_Click(object sender, EventArgs e)
        {

            if(AddEmloyee_employeeid.Text == "" || AddEmployee_fullname.Text == ""|| AddEmployee_gender.Text == ""
                || AddEmployee_phonenumber.Text == "" || AddEmployee_position.Text == "" || AddEmployee_status.Text == ""
                || AddEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string checkEmID = "SELECT COUNT(*) FROM employee WHERE employee_id = @emID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", AddEmloyee_employeeid.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if ( count >= 1)
                            {
                                MessageBox.Show(AddEmloyee_employeeid.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employee " +
                                    "(employee_id, full_name, gender, contact_number" +
                                    ", position, image, salary, insert_date, status) " +
                                    "VALUES(@employeeID, @fullName, @gender, @contactNum" +
                                    ", @position, @image, @salary, @insertDate, @status)";

                                string path = Path.Combine(@"C:\Users\HAI\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\Directory\"
                                    + AddEmloyee_employeeid.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(AddEmployee_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {

                                    cmd.Parameters.AddWithValue("@employeeID", AddEmloyee_employeeid.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", AddEmployee_fullname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", AddEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", AddEmployee_phonenumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", AddEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", AddEmployee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayeEmployeeData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();


                                }

                            }
                        }
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    AddEmployee_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                AddEmloyee_employeeid.Text = row.Cells[1].Value.ToString();
                AddEmployee_fullname.Text = row.Cells[2].Value.ToString();
                AddEmployee_gender.Text = row.Cells[3].Value.ToString();
                AddEmployee_phonenumber.Text = row.Cells[4].Value.ToString();
                AddEmployee_position.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    AddEmployee_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    AddEmployee_picture.Image = null;
                }

                AddEmployee_status.Text = row.Cells[8].Value.ToString();
            }
        }

        private void AddEmployee_updatebtn_Click(object sender, EventArgs e)
        {

            if (AddEmloyee_employeeid.Text == "" || AddEmployee_fullname.Text == "" || AddEmployee_gender.Text == ""
                || AddEmployee_phonenumber.Text == "" || AddEmployee_position.Text == "" || AddEmployee_status.Text == ""
                || AddEmployee_picture.Image == null)
            {

                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + AddEmloyee_employeeid.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employee SET full_name = @fullName" +
                            ", gender = @gender, contact_number = @contactNum" +
                            ", position = @position, update_date = @updateDate, status = @status " +
                            "WHERE employee_id = @employeeID";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullName", AddEmployee_fullname.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", AddEmployee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNum", AddEmployee_phonenumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", AddEmployee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", AddEmployee_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", AddEmloyee_employeeid.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayeEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }

                        }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    {
                      connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void AddEmployee_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AddEmployee_deletebtn_Click(object sender, EventArgs e)
        {
            if (AddEmloyee_employeeid.Text == "" || AddEmployee_fullname.Text == "" || AddEmployee_gender.Text == ""
                || AddEmployee_phonenumber.Text == "" || AddEmployee_position.Text == "" || AddEmployee_status.Text == ""
                || AddEmployee_picture.Image == null)
            {

                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + AddEmloyee_employeeid.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;    

                        string updateData = "UPDATE employee SET delete_date = @deleteDate " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@employeeID", AddEmloyee_employeeid.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayeEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
