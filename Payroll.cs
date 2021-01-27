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
using FireSharp.Interfaces;
using FireSharp.Response;


namespace payroll
{
    public partial class Payroll : Form
    {
        double regeranday, nodays, regnohrs = 8, hrsot, holpayday;
        double Cash_a, deduc1, deduc2, deduc3;
        //Aron matawag ang database
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Jog1rY9wwqptLFXFOu8TesQ7MD6oKsK1y7UX3izC",
            BasePath = "https://test1-be77d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Payroll()
        {
            InitializeComponent();
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            Listemp();
        }
        public void Listemp()
        {

            FirebaseResponse response = client.Get("Employees/Salary/");
            Dictionary<string, add_employee> getEmployee = response.ResultAs<Dictionary<string, add_employee>>();

            foreach (var get in getEmployee)  
            {
                dataGridView1.Rows.Add(

                get.Value.ID,
                get.Value.Number_ofdays,
                get.Value.Regular_earningday,
                get.Value.Hourlyrate,
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

        private void button3_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }


        private void Employee_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }

        private void noofdays_TextChanged(object sender, EventArgs e)
        {
            if (noofdays.Text == "" || noofdays.Text == "0")
            {
                noofdays.Text = "0";

            }
        }

        private void othours_TextChanged(object sender, EventArgs e)
        {
            if (othours.Text == "" || othours.Text == "0")
            {
                othours.Text = "0";

            }
        }


        private void holpay_TextChanged(object sender, EventArgs e)
        {
            if (holpay.Text == "" || holpay.Text == "0")
            {
                holpay.Text = "0";

            }
        }

        private void cashadvance_TextChanged(object sender, EventArgs e)
        {
            if (cashadvance.Text == "" || cashadvance.Text == "0")
            {
                cashadvance.Text = "0";

            }
        }
        private void philhealth_TextChanged(object sender, EventArgs e)
        {
            if (philhealth.Text == "" || philhealth.Text == "0")
            {
                philhealth.Text = "0";

            }
        }

        private void deduction1_TextChanged(object sender, EventArgs e)
        {
            if (deduction1.Text == "" || deduction1.Text == "0")
            {
                deduction1.Text = "0";

            }
        }

        private void deduction2_TextChanged(object sender, EventArgs e)
        {
            if (deduction2.Text == "" || deduction2.Text == "0")
            {
                deduction2.Text = "0";

            }
        }

        private void deduction3_TextChanged(object sender, EventArgs e)
        {
            if (deduction3.Text == "" || deduction3.Text == "0")
            {
                deduction3.Text = "0";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payroll frm = new Payroll();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Deduction_sss_TextChanged(object sender, EventArgs e)
        {
            if (Deduction_sss.Text == "" || Deduction_sss.Text == "0")
            {
                Deduction_sss.Text = "0";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Update?","", MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:
                    var payroll = new add_employee
                    {
                        ID = id.Text,
                        Number_ofdays = noofdays.Text,
                        Regular_earningday = regularearningday.Text,
                        Hourlyrate = Hourly_rate.Text,
                        Overtime_hr = othours.Text,
                        Holiday_pay = holpay.Text,
                        Cash_advance = cashadvance.Text,
                        SSS_deduction = Deduction_sss.Text,
                        Phil_health = philhealth.Text,
                        Deduction_1list = deduc1list.Text,
                        Deduction_1 = deduction1.Text,
                        Deduction_2list = deduc2list.Text,
                        Deduction_2 = deduction2.Text,
                        Deduction_3list = deduc3list.Text,
                        Deduction_3 = deduction3.Text,
                        Total_salary = totsalary.Text,
                        Deduction_total = deduction_total.Text,
                        Netincome_total = netincome.Text
                        

                    };
                    FirebaseResponse response = client.Update("Empoyees/Salary/" + txtbox_ID.Text, payroll);
                    MessageBox.Show("Data Update Success");

                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            Listemp();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            add_employee add_new_emp = new add_employee()
            {
                ID = txtbox_ID.Text,
                Regular_earningday = regularearningday.Text,
                Number_ofdays = noofdays.Text,
                Hourlyrate = Hourly_rate.Text,
                Overtime_hr = othours.Text,
                Holiday_pay = holpay.Text,
                Cash_advance = cashadvance.Text,
                SSS_deduction = Deduction_sss.Text,
                Phil_health = philhealth.Text,
                Deduction_1list = deduc1list.Text,
                Deduction_2list = deduc2list.Text,
                Deduction_3list = deduc3list.Text,
                Deduction_1 = deduction1.Text,
                Deduction_2 = deduction2.Text,
                Deduction_3 = deduction3.Text,
                Deduction_total = deduction_total.Text,
                Total_salary = grossincome.Text,
                Netincome_total = netincome.Text

            };
            FirebaseResponse response1 = client.Set("Employees/Salary/" + txtbox_ID.Text, add_new_emp);
            MessageBox.Show("Succesful.");    
            }
        private void button5_Click_1(object sender, EventArgs e)
        {
            regeranday = double.Parse(regularearningday.Text);
            nodays = double.Parse(noofdays.Text);
            hrsot = double.Parse(othours.Text);
            holpayday = double.Parse(holpay.Text);
            Cash_a = double.Parse(cashadvance.Text);
          //  SSS = double.Parse(Deduction_sss.Text);
           // phil_health = double.Parse(philhealth.Text);
            deduc1 = double.Parse(deduction1.Text);
            deduc2 = double.Parse(deduction2.Text);
            deduc3 = double.Parse(deduction3.Text);

            double totalsalary = regeranday * nodays;
            double hourlyrate = totalsalary / regnohrs;
            double othrstotal = hourlyrate * hrsot;
            double SSS_rate_total = totalsalary * 0.13;
            double Phic_rate_total = totalsalary * 0.03;
            if (holpayday == 0)
            {
                double totalholpay = 0;
                double grosstotalincome = totalsalary + othrstotal + totalholpay;
                grossincome.Text = Convert.ToString(grosstotalincome);
                totsalary.Text = Convert.ToString(totalsalary);
                double Deduction_sum = Cash_a + SSS_rate_total + Phic_rate_total + deduc1 + deduc2 + deduc3;
                deduction_total.Text = Convert.ToString(Deduction_sum);
                double total_netincome = grosstotalincome - Deduction_sum;
                netincome.Text = Convert.ToString(total_netincome);
                Hourly_rate.Text = Convert.ToString(hourlyrate);
                Deduction_sss.Text = Convert.ToString(SSS_rate_total);
                philhealth.Text = Convert.ToString(Phic_rate_total);
            }
            else
            {

                double totalholpay = regeranday * 2;
                double grosstotalincome = totalsalary + othrstotal + totalholpay;
                grossincome.Text = Convert.ToString(grosstotalincome);
                totsalary.Text = Convert.ToString(totalsalary);
                double Deduction_sum = Cash_a + SSS_rate_total + Phic_rate_total + deduc1 + deduc2 + deduc3;
                deduction_total.Text = Convert.ToString(Deduction_sum);
                double total_netincome = grosstotalincome - Deduction_sum;
                netincome.Text = Convert.ToString(total_netincome);
                Hourly_rate.Text = Convert.ToString(hourlyrate);
                Deduction_sss.Text = Convert.ToString(SSS_rate_total);
                philhealth.Text = Convert.ToString(Phic_rate_total);
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbox_ID.Text))
            {
                MessageBox.Show("Data seems to be empty.");
            }
            else
            {
                FirebaseResponse response = client.Get("Employees/Salary/" + txtbox_ID.Text);
                add_employee search = response.ResultAs<add_employee>();

                id.Text = search.ID;
                regularearningday.Text = search.Regular_earningday;
                noofdays.Text = search.Number_ofdays;
                Hourly_rate.Text = search.Hourlyrate;
                totsalary.Text = search.Total_salary;
                othours.Text = search.Overtime_hr;
                holpay.Text = search.Holiday_pay;
                grossincome.Text = search.Gross_income;
                cashadvance.Text = search.Cash_advance;
                Deduction_sss.Text = search.SSS_deduction;
                philhealth.Text = search.Phil_health;
                deduction1.Text = search.Deduction_1;
                deduction2.Text = search.Deduction_2;
                deduction3.Text = search.Deduction_3;
                deduction_total.Text = search.Deduction_total;
                netincome.Text = search.Netincome_total;

            }
        }
       
        
    }

}



 
