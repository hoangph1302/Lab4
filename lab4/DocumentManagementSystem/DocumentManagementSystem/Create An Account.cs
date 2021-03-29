using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DocumentManagementSystem
{
    public partial class Create_An_Account : Form
    {
        public Create_An_Account()
        {
            InitializeComponent();
        }

        private void Create_An_Account_Load(object sender, EventArgs e)
        {

        }

        // Check confirm
        private bool availableConfirm (string PW_, string confirm_)
        {
            if (PW_ == confirm_ && PW_ != "")
                return true;
            else return false;
        }

        // Check existence of Nickname
        private bool isNewNickname(string Nickname_)
        {
            using (StreamReader sr = new StreamReader("ListAccount.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (Nickname_ == inforUser(line)[3].ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Check existence of userID
        private bool isNewUserID(string userID_)
        {
            using (StreamReader sr = new StreamReader("ListAccount.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (userID_ == inforUser(line)[0].ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// Get infor of user
        /// inforAccount (index - attribute): 0 - ID,
        ///                                   1 - PW, 
        ///                                   2 - level, 
        ///                                   3 - nickname
        private object[] inforUser(string line_)
        {
            object[] infor = new object[4];
            int start = 0;
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                while (line_[index] != ' ') index++;
                infor[i] = line_.Substring(start, index - start);
                start = ++index;
            }
            return infor;
        }
        

        // Create radom ID User
        private string randomUserID()
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 78)));
            sb.Append(c);
            for (int i = 0; i < 5; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(48, 57)));
                sb.Append(c);
            }
            return sb.ToString();
        }

        // bt create an account
        private void btCreate_Click(object sender, EventArgs e)
        {
            string newUserID;
            do
            {
                newUserID = randomUserID();
            } while (isNewUserID(newUserID));
            if (isNewNickname(textBoxNickname.Text) && availableConfirm(textBoxPassword.Text, textBoxConfirm.Text))
            {
                
            }
        }

        // save new account
        private void saveAccount(string newAccount_)
        {
            
        }
    }
}
