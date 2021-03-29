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
    public partial class ManagementPermissionUsers : Form
    {
        public ManagementPermissionUsers()
        {
            InitializeComponent();
        }


        private void ManagementPermissionUsers_Load(object sender, EventArgs e)
        {
            CreatListUser();
            ListUsers();
        }

        int numberUsers = 0;
        string[] Users = new string[100];
        string selectedUserID = null;

        // Add shared Files into Listview
        private void ListUsers()
        {
            // Add Columns Header
            listView1.Clear();
            listView1.Columns.Add("ID: ", 130);
            listView1.Columns.Add("NickName: ", 170);
            listView1.Columns.Add("Group: ", 80);
            listView1.Columns.Add("Enable Editing", 100);
            
            // Add Users
            for (int i = 0; i < numberUsers; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = inforUser(Users[i])[0].ToString();
                item.SubItems.Add(inforUser(Users[i])[3].ToString());
                switch (inforUser(Users[i])[2].ToString())
                {
                    case "1": case "2":
                        item.SubItems.Add("1");
                        break;
                    case "3": case "4":
                        item.SubItems.Add("2");
                        break;
                    case "5": case "6":
                        item.SubItems.Add("3");
                        break;
                }
                if (Convert.ToInt32(inforUser(Users[i])[2].ToString()) % 2 == 0)
                {
                    item.SubItems.Add("x");
                }
                listView1.Items.Add(item);
            }
        }

        /// Get infor of user
        /// inforAccount (index - attribute): 0 - ID,
        ///                                   1 - PW, 
        ///                                   2 - level, 
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

        // Create list users
        private void CreatListUser()
        {
            numberUsers = 0;
            using (StreamReader sr = new StreamReader("ListAccount.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (inforUser(line)[2].ToString() != "9")
                        Users[numberUsers++] = line;
                }
            }
        }
        // Test code
        private void CreatListUser2()
        {
            numberUsers = 0;
            using (StreamReader sr = new StreamReader("ListAccount2.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (inforUser(line)[2].ToString() != "9")
                        Users[numberUsers++] = line;
                }
            }
        }

        // Change permission 
        private void changePermissionTo(string userID_, string newLevel_)
        {
            string content = null;
            string oldLine = null, newLine = null;
            using (StreamReader sr = new StreamReader("ListAccount.txt"))
            {
                content = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader("ListAccount.txt"))
            {
                string line;
                while ((line =sr.ReadLine()) != null)
                {
                    if (inforUser(line)[0].ToString() == userID_)
                    {
                        oldLine = line;
                    }
                }
            }
            newLine = oldLine.Replace(" " + inforUser(oldLine)[2].ToString() + " ", " " + newLevel_ + " ");
            content = content.Replace(oldLine, newLine);
            using (StreamWriter sw = new StreamWriter("ListAccount.txt"))
            {
                sw.Write(content);
            }
            CreatListUser();
            ListUsers();
        }

        // Delete User
        private void deleteUser(string userID_)
        {
            string content = null;
            string oldLine = null, newLine = null;
            using (StreamReader sr = new StreamReader("ListAccount.txt"))
            {
                content = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader("ListAccount.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (inforUser(line)[0].ToString() == userID_)
                    {
                        oldLine = line;
                    }
                }
            }
            content = content.Replace("\r\n" + oldLine, null);

            using (StreamWriter sw = new StreamWriter("ListAccount.txt"))
            {
                sw.Write(content);
            }
            CreatListUser();
            ListUsers(); 
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listView1.FocusedItem.Index;
            selectedUserID = listView1.Items[index].SubItems[0].Text.ToString();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            changePermissionTo(selectedUserID, "2");
        }

        private void toolChangeToGroup2_Click(object sender, EventArgs e)
        {
            changePermissionTo(selectedUserID, "2");
        }

        private void toopEnableEdittingGroup1_Click(object sender, EventArgs e)
        {
            changePermissionTo(selectedUserID, "2");
        }

        private void toopUnableEdittingGroup1_Click(object sender, EventArgs e)
        {
            changePermissionTo(selectedUserID, "1");
        }

        private void toopEnableEdittingGroup2_Click(object sender, EventArgs e)
        {
            changePermissionTo(selectedUserID, "4");
        }

        private void toopUnableEdittingGroup2_Click(object sender, EventArgs e)
        {
            changePermissionTo(selectedUserID, "3");
        }

        private void toopEnableEdittingGroup3_Click(object sender, EventArgs e)
        {
            changePermissionTo(selectedUserID, "6");
        }

        private void toopUnableEdittingGroup3_Click(object sender, EventArgs e)
        {
            changePermissionTo(selectedUserID, "5");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteUser(selectedUserID);
        }
    }
}
