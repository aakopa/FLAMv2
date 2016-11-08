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

namespace Freelancer_Account_Manager_v2
{
    public partial class AccountManagement : Form
    {
        private readonly MainForm _mainForm;

        public AccountManagement( MainForm mainForm )
        {
            InitializeComponent();
            this._mainForm = mainForm;
        }

        private void NewAccount_Click(object sender, EventArgs e)
        {
            try
            {
                AccountListEdit.Enabled = true;
                App.AccountTable.AddAccountTableRow(App.AccountTable.NewAccountTableRow());
                accountTableBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.AccountTable.RejectChanges();
            }
        }

        private void EditAccount_Click(object sender, EventArgs e)
        {
         
           

        }

        private void SaveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                accountTableBindingSource.EndEdit();
                App.AccountTable.AcceptChanges();
                App.AccountTable.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.AccountTable.RejectChanges();
            }
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

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            App.AccountTable.Clear();
            string fileName = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(fileName))
                App.AccountTable.ReadXml(fileName);
            accountTableBindingSource.DataSource = App.AccountTable;
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            accountTableBindingSource.ResetBindings(false);
            
        }

        private void AccountListEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                accountTableBindingSource.RemoveCurrent();
            }
        }

         

        private void AccountManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._mainForm.RefreshDataSet();
        }

        private void BrowseImages_Click(object sender, EventArgs e)
        {
            LoadNewImage();
        }

        private void LoadNewImage()
        {
            OpenFileDialog BrowserDialog = new OpenFileDialog();
            System.Windows.Forms.DialogResult dr = BrowserDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath = BrowserDialog.FileName;
            }
        }

        public string userSelectedFilePath
        {
            get
            {
                return ImageLocation.Text;
            }
            set
            {
                ImageLocation.Text = value;
            }
        }

        
    }
}
