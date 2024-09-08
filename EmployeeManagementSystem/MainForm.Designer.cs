namespace EmployeeManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.AddEmployee_btn = new System.Windows.Forms.Button();
            this.salary_btn = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addEmployee1 = new EmployeeManagementSystem.AddEmployee();
            this.salary1 = new EmployeeManagementSystem.Salary();
            this.dashboard1 = new EmployeeManagementSystem.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 30);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(976, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.logOut);
            this.panel2.Controls.Add(this.salary_btn);
            this.panel2.Controls.Add(this.AddEmployee_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 570);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome User!";
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.Location = new System.Drawing.Point(69, 212);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(150, 50);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // AddEmployee_btn
            // 
            this.AddEmployee_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_btn.Location = new System.Drawing.Point(60, 299);
            this.AddEmployee_btn.Name = "AddEmployee_btn";
            this.AddEmployee_btn.Size = new System.Drawing.Size(173, 50);
            this.AddEmployee_btn.TabIndex = 2;
            this.AddEmployee_btn.Text = "ADD EMPLOYEE";
            this.AddEmployee_btn.UseVisualStyleBackColor = true;
            this.AddEmployee_btn.Click += new System.EventHandler(this.AddEmployee_btn_Click);
            // 
            // salary_btn
            // 
            this.salary_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_btn.Location = new System.Drawing.Point(69, 391);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.Size = new System.Drawing.Size(150, 50);
            this.salary_btn.TabIndex = 3;
            this.salary_btn.Text = "SALARY";
            this.salary_btn.UseVisualStyleBackColor = true;
            this.salary_btn.Click += new System.EventHandler(this.salary_btn_Click);
            // 
            // logOut
            // 
            this.logOut.AutoSize = true;
            this.logOut.BackColor = System.Drawing.Color.White;
            this.logOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(7, 545);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(58, 19);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "LogOut";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.salary1);
            this.panel3.Controls.Add(this.addEmployee1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 570);
            this.panel3.TabIndex = 2;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(0, -1);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(700, 570);
            this.addEmployee1.TabIndex = 0;
            this.addEmployee1.Load += new System.EventHandler(this.addEmployee1_Load);
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(700, 570);
            this.salary1.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(700, 570);
            this.dashboard1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button salary_btn;
        private System.Windows.Forms.Button AddEmployee_btn;
        private System.Windows.Forms.Label logOut;
        private System.Windows.Forms.Panel panel3;
        private AddEmployee addEmployee1;
        private Dashboard dashboard1;
        private Salary salary1;
    }
}