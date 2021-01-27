using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll
{
    class add_user
    {
        private static string TheError = "Username Not Found";
        public string user_Name { get; set; }
        public string user_username { get; set; }
        public string user_password { get; set; }
        public string user_userlevel { get; set; }

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(TheError);
        }
        public static bool IsEqual(add_user user1, add_user user2)
        {
            if (user1 == null || user2 == null)
            {
                TheError = "Username Not Found";
                return false;
            }
            if (user1.user_username != user2.user_username)
            {
                TheError = "Username Not Found";
                return false;
            }
            else if (user1.user_password != user2.user_password)
            {
                TheError = "Username and Password not Match";
                return false;
            }
            return true;
        }
    }
}
