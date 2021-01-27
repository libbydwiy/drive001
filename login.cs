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
    public partial class login : Form
    {
        //Unsa nga realtime database account
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Jog1rY9wwqptLFXFOu8TesQ7MD6oKsK1y7UX3izC",
            BasePath = "https://test1-be77d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //realtime database value
            client = new FireSharp.FirebaseClient(config);
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            try
            {
                //Login ni okay?
                if (String.IsNullOrWhiteSpace(login_username.Text) || String.IsNullOrWhiteSpace(login_password.Text))
                {
                    //Authenticate if naa bay gsuwat sa textbox
                    MessageBox.Show("Please input the data needed.");
                    return;
                }
                else
                {
                    //gikuha ang nag match nga data sa database
                    FirebaseResponse response = client.Get("PayrollDB/Table/Users/" + login_username.Text);
                    add_user respo = response.ResultAs<add_user>();
                    add_user authenticate = new add_user()
                    {
                        user_username = login_username.Text,
                        user_password = login_password.Text
                    };
                    if (add_user.IsEqual(respo, authenticate))
                    {
                        this.Hide();
                        Main m = new Main();
                        m.ShowDialog();
                    }
                    else
                    {
                        add_user.ShowError();
                    }
                }
            } 
            catch
            {
                MessageBox.Show("Error No Username Found");
            }

        }
    
            
        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}