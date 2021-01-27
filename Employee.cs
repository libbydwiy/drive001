using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;
using Newtonsoft.Json;

namespace payroll
{
    public partial class Employee : Form
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Jog1rY9wwqptLFXFOu8TesQ7MD6oKsK1y7UX3izC",
            BasePath = "https://test1-be77d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Employee()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void emplist_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            Listemp();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            Listemp();
            
        }
        public void Listemp()
        {
            try
            {
                FirebaseResponse response = client.Get("Employees/");
                Dictionary<string, add_employee> getEmployee = response.ResultAs<Dictionary<string, add_employee>>();

                foreach (var get in getEmployee)
                {
                        dataGridView1.Rows.Add(

                        get.Value.ID,
                        get.Value.Firstname,
                        get.Value.Middlename,
                        get.Value.Lastname,
                        get.Value.Month,
                        get.Value.Day,
                        get.Value.Year,
                        get.Value.Address1,
                        get.Value.Address2,
                        get.Value.Barangay,
                        get.Value.City,
                        get.Value.Province,
                        get.Value.Zipcode,
                        get.Value.Number,
                        get.Value.Email           
                    );
                }

            }
            catch
            {
                MessageBox.Show("No Data To Retrieved");
            }
        }

        private void Payroll_Click(object sender, EventArgs e)
        {
            Payroll frm = new Payroll();
            frm.Show();
            this.Hide();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            Users frm = new Users();
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
