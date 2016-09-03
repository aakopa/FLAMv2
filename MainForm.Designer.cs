namespace Freelancer_Account_Manager_v2
{
    partial class MainForm
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
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.accountTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataSet = new Freelancer_Account_Manager_v2.AccountDataSet();
            this.SignatureBox = new System.Windows.Forms.TextBox();
            this.ActivateButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AccountList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // CodeBox
            // 
            this.CodeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountTableBindingSource, "Code", true));
            this.CodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CodeBox.Location = new System.Drawing.Point(275, 43);
            this.CodeBox.Multiline = true;
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(263, 24);
            this.CodeBox.TabIndex = 1;
            this.CodeBox.Text = "Code";
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
            // SignatureBox
            // 
            this.SignatureBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountTableBindingSource, "Signature", true));
            this.SignatureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignatureBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SignatureBox.Location = new System.Drawing.Point(275, 86);
            this.SignatureBox.Multiline = true;
            this.SignatureBox.Name = "SignatureBox";
            this.SignatureBox.Size = new System.Drawing.Size(263, 24);
            this.SignatureBox.TabIndex = 2;
            this.SignatureBox.Text = "Signature";
            // 
            // ActivateButton
            // 
            this.ActivateButton.Location = new System.Drawing.Point(327, 125);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(159, 34);
            this.ActivateButton.TabIndex = 3;
            this.ActivateButton.Text = "Activate account";
            this.ActivateButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Manage accounts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccountList
            // 
            this.AccountList.AllowUserToAddRows = false;
            this.AccountList.AllowUserToDeleteRows = false;
            this.AccountList.AutoGenerateColumns = false;
            this.AccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.AccountList.DataSource = this.accountTableBindingSource;
            this.AccountList.Location = new System.Drawing.Point(12, 12);
            this.AccountList.Name = "AccountList";
            this.AccountList.ReadOnly = true;
            this.AccountList.Size = new System.Drawing.Size(241, 197);
            this.AccountList.TabIndex = 7;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 270);
            this.Controls.Add(this.AccountList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ActivateButton);
            this.Controls.Add(this.SignatureBox);
            this.Controls.Add(this.CodeBox);
            this.Name = "MainForm";
            this.Text = "Freelancer Account Manager v2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.TextBox SignatureBox;
        private System.Windows.Forms.Button ActivateButton;
        private System.Windows.Forms.BindingSource accountTableBindingSource;
        private AccountDataSet accountDataSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView AccountList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}

