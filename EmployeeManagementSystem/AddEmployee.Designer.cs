namespace EmployeeManagementSystem
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEmloyee_employeeid = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddEmployee_fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddEmployee_gender = new System.Windows.Forms.ComboBox();
            this.AddEmployee_phonenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddEmployee_picture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddEmployee_addbtn = new System.Windows.Forms.Button();
            this.AddEmployee_updatebtn = new System.Windows.Forms.Button();
            this.AddEmployee_clearbtn = new System.Windows.Forms.Button();
            this.AddEmployee_deletebtn = new System.Windows.Forms.Button();
            this.AddEmployee_position = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddEmployee_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmployee_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 265);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE\'S DATA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(8, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 225);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AddEmployee_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.AddEmployee_position);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.AddEmployee_deletebtn);
            this.panel2.Controls.Add(this.AddEmployee_clearbtn);
            this.panel2.Controls.Add(this.AddEmployee_updatebtn);
            this.panel2.Controls.Add(this.AddEmployee_addbtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.AddEmployee_picture);
            this.panel2.Controls.Add(this.AddEmployee_phonenumber);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AddEmployee_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.AddEmployee_fullname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AddEmloyee_employeeid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(4, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 291);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee id :";
            // 
            // AddEmloyee_employeeid
            // 
            this.AddEmloyee_employeeid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmloyee_employeeid.Location = new System.Drawing.Point(111, 15);
            this.AddEmloyee_employeeid.Name = "AddEmloyee_employeeid";
            this.AddEmloyee_employeeid.Size = new System.Drawing.Size(141, 23);
            this.AddEmloyee_employeeid.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddEmployee_fullname
            // 
            this.AddEmployee_fullname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_fullname.Location = new System.Drawing.Point(111, 54);
            this.AddEmployee_fullname.Name = "AddEmployee_fullname";
            this.AddEmployee_fullname.Size = new System.Drawing.Size(141, 23);
            this.AddEmployee_fullname.TabIndex = 3;
            this.AddEmployee_fullname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender :";
            // 
            // AddEmployee_gender
            // 
            this.AddEmployee_gender.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_gender.FormattingEnabled = true;
            this.AddEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.AddEmployee_gender.Location = new System.Drawing.Point(112, 89);
            this.AddEmployee_gender.Name = "AddEmployee_gender";
            this.AddEmployee_gender.Size = new System.Drawing.Size(140, 25);
            this.AddEmployee_gender.TabIndex = 5;
            // 
            // AddEmployee_phonenumber
            // 
            this.AddEmployee_phonenumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_phonenumber.Location = new System.Drawing.Point(112, 134);
            this.AddEmployee_phonenumber.Name = "AddEmployee_phonenumber";
            this.AddEmployee_phonenumber.Size = new System.Drawing.Size(141, 23);
            this.AddEmployee_phonenumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone number :";
            // 
            // AddEmployee_picture
            // 
            this.AddEmployee_picture.BackColor = System.Drawing.Color.Silver;
            this.AddEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddEmployee_picture.Location = new System.Drawing.Point(549, 15);
            this.AddEmployee_picture.Name = "AddEmployee_picture";
            this.AddEmployee_picture.Size = new System.Drawing.Size(133, 139);
            this.AddEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddEmployee_picture.TabIndex = 8;
            this.AddEmployee_picture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(549, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "IMPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddEmployee_addbtn
            // 
            this.AddEmployee_addbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_addbtn.Location = new System.Drawing.Point(31, 220);
            this.AddEmployee_addbtn.Name = "AddEmployee_addbtn";
            this.AddEmployee_addbtn.Size = new System.Drawing.Size(100, 50);
            this.AddEmployee_addbtn.TabIndex = 10;
            this.AddEmployee_addbtn.Text = "ADD";
            this.AddEmployee_addbtn.UseVisualStyleBackColor = true;
            this.AddEmployee_addbtn.Click += new System.EventHandler(this.AddEmployee_addbtn_Click);
            // 
            // AddEmployee_updatebtn
            // 
            this.AddEmployee_updatebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_updatebtn.Location = new System.Drawing.Point(183, 220);
            this.AddEmployee_updatebtn.Name = "AddEmployee_updatebtn";
            this.AddEmployee_updatebtn.Size = new System.Drawing.Size(100, 50);
            this.AddEmployee_updatebtn.TabIndex = 11;
            this.AddEmployee_updatebtn.Text = "UPDATE";
            this.AddEmployee_updatebtn.UseVisualStyleBackColor = true;
            this.AddEmployee_updatebtn.Click += new System.EventHandler(this.AddEmployee_updatebtn_Click);
            // 
            // AddEmployee_clearbtn
            // 
            this.AddEmployee_clearbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_clearbtn.Location = new System.Drawing.Point(328, 220);
            this.AddEmployee_clearbtn.Name = "AddEmployee_clearbtn";
            this.AddEmployee_clearbtn.Size = new System.Drawing.Size(100, 50);
            this.AddEmployee_clearbtn.TabIndex = 12;
            this.AddEmployee_clearbtn.Text = "CLEAR";
            this.AddEmployee_clearbtn.UseVisualStyleBackColor = true;
            this.AddEmployee_clearbtn.Click += new System.EventHandler(this.AddEmployee_clearbtn_Click);
            // 
            // AddEmployee_deletebtn
            // 
            this.AddEmployee_deletebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_deletebtn.Location = new System.Drawing.Point(474, 220);
            this.AddEmployee_deletebtn.Name = "AddEmployee_deletebtn";
            this.AddEmployee_deletebtn.Size = new System.Drawing.Size(100, 50);
            this.AddEmployee_deletebtn.TabIndex = 13;
            this.AddEmployee_deletebtn.Text = "DELETE";
            this.AddEmployee_deletebtn.UseVisualStyleBackColor = true;
            this.AddEmployee_deletebtn.Click += new System.EventHandler(this.AddEmployee_deletebtn_Click);
            // 
            // AddEmployee_position
            // 
            this.AddEmployee_position.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_position.FormattingEnabled = true;
            this.AddEmployee_position.Items.AddRange(new object[] {
            "Developer",
            "Bussiness",
            "Management"});
            this.AddEmployee_position.Location = new System.Drawing.Point(356, 10);
            this.AddEmployee_position.Name = "AddEmployee_position";
            this.AddEmployee_position.Size = new System.Drawing.Size(140, 25);
            this.AddEmployee_position.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Position :";
            // 
            // AddEmployee_status
            // 
            this.AddEmployee_status.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_status.FormattingEnabled = true;
            this.AddEmployee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.AddEmployee_status.Location = new System.Drawing.Point(356, 52);
            this.AddEmployee_status.Name = "AddEmployee_status";
            this.AddEmployee_status.Size = new System.Drawing.Size(140, 25);
            this.AddEmployee_status.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status :";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(700, 570);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmployee_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddEmloyee_employeeid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox AddEmployee_fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AddEmployee_gender;
        private System.Windows.Forms.TextBox AddEmployee_phonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddEmployee_addbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox AddEmployee_picture;
        private System.Windows.Forms.Button AddEmployee_deletebtn;
        private System.Windows.Forms.Button AddEmployee_clearbtn;
        private System.Windows.Forms.Button AddEmployee_updatebtn;
        private System.Windows.Forms.ComboBox AddEmployee_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AddEmployee_status;
        private System.Windows.Forms.Label label7;
    }
}
