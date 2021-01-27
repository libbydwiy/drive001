
namespace payroll
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.emp_user = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.emp_reports = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeList = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.Button();
            this.Payroll = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emplist_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.emp_id_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_name_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_status_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_position_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_gender_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_joined_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_birthday_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_address_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_number_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_email_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_user
            // 
            this.emp_user.BackColor = System.Drawing.Color.Transparent;
            this.emp_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emp_user.BackgroundImage")));
            this.emp_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emp_user.FlatAppearance.BorderSize = 0;
            this.emp_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_user.Location = new System.Drawing.Point(3, 5);
            this.emp_user.Name = "emp_user";
            this.emp_user.Size = new System.Drawing.Size(160, 57);
            this.emp_user.TabIndex = 0;
            this.emp_user.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.emp_reports);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.EmployeeList);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.Users);
            this.panel2.Controls.Add(this.Payroll);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 681);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Log-out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emp_reports
            // 
            this.emp_reports.BackColor = System.Drawing.Color.Transparent;
            this.emp_reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.emp_reports.FlatAppearance.BorderSize = 0;
            this.emp_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_reports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_reports.Location = new System.Drawing.Point(0, 247);
            this.emp_reports.Name = "emp_reports";
            this.emp_reports.Size = new System.Drawing.Size(166, 28);
            this.emp_reports.TabIndex = 10;
            this.emp_reports.Text = "Reports";
            this.emp_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emp_reports.UseVisualStyleBackColor = false;
            this.emp_reports.Click += new System.EventHandler(this.emp_reports_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 224);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(166, 23);
            this.panel7.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "REPORTS";
            // 
            // EmployeeList
            // 
            this.EmployeeList.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeList.FlatAppearance.BorderSize = 0;
            this.EmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmployeeList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeList.Location = new System.Drawing.Point(0, 196);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(166, 28);
            this.EmployeeList.TabIndex = 6;
            this.EmployeeList.Text = "Employee List";
            this.EmployeeList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeList.UseVisualStyleBackColor = false;
            this.EmployeeList.Click += new System.EventHandler(this.EmployeeList_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 174);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 22);
            this.panel5.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LIST";
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.Color.Transparent;
            this.Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.Users.FlatAppearance.BorderSize = 0;
            this.Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Users.Location = new System.Drawing.Point(0, 146);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(166, 28);
            this.Users.TabIndex = 4;
            this.Users.Text = "Users";
            this.Users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Users.UseVisualStyleBackColor = false;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Payroll
            // 
            this.Payroll.BackColor = System.Drawing.Color.Transparent;
            this.Payroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.Payroll.FlatAppearance.BorderSize = 0;
            this.Payroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payroll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Payroll.Location = new System.Drawing.Point(0, 118);
            this.Payroll.Name = "Payroll";
            this.Payroll.Size = new System.Drawing.Size(166, 28);
            this.Payroll.TabIndex = 3;
            this.Payroll.Text = "Payroll";
            this.Payroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Payroll.UseVisualStyleBackColor = false;
            this.Payroll.Click += new System.EventHandler(this.Payroll_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(0, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "Employee";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 22);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.emp_user);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 68);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.emplist_refresh);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 681);
            this.panel1.TabIndex = 1;
            // 
            // emplist_refresh
            // 
            this.emplist_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emplist_refresh.BackgroundImage")));
            this.emplist_refresh.FlatAppearance.BorderSize = 0;
            this.emplist_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emplist_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emplist_refresh.Location = new System.Drawing.Point(783, 61);
            this.emplist_refresh.Name = "emplist_refresh";
            this.emplist_refresh.Size = new System.Drawing.Size(100, 23);
            this.emplist_refresh.TabIndex = 35;
            this.emplist_refresh.Text = "Print";
            this.emplist_refresh.UseVisualStyleBackColor = true;
            this.emplist_refresh.Click += new System.EventHandler(this.emplist_refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emp_id_list,
            this.emp_name_list,
            this.Column4,
            this.emp_status_list,
            this.emp_position_list,
            this.emp_gender_list,
            this.emp_joined_list,
            this.emp_birthday_list,
            this.emp_address_list,
            this.emp_number_list,
            this.emp_email_list,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(163, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(809, 591);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Location = new System.Drawing.Point(166, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(729, 0);
            this.panel6.TabIndex = 1;
            // 
            // emp_id_list
            // 
            this.emp_id_list.HeaderText = "Employee ID";
            this.emp_id_list.Name = "emp_id_list";
            this.emp_id_list.ReadOnly = true;
            // 
            // emp_name_list
            // 
            this.emp_name_list.HeaderText = "First Name";
            this.emp_name_list.Name = "emp_name_list";
            this.emp_name_list.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Last Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // emp_status_list
            // 
            this.emp_status_list.HeaderText = "Birthmonth";
            this.emp_status_list.Name = "emp_status_list";
            this.emp_status_list.ReadOnly = true;
            // 
            // emp_position_list
            // 
            this.emp_position_list.HeaderText = "Birthday";
            this.emp_position_list.Name = "emp_position_list";
            this.emp_position_list.ReadOnly = true;
            // 
            // emp_gender_list
            // 
            this.emp_gender_list.HeaderText = "Birthyear";
            this.emp_gender_list.Name = "emp_gender_list";
            this.emp_gender_list.ReadOnly = true;
            // 
            // emp_joined_list
            // 
            this.emp_joined_list.HeaderText = "Street";
            this.emp_joined_list.Name = "emp_joined_list";
            this.emp_joined_list.ReadOnly = true;
            // 
            // emp_birthday_list
            // 
            this.emp_birthday_list.HeaderText = "Street line 2";
            this.emp_birthday_list.Name = "emp_birthday_list";
            this.emp_birthday_list.ReadOnly = true;
            // 
            // emp_address_list
            // 
            this.emp_address_list.HeaderText = "Barangay";
            this.emp_address_list.Name = "emp_address_list";
            this.emp_address_list.ReadOnly = true;
            // 
            // emp_number_list
            // 
            this.emp_number_list.HeaderText = "City";
            this.emp_number_list.Name = "emp_number_list";
            this.emp_number_list.ReadOnly = true;
            // 
            // emp_email_list
            // 
            this.emp_email_list.HeaderText = "State";
            this.emp_email_list.Name = "emp_email_list";
            this.emp_email_list.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Zipcode";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button emp_user;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button emp_reports;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EmployeeList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Payroll;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button emplist_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_name_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_status_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_position_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_gender_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_joined_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_birthday_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_address_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_number_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_email_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}