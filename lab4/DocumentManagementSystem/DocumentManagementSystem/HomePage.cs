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
using System.Diagnostics;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;


namespace DocumentManagementSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // Constans
        const string pathResourseDocument = @"D:\izuchat\Ky 3\защищенный документ\LAB4\ComputerServer\All permission";
        const string FolderFileCmt = @"D:\izuchat\Ky 3\защищенный документ\LAB4\ComputerServer\SourceCmtFile\";

        // Open a new window for user
        string ID;
        string leveluser;
        string Nickname;
        int numbersharedDocument;
        string[] sharedDocumentsLineInfor = new string[100];
        public HomePage(string ID_, string level_, string Nickname_) : this()
        {
            ID = ID_;
            leveluser = level_;
            Nickname = Nickname_;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            AddSharedFiles();
            if (leveluser == "9")
                managerToolStripMenuItem.Visible = true;
        }

        // Check file if is shared with me
        private string isSharedWithMe(string documentID_)
        {
            using (StreamReader sr = new StreamReader("ListDocuments.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (leveluser == "9" && getInforDocument(line)[0].ToString() == documentID_)
                        return line;
                    else
                    {
                        string levelDocument = getInforDocument(line)[1].ToString();
                        if ((getInforDocument(line)[0].ToString() == documentID_ && (Convert.ToInt32(leveluser) + 1) / 2 == Convert.ToInt32(levelDocument))) // || (ID == getInforDocument(line)[2].ToString())
                        {
                            return line;
                        }
                    }
                    
                }

            }
            return "Is not shared";
        }

        /// Get information of Document form file ListDocuments.txt
        /// index - attribute: 0 - documentID
        ///                    1 - levelDocument
        ///                    2 - ID of Author
        ///                    3 - name of file
        ///                    4 - file comments
        private object[] getInforDocument(string line_)
        {
            object[] infor = new object[4];
            int index = 0;
            int start = 0;
            for (int i = 0; i < 4; i++)
            {
                while (line_[index] != ' ') index++;
                infor[i] = line_.Substring(start, index - start);
                start = ++index;
            }
            return infor;
        }

        // Create list shared documents
        private void CreateListDocuments()
        {
            numbersharedDocument = 0;
            // Open folder
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = pathResourseDocument;
            var files = Directory.GetFiles(fbd.SelectedPath);

            // Find shared files
            foreach (string file in files)
            {

                string inforOpenedFile = isSharedWithMe(Path.GetFileNameWithoutExtension(file));
               
                
                if (inforOpenedFile != "Is not shared")
                {
                    sharedDocumentsLineInfor[numbersharedDocument++] = inforOpenedFile;
                }
                else
                {
                    inforOpenedFile = isOwner(Path.GetFileNameWithoutExtension(file));
                    if (inforOpenedFile != "Is not owner")
                    {
                        sharedDocumentsLineInfor[numbersharedDocument++] = inforOpenedFile;
                    }
                }
            }
        }

        // Add shared Files into Listview
        private void AddSharedFiles()
        {
            CreateListDocuments();
            // Add Columns Header
            listView1.Clear();
            listView1.Columns.Add("File name: ", 300);
            listView1.Columns.Add("Author: ", 300);

            // Add list files
            for (int i = 0; i < numbersharedDocument; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = getInforDocument(sharedDocumentsLineInfor[i])[3].ToString();
                item.SubItems.Add(authorOf(sharedDocumentsLineInfor[i]));
                listView1.Items.Add(item);
            }
        }

        // Get Author of file
        private string authorOf(string lineInforDocument_)
        {
            using (StreamReader sr = new StreamReader("ListAccount.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (inforUser(line)[0].ToString() == getInforDocument(lineInforDocument_)[2].ToString())
                    {
                        return inforUser(line)[3].ToString();
                    }

                }
            }
            return null;
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

        private void btCmt_Click(object sender, EventArgs e)
        {
            if (textBoxCmt.Text != "")
            {
                textBoxListCmt.Text += "\r\n" + Nickname + ": " + textBoxCmt.Text;
                saveCmt(selectedFileName);
                textBoxCmt.Clear();
            }
            
        }
        
        // get selected File
        string selectedFileName;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = listView1.FocusedItem.Index;
            selectedFileName = getDocumentID(listView1.Items[i].SubItems[0].Text);
        }

        // Get ID from FileName
        private string getDocumentID(string fileName_)
        {
            using (StreamReader sr = new StreamReader("ListDocuments.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (fileName_ == getInforDocument(line)[3].ToString())
                    {
                        return getInforDocument(line)[0].ToString() + Path.GetExtension(getInforDocument(line)[3].ToString());
                    }
                }
            }
            return null;
        }

        // Open File (button)
        private void btOpenFile_Click(object sender, EventArgs e)
        {
            switch(Path.GetExtension(selectedFileName))
            {
                case ".pdf":
                    {
                        // Open screen to display file
                        { axAcroPDF1.Visible = true; btDownload.Visible = true; btClose.Visible = true; btReload.Visible = true; }
                        { textBoxCmt.Visible = true; textBoxListCmt.Visible = true; btCmt.Visible = true;}
                        axAcroPDF1.src = pathResourseDocument + @"\" + selectedFileName;
                        // Display comments
                        displayComments(selectedFileName);
                        break;
                    }
                case ".docx":
                    {
                        // Open screen to display file
                        { axAcroPDF1.Visible = true; btDownload.Visible = true; btClose.Visible = true; btEdit.Visible = true; btReload.Visible = true; }
                        { textBoxCmt.Visible = true; textBoxListCmt.Visible = true; btCmt.Visible = true; }
                        // Create a new file PDF (convert from Word
                        ConvertWordToPDF(selectedFileName);
                        // Open file Word as PDF
                        axAcroPDF1.src = pathResourseDocument + @"\" + Path.GetFileNameWithoutExtension(selectedFileName) + ".pdf";
                        File.Delete(pathResourseDocument + @"\" + Path.GetFileNameWithoutExtension(selectedFileName) + ".pdf");
                        // Display comments
                        displayComments(selectedFileName);
                        break;
                    }
                case ".xlsx":
                    {
                        // Hien thi hop thoai mo tep tin
                        { axAcroPDF1.Visible = true; btClose.Visible = true; btDownload.Visible = true; btEdit.Visible = true; btReload.Visible = true; }
                        { textBoxCmt.Visible = true; textBoxListCmt.Visible = true; btCmt.Visible = true; }
                        // Create a new file PDF (convert from word)
                        ConvertExcelToPDF(selectedFileName);
                        // Open file Word as PDF
                        axAcroPDF1.src = pathResourseDocument + @"\" + Path.GetFileNameWithoutExtension(selectedFileName) + ".pdf";
                        File.Delete( pathResourseDocument + @"\" + Path.GetFileNameWithoutExtension(selectedFileName) + ".pdf");
                        // Display comments
                        displayComments(selectedFileName);
                        break;
                    }
                case ".jpg": case ".png":
                    {
                        // Hien thi hop thoai mo tep tin
                        { pictureBox1.Visible = true; btClose.Visible = true; btDownload.Visible = true; btReload.Visible = true; }
                        { textBoxCmt.Visible = true; textBoxListCmt.Visible = true; btCmt.Visible = true; }
                        pictureBox1.Image = System.Drawing.Image.FromFile( pathResourseDocument + @"\" + selectedFileName);
                        // Display comments
                        displayComments(selectedFileName);
                        break;
                    }
                default:
                    break;
            }
        }

        // Convert to PDF from Word
        private void ConvertWordToPDF(string fileName_)
        {
            object inputFilePathWord = pathResourseDocument + @"\" + fileName_;
            object outputFilePathPDF = pathResourseDocument + @"\" + Path.GetFileNameWithoutExtension(fileName_) + ".pdf";

            Word.Application wordApp = new Word.Application();
            object oMissing = System.Reflection.Missing.Value;
            object fileFormat = Word.WdSaveFormat.wdFormatPDF;

            Word.Document doc = wordApp.Documents.Open(ref inputFilePathWord, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            doc.Activate();
            doc.SaveAs2(ref outputFilePathPDF,
                            ref fileFormat, ref oMissing, ref oMissing,
                            ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                            ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            object saveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
            if (doc != null)
                ((Word._Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
            wordApp.Quit(ref saveChanges, ref oMissing, ref oMissing);
        }
        

        private void btClose_Click_1(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = false;
            pictureBox1.Visible = false;
            btEdit.Visible = false;
            btDownload.Visible = false;
            btClose.Visible = false;
            btReload.Visible = false;
            textBoxListCmt.Clear();
            { textBoxCmt.Visible = false; textBoxListCmt.Visible = false; btCmt.Visible = false; }
        }

        // Convert to PDF from Excel
        private void ConvertExcelToPDF(string fileName_)
        {
            string inputFilePathExcel = pathResourseDocument + @"\" + fileName_;
            string outputFilePathPDF = pathResourseDocument + @"\" + Path.GetFileNameWithoutExtension(fileName_) + ".pdf";
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook wb = excelApp.Workbooks.Open(inputFilePathExcel);
            wb.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, outputFilePathPDF);
            wb.Close();
            excelApp.Quit();
        }

        // Download File
        private void btDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.InitialDirectory = @"D:\Download Sourse";
            fsave.DefaultExt = Path.GetExtension(selectedFileName);
            fsave.ShowDialog();
            if (fsave.FileName != "")
                File.Copy(pathResourseDocument + @"\" + selectedFileName, fsave.FileName);
        }

        // Button edit document
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (enableEditingDoc(selectedFileName))
                System.Diagnostics.Process.Start(pathResourseDocument + @"\" + selectedFileName);
            else
                MessageBox.Show("You can not edit file!");
        }

        // Check if enable editing
        private bool enableEditingDoc(string selectedFileName_)
        {
            string levelDocument_ = null;
            using (StreamReader sr = new StreamReader("ListDocuments.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    if (getInforDocument(line)[0].ToString() == Path.GetFileNameWithoutExtension(selectedFileName_))
                    {
                        levelDocument_ = getInforDocument(line)[1].ToString();
                        break;
                    }
                }
            }

            if (Convert.ToInt32(levelDocument_) * 2 == Convert.ToInt32(leveluser) || isOwner(Path.GetFileNameWithoutExtension(selectedFileName_)) != "Is not owner")
                return true;
            else return false;
        }

        private void createANewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            { groupBoxUpload.Visible = true; comboBoxGroup.SelectedIndex = 3; }
        }

        // Check if you are owner of file
        private string isOwner(string FileNameWithoutExtension_)
        {
            using (StreamReader sr = new StreamReader("ListDocuments.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (getInforDocument(line)[0].ToString() == FileNameWithoutExtension_)
                        if (getInforDocument(line)[2].ToString() == ID)
                        {
                            return line;
                        }
                }
            }
            return "Is not owner";
        }

        // Upload file
        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.ShowDialog();
            textBoxPath.Text = fopen.FileName;
            textBoxFileName.Text = Path.GetExtension(fopen.FileName);
        }

        // Display cmts
        private void displayComments(string fileName_)
        {
            using (StreamReader sr = new StreamReader(FolderFileCmt + Path.GetFileNameWithoutExtension(selectedFileName) + ".txt"))
            {
                string line;
                string text = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    text += "\r\n" + line;
                }
                textBoxListCmt.Text = text;
            }
        }

        // Save comment
        private void saveCmt(string fileName_)
        {
            string text = null;
            using (StreamReader sr = new StreamReader(FolderFileCmt + Path.GetFileNameWithoutExtension(selectedFileName) + ".txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    text += line + "\r\n";
                }
            }
            text += Nickname + ":" + textBoxCmt.Text;
            string path_ = FolderFileCmt + Path.GetFileNameWithoutExtension(selectedFileName) + ".txt";
            File.WriteAllText(path_, text);
        }

        // Upload file
        private void btUpload_Click(object sender, EventArgs e)
        {
            if (Path.GetFileNameWithoutExtension(textBoxFileName.Text) != "" && textBoxPath.Text != "")
            {
                // Create random ID document
                string newIDdocument;
                do
                {
                    newIDdocument = randomIDdocument();
                } while (isExistIDdocument(newIDdocument));
                // Add file to Listdocument.txt
                string lineInfor_ = newIDdocument;
                string levelDoc;
                switch (comboBoxGroup.Text)
                {
                    ///  not share
                    case "group 1":
                        levelDoc = "1";
                        break;
                    case "group 2":
                        levelDoc = "2";
                        break;
                    case "group 3":
                        levelDoc = "3";
                        break;
                    default:
                        levelDoc = "9";
                        break;
                }
                lineInfor_ += " " + levelDoc + " " + ID + " " + textBoxFileName.Text;
                using (StreamWriter sw = new StreamWriter("ListDocuments.txt", true))
                {
                    sw.Write("\r\n" + lineInfor_ + " ");
                }
                // Create file comments
                using (File.Create(FolderFileCmt + newIDdocument + ".txt"));
                // Add document to source
                File.Copy(textBoxPath.Text, pathResourseDocument + "\\" + newIDdocument + Path.GetExtension(textBoxPath.Text));
                MessageBox.Show("Complete upload");
                // Close windows UploadFile
                { textBoxPath.Clear(); textBoxFileName.Clear();}
                groupBoxUpload.Visible = false;
                // Refresh listView1
                AddSharedFiles();
            }
            else MessageBox.Show("Please fill out all information!");
        }

        // Create radom ID document
        private string randomIDdocument()
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

        // Check if ID document exist
        private bool isExistIDdocument(string IDdocument_)
        {
            using (StreamReader sr = new StreamReader("ListDocuments.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string existID = getInforDocument(line)[0].ToString();
                    if (IDdocument_ == existID)
                        return true;
                }
            }
            return false;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
           
        }

        // Change permission (Buttons)
        private void forGroup3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePermissionFileTo("3");
        }
        private void forGroup2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePermissionFileTo("2");
        }
        private void forGroup1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePermissionFileTo("1");
        }
        private void privateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePermissionFileTo("9");
        }

        // change current permission of file to 1 (2, 3, private)
        private void changePermissionFileTo(string group)
        {
            string content;
            string oldLine = null, line;
            using (StreamReader sr = new StreamReader("ListDocuments.txt"))
            {
                content = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader("ListDocuments.txt"))
            {
                //string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (Path.GetFileNameWithoutExtension(selectedFileName) == getInforDocument(line)[0].ToString())
                        oldLine = line;
                }
            }

            string newLine = oldLine.Replace(" " + getInforDocument(oldLine)[1].ToString() + " ", " " + group + " ");
            content = content.Replace(oldLine, newLine);

            using (StreamWriter sw = new StreamWriter("ListDocuments.txt"))
            {
                sw.Write(content);
                MessageBox.Show("Changed permission!", "Completed");
            }
        }

        // Refresh list Document in listView
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateListDocuments();
            AddSharedFiles();
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete(selectedFileName);
            CreateListDocuments();
            AddSharedFiles();
        }

        // Function Delete a File
        private void delete(string fileName_)
        {
            // Delete in file ListDocuments
            string oldLine = null;
            string content;
            using (StreamReader sr = new StreamReader("ListDocuments.txt"))
            {
                content = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader("ListDocuments.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (Path.GetFileNameWithoutExtension(fileName_) == getInforDocument(line)[0].ToString())
                        oldLine = line;
                }
            }
            content = content.Replace("\r\n" + oldLine, null);

            using (StreamWriter sw = new StreamWriter("ListDocuments.txt"))
            {
                sw.Write(content);
            }

            // Delete file Commnent
            File.Delete(FolderFileCmt + Path.GetFileNameWithoutExtension(fileName_) + ".txt");

            // Delete file
            File.Delete(pathResourseDocument + "\\" + fileName_);
        }

        private void changePermissionOfUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagementPermissionUsers MPU = new ManagementPermissionUsers();
            MPU.Show();
        }
    }
}
