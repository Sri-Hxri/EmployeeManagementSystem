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

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HAI\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void showPassword_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            password_text.PasswordChar = showPassword_checkbox.Checked ? '\0' : '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_text.Text == null || password_text.Text == null) 
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if(connect.State != ConnectionState.Open) 
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData,connect)) 
                        {
                        
                        cmd.Parameters.AddWithValue("@username",username_text.Text.Trim());
                        cmd.Parameters.AddWithValue("@password",password_text.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                                
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Signed in Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm form = new MainForm();
                                form.Show();
                                this.Hide();
                  
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                
            }


        }
    }
}
