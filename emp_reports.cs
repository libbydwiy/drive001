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

namespace payroll
{
    public partial class emp_reports : Form
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Jog1rY9wwqptLFXFOu8TesQ7MD6oKsK1y7UX3izC",
            BasePath = "https://test1-be77d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public emp_reports()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            emp_reports frm = new emp_reports();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void refresh_Click(object sender, EventArgs e)
        {
            /*dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            Listemp2();*/
        }

        private void emp_reports_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            Listemp2();
        }
        public void Listemp2()
        {
            try
            {
              
                FirebaseResponse response = client.Get("Employees/Salary/");
                Dictionary<string, add_employee> getEmployee = response.ResultAs<Dictionary<string, add_employee>>();

                foreach (var get in getEmployee)
                {
                    dataGridView1.Rows.Add(

                    get.Value.ID,
                    get.Value.Regular_earningday,
                    get.Value.Overtime_hr,
                    get.Value.Holiday_pay,
                    get.Value.Cash_advance,
                    get.Value.SSS_deduction,
                    get.Value.Phil_health,
                    get.Value.Deduction_1list,
                    get.Value.Deduction_1,
                    get.Value.Deduction_2list,
                    get.Value.Deduction_2,
                    get.Value.Deduction_3list,
                    get.Value.Deduction_3,
                    get.Value.Total_salary,
                    get.Value.Deduction_total,
                    get.Value.Netincome_total
                    );
                }

            }
            catch
            {
                MessageBox.Show("No Data To Be Retrieved");
            }
        }

    }
}
