namespace Freelancer_Account_Manager_v2
{
    partial class AccountManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NewAccount = new System.Windows.Forms.Button();
            this.EditAccount = new System.Windows.Forms.Button();
            this.SaveAccount = new System.Windows.Forms.Button();
            this.NameEdit = new System.Windows.Forms.TextBox();
            this.accountTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataSet = new Freelancer_Account_Manager_v2.AccountDataSet();
            this.CodeEdit = new System.Windows.Forms.TextBox();
            this.SignatureEdit = new System.Windows.Forms.TextBox();
            this.AccountListEdit = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountListEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // NewAccount
            // 
            this.NewAccount.Location = new System.Drawing.Point(12, 308);
            this.NewAccount.Name = "NewAccount";
            this.NewAccount.Size = new System.Drawing.Size(96, 29);
            this.NewAccount.TabIndex = 0;
            this.NewAccount.Text = "New";
            this.NewAccount.UseVisualStyleBackColor = true;
            this.NewAccount.Click += new System.EventHandler(this.NewAccount_Click);
            // 
            // EditAccount
            // 
            this.EditAccount.Location = new System.Drawing.Point(114, 308);
            this.EditAccount.Name = "EditAccount";
            this.EditAccount.Size = new System.Drawing.Size(96, 29);
            this.EditAccount.TabIndex = 4;
            this.EditAccount.Text = "Edit";
            this.EditAccount.UseVisualStyleBackColor = true;
            this.EditAccount.Click += new System.EventHandler(this.EditAccount_Click);
            // 
            // SaveAccount
            // 
            this.SaveAccount.Location = new System.Drawing.Point(216, 308);
            this.SaveAccount.Name = "SaveAccount";
            this.SaveAccount.Size = new System.Drawing.Size(96, 29);
            this.SaveAccount.TabIndex = 5;
            this.SaveAccount.Text = "Save";
            this.SaveAccount.UseVisualStyleBackColor = true;
            this.SaveAccount.Click += new System.EventHandler(this.SaveAccount_Click);
            // 
            // NameEdit
            // 
            this.NameEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountTableBindingSource, "Name", true));
            this.NameEdit.Location = new System.Drawing.Point(67, 218);
            this.NameEdit.Multiline = true;
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Size = new System.Drawing.Size(245, 24);
            this.NameEdit.TabIndex = 6;
            // 
            // accountTableBindingSource
            // 
            this.accountTableBindingSource.DataMember = "AccountTable";
            this.accountTableBindingSource.DataSource = this.accountDataSet;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CodeEdit
            // 
            this.CodeEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountTableBindingSource, "Code", true));
            this.CodeEdit.Location = new System.Drawing.Point(67, 248);
            this.CodeEdit.Multiline = true;
            this.CodeEdit.Name = "CodeEdit";
            this.CodeEdit.Size = new System.Drawing.Size(245, 24);
            this.CodeEdit.TabIndex = 7;
            // 
            // SignatureEdit
            // 
            this.SignatureEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountTableBindingSource, "Signature", true));
            this.SignatureEdit.Location = new System.Drawing.Point(67, 278);
            this.SignatureEdit.Multiline = true;
            this.SignatureEdit.Name = "SignatureEdit";
            this.SignatureEdit.Size = new System.Drawing.Size(245, 24);
            this.SignatureEdit.TabIndex = 8;
            // 
            // AccountListEdit
            // 
            this.AccountListEdit.AllowUserToAddRows = false;
            this.AccountListEdit.AutoGenerateColumns = false;
            this.AccountListEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountListEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.signatureDataGridViewTextBoxColumn});
            this.AccountListEdit.DataSource = this.accountTableBindingSource;
            this.AccountListEdit.Location = new System.Drawing.Point(12, 12);
            this.AccountListEdit.Name = "AccountListEdit";
            this.AccountListEdit.Size = new System.Drawing.Size(300, 188);
            this.AccountListEdit.TabIndex = 9;
            this.AccountListEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccountListEdit_KeyDown);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 343);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(300, 28);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sig";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Code";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 157;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Visible = false;
            // 
            // signatureDataGridViewTextBoxColumn
            // 
            this.signatureDataGridViewTextBoxColumn.DataPropertyName = "Signature";
            this.signatureDataGridViewTextBoxColumn.HeaderText = "Signature";
            this.signatureDataGridViewTextBoxColumn.Name = "signatureDataGridViewTextBoxColumn";
            this.signatureDataGridViewTextBoxColumn.Visible = false;
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AccountListEdit);
            this.Controls.Add(this.SignatureEdit);
            this.Controls.Add(this.CodeEdit);
            this.Controls.Add(this.NameEdit);
            this.Controls.Add(this.SaveAccount);
            this.Controls.Add(this.EditAccount);
            this.Controls.Add(this.NewAccount);
            this.MaximizeBox = false;
            this.Name = "AccountManagement";
            this.Text = "AccountManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountManagement_FormClosed);
            this.Load += new System.EventHandler(this.AccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountListEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewAccount;
        private System.Windows.Forms.Button SaveAccount;
        private System.Windows.Forms.TextBox NameEdit;
        private System.Windows.Forms.TextBox CodeEdit;
        private System.Windows.Forms.TextBox SignatureEdit;
        private System.Windows.Forms.Button EditAccount;
        private System.Windows.Forms.DataGridView AccountListEdit;
        private System.Windows.Forms.BindingSource accountTableBindingSource;
        private AccountDataSet accountDataSet;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn signatureDataGridViewTextBoxColumn;
    }
}