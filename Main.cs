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
    public partial class Main : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Jog1rY9wwqptLFXFOu8TesQ7MD6oKsK1y7UX3izC",
            BasePath = "https://test1-be77d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Main()
        {
            InitializeComponent();
        }

        private void emp_user_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }

        private void EmployeeList_Click(object sender, EventArgs e)
        {
            Employee frm = new Employee();
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

        private void Main_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            Listemp();
        }

        public void Listemp()
        {

            FirebaseResponse response = client.Get("Employees/");
            Dictionary<string, add_employee> getEmployee = response.ResultAs<Dictionary<string, add_employee>>();

            foreach (var get in getEmployee)
            {
                dataGridView1.Rows.Add(

                get.Value.ID,
                get.Value.Lastname,
                get.Value.Firstname,
                get.Value.Middlename,
                get.Value.Suffix,
                get.Value.Number,
                get.Value.Month,
                get.Value.Day,
                get.Value.Year,
                get.Value.Gender,
                get.Value.Email,
                get.Value.Status,
                get.Value.Address1,
                get.Value.Address2,
                get.Value.Barangay,
                get.Value.City,
                get.Value.Province,
                get.Value.Zipcode
                );
            }
        }
          
        


        private void button1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                int random = rand.Next(0, 100000);
                if (
                   String.IsNullOrWhiteSpace(lastname.Text) ||
                   String.IsNullOrWhiteSpace(firstname.Text) ||
                   String.IsNullOrWhiteSpace(middle.Text) ||
                   String.IsNullOrWhiteSpace(month.Text) ||
                   String.IsNullOrWhiteSpace(day.Text) ||
                   String.IsNullOrWhiteSpace(year.Text) ||
                   String.IsNullOrWhiteSpace(status.Text) ||
                   String.IsNullOrWhiteSpace(gender.Text) ||
                   String.IsNullOrWhiteSpace(barangay.Text) ||
                   String.IsNullOrWhiteSpace(city.Text) ||
                   String.IsNullOrWhiteSpace(state.Text) ||
                   String.IsNullOrWhiteSpace(zipcode.Text))
                {
                    MessageBox.Show("Please input all data needed");
                    return;
                }
                else
                {
                    add_employee add_new_emp = new add_employee()
                    {
                        ID = random.ToString(),
                        Lastname = lastname.Text,
                        Middlename = middle.Text,
                        Firstname = firstname.Text,
                        Suffix = suffix.Text,
                        Status = status.SelectedItem.ToString(),
                        Gender = gender.SelectedItem.ToString(),
                        Month = month.Text,
                        Day = day.Text,
                        Year = year.Text,
                        Number = number.Text,
                        Email = email.Text,
                        Address1 = street_address.Text,
                        Address2 = street_address2.Text,
                        Barangay = barangay.Text,
                        City = city.Text,
                        Province = state.Text,
                        Zipcode = zipcode.Text
                    };
                    FirebaseResponse response = client.Set("Employees/" + random.ToString(), add_new_emp);
                    MessageBox.Show("Employee Added.");
                }
            }
            catch { MessageBox.Show("Error"); }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            id.Text = "";
            firstname.Text = "";
            lastname.Text = "";
            middle.Text = "";
            suffix.Text = "";
            number.Text = "";
            month.Text = "";
            day.Text = "";
            year.Text = "";
            status.Text = "";
            gender.Text = "";
            email.Text = "";
            street_address.Text = "";
            street_address2.Text = "";
            barangay.Text = "";
            city.Text = "";
            state.Text = "";
            zipcode.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbox_ID.Text))
            {
                MessageBox.Show("Data seems to be empty.");
            }
            else
            {
                FirebaseResponse response = client.Get("Employees/" + txtbox_ID.Text);
                add_employee search = response.ResultAs<add_employee>();

                id.Text = search.ID;
                lastname.Text = search.Lastname;
                middle.Text = search.Middlename;
                firstname.Text = search.Firstname;
                suffix.Text = search.Suffix;
                number.Text = search.Number;
                month.Text = search.Month;
                day.Text = search.Day;
                year.Text = search.Year;
                gender.Text = search.Gender;
                suffix.Text = search.Suffix;
                email.Text = search.Email;
                street_address.Text = search.Address1;
                street_address2.Text = search.Address2;
                status.Text = search.Status;
                barangay.Text = search.Barangay;
                city.Text = search.City;
                state.Text = search.Province;
                zipcode.Text = search.Zipcode;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_employee add_new_emp = new add_employee()
            {
                ID = id.Text,
                Lastname = lastname.Text,
                Middlename = middle.Text,
                Firstname = firstname.Text,
                Suffix = suffix.Text,
                Status = status.SelectedItem.ToString(),
                Gender = gender.SelectedItem.ToString(),
                Month = month.Text,
                Day = day.Text,
                Year = year.Text,
                Number = number.Text,
                Email = email.Text,
                Address1 = street_address.Text,
                Address2 = street_address2.Text,
                Barangay = barangay.Text,
                City = city.Text,
                Province = state.Text,
                Zipcode = zipcode.Text
            };
            DialogResult dialog = MessageBox.Show("Are you sure you want to update?", "", MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:
                    //Update = Update Database
                    FirebaseResponse response1 = client.Update("Employees/" + id.Text, add_new_emp);
                    MessageBox.Show("User updated");
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
    }
}
    


