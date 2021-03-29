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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string ID;
        string PW;
        string NickName;
        string leverUser;

        private void btLogin_Click(object sender, EventArgs e)
        {
            ID = textBoxID.Text;
            PW = textBoxPW.Text;
            if (availableAccount(ID, PW))
            {
                HomePage page = new HomePage(ID, leverUser, NickName);
                page.Show();
                lbWrongAccount.Visible = false;
            }
            else lbWrongAccount.Visible = true;
            deleteTextboxes();
        }

       private bool availableAccount(string ID_, string PW_)
        {
            using (StreamReader sr = new StreamReader("ListAccount.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string oneID = InforAccount(line)[0].ToString();
                    string onePW = InforAccount(line)[1].ToString();
                   // Compare ID and Password
                   if (ID_ == oneID && PW_ == onePW)
                    {
                        leverUser = InforAccount(line)[2].ToString();
                        NickName = InforAccount(line)[3].ToString();
                        return true;
                    }
                }
            }
            return false;
        }

        /// Get information of account from lines in file text
        /// inforAccount (index - attribute): 0 - ID,
        ///                                   1 - PW, 
        ///                                   2 - level, 
        ///                                   3 - NickName
        private object[] InforAccount (string line_)
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

        // Delete textboxes
        private void deleteTextboxes()
        {
            textBoxID.Text = null;
            textBoxPW.Text = null;
        }

        private void btCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
