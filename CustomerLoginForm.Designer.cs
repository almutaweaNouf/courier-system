namespace Project
{
    partial class CustomerLoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.customerCPRLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerCPRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDatabaseDataSet = new Project.customerDatabaseDataSet();
            this.customerTableAdapter = new Project.customerDatabaseDataSetTableAdapters.CustomerTableAdapter();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(249, 177);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(63, 27);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.checkBoxHide);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.customerIdTextBox);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.customerCPRLabel);
            this.loginPanel.Location = new System.Drawing.Point(13, 55);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(299, 116);
            this.loginPanel.TabIndex = 1;
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.AutoSize = true;
            this.checkBoxHide.Location = new System.Drawing.Point(228, 83);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(53, 17);
            this.checkBoxHide.TabIndex = 2;
            this.checkBoxHide.Text = "Show";
            this.checkBoxHide.UseVisualStyleBackColor = true;
            this.checkBoxHide.CheckedChanged += new System.EventHandler(this.checkBoxHide_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(142, 57);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(139, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerIdTextBox.Location = new System.Drawing.Point(142, 20);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(139, 20);
            this.customerIdTextBox.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordLabel.Location = new System.Drawing.Point(17, 53);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password ";
            // 
            // customerCPRLabel
            // 
            this.customerCPRLabel.AutoSize = true;
            this.customerCPRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customerCPRLabel.Location = new System.Drawing.Point(17, 19);
            this.customerCPRLabel.Name = "customerCPRLabel";
            this.customerCPRLabel.Size = new System.Drawing.Size(76, 13);
            this.customerCPRLabel.TabIndex = 6;
            this.customerCPRLabel.Text = "Customer CPR";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.InstructionLabel.Location = new System.Drawing.Point(10, 218);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(307, 17);
            this.InstructionLabel.TabIndex = 3;
            this.InstructionLabel.Text = "You don\'t have an account ? Sing up now !";
            this.InstructionLabel.Click += new System.EventHandler(this.InstructionLabel_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.loginLabel.Location = new System.Drawing.Point(129, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(58, 29);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Log in ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerCPRDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(354, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(145, 83);
            this.dataGridView1.TabIndex = 13;
            // 
            // customerCPRDataGridViewTextBoxColumn
            // 
            this.customerCPRDataGridViewTextBoxColumn.DataPropertyName = "Customer CPR";
            this.customerCPRDataGridViewTextBoxColumn.HeaderText = "Customer CPR";
            this.customerCPRDataGridViewTextBoxColumn.Name = "customerCPRDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerDatabaseDataSet;
            // 
            // customerDatabaseDataSet
            // 
            this.customerDatabaseDataSet.DataSetName = "customerDatabaseDataSet";
            this.customerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(341, 271);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "CustomerLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Login";
            this.Load += new System.EventHandler(this.CustomerLoginForm_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label customerCPRLabel;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.DataGridView dataGridView1;
        private customerDatabaseDataSet customerDatabaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private customerDatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCPRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}