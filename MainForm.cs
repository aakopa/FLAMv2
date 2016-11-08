using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace Freelancer_Account_Manager_v2
{
    public partial class MainForm : Form
    {

        

        public MainForm()
        {
            InitializeComponent();
            
        }

        static AccountDataSet db;

        protected static AccountDataSet App
        {
            get
            {
                if (db == null)
                    db = new AccountDataSet();
                return db;
            }
        }

        public void RefreshDataSet()
        {
            App.AccountTable.Clear();
            string fileName = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(fileName))
                App.AccountTable.ReadXml(fileName);
            accountTableBindingSource.DataSource = App.AccountTable;
            AccountList.Enabled = true;
            if(String.IsNullOrWhiteSpace(ImagePathStorage.Text))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.ImageLocation = ImagePathStorage.Text;
            }
            
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(fileName))
                App.AccountTable.ReadXml(fileName);
            accountTableBindingSource.DataSource = App.AccountTable;
            AccountList.Enabled = true;
            if (String.IsNullOrWhiteSpace(ImagePathStorage.Text))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.ImageLocation = ImagePathStorage.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountManagement AccMgmtFrm = new AccountManagement(this);
            AccMgmtFrm.Show();
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            RegistryKey RegKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft Games\Freelancer\1.0", true);
            RegKey.SetValue("MPAccountName", CodeBox.Text);
            RegKey.SetValue("MPAccountNameSig", SignatureBox.Text);
            RegKey.Close();
        }

        private void AccountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ImagePathStorage.Text))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.ImageLocation = ImagePathStorage.Text;
            }
        }
    }
}
