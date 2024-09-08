using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HAI\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Salary()
        {
            InitializeComponent();
            displayEmployees();
            disableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayEmployees();
            disableFields();
        }

        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }

        public void disableFields()
        {
            Salary_employeeid.Enabled = false;
            Salary_fullname.Enabled = false;
            Salary_position.Enabled = false;
        }
        public void clearFields()
        {
            Salary_employeeid.Text = "";
            Salary_fullname.Text = "";
            Salary_position.Text = "";
            Salray_salary.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (Salary_employeeid.Text == "" || Salary_fullname.Text == "" || Salary_position.Text == "" || Salray_salary.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + Salary_employeeid.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(check == DialogResult.Yes)
                {
                    if(connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE employee SET salary = @salary" +
                                ", update_date = @updateData WHERE employee_id = @employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", Salray_salary.Text.Trim());
                                cmd.Parameters.AddWithValue("@updateData", today);
                                cmd.Parameters.AddWithValue("@employeeID", Salary_employeeid.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayEmployees();

                                MessageBox.Show("Updated successfully!"
                                    , "Information Message", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                               
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

                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Salary_employeeid.Text = row.Cells[0].Value.ToString();
                Salary_fullname.Text = row.Cells[1].Value.ToString();
                Salary_position.Text = row.Cells[4].Value.ToString();
                Salray_salary.Text = row.Cells[5].Value.ToString();
            }   

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
