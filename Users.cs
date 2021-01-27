using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace payroll
{
    public partial class Users : Form
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Jog1rY9wwqptLFXFOu8TesQ7MD6oKsK1y7UX3izC",
            BasePath = "https://test1-be77d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            user_refresh();

        }
        public void user_refresh()
        {
            try
            {
                FirebaseResponse resp2 = client.Get("PayrollDB/Table/Users/");
                Dictionary<string, add_user> userload = resp2.ResultAs<Dictionary<string, add_user>>();
                foreach (var get in userload) {
                    dataGridView1.Rows.Add(
                        get.Value.user_username,
                        get.Value.user_Name,
                        get.Value.user_password,
                        get.Value.user_userlevel
                        );
                }
            }
            catch
            {
                MessageBox.Show("No Data to be exported");
            }
        }

        private void user_LevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {     
        }

        private async void btnsave_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(userNAME.Text) || string.IsNullOrEmpty(userPASSWORD.Text))
                {
                    MessageBox.Show("Please fill-up the following data. ");
                    return;
                }
                else
                {
                    var add_new_user = new add_user
                    {
                        user_username = newUSERNAME.Text,
                        user_Name = userNAME.Text,
                        user_password = userPASSWORD.Text,
                    };
                    SetResponse response = await client.SetTaskAsync("PayrollDB/Table/Users/" + add_new_user.user_username, add_new_user);
                    FirebaseResponse response1 = await client.UpdateTaskAsync("PayrollDB/Table/Users/" + newUSERNAME.Text, add_new_user);
                    add_user result = response1.ResultAs<add_user>();
                    MessageBox.Show("Succesful!");
                }
        }           


        private void cb_userLEVEL_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private async void btn_research_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("PayrollDB/Table/Users/" + newUSERNAME.Text);
            add_user search = response.ResultAs<add_user>();
            newUSERNAME.Text = search.user_username;
            userNAME.Text = search.user_Name;
            userPASSWORD.Text = search.user_password;
        }

        private async void btnMUdel_Click(object sender, EventArgs e)
        {
          
            DialogResult dialog = MessageBox.Show("You're trying to delete a user, Press Yes to Confirm","Are you sure?",MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:
                    FirebaseResponse response = await client.DeleteTaskAsync("PayrollDB/Table/Users/" + newUSERNAME.Text);
                    MessageBox.Show("User Deleted");
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            user_refresh();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }

        private void Payroll_Click(object sender, EventArgs e)
        {
            Payroll frm = new Payroll();
            frm.Show();
            this.Hide();
        }

        private void EmployeeList_Click(object sender, EventArgs e)
        {
            Employee frm = new Employee();
            frm.Show();
            this.Hide();
        }

        private void emp_reports_Click(object sender, EventArgs e)
        {
            emp_reports frm = new emp_reports();
            frm.Show();
            this.Hide();
        }
    }
}
