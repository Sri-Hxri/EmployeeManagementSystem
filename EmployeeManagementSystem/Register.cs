﻿using System;
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
    public partial class Register : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HAI\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {

            if(username_text.Text == null || password_text.Text == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {

                            checkUser.Parameters.AddWithValue("@user",username_text.Text.Trim());
                            int count =(int) checkUser.ExecuteScalar();

                            if(count >= 1)
                            {
                                MessageBox.Show(username_text.Text.Trim()+"has already been taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO users" + "(username,password,date_register) " +
                                    "VALUES (@username,@password,@dateReg) ";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {

                                    cmd.Parameters.AddWithValue("@username", username_text.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", password_text.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 form = new Form1();
                                    form.Show();
                                    this.Hide();

                                }
                             }

                            
                        }


                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Error" + ex , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        connect.Close();

                    }
                

                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void showPassword_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            password_text.PasswordChar = showPassword_checkbox.Checked ? '\0' : '*';
        }
    }
}
