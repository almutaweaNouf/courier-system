namespace Project
{
    partial class CustomerSignUpForm
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
            this.signupPanel = new System.Windows.Forms.Panel();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.agreeCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.customerCPRTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.customerCPRLabel = new System.Windows.Forms.Label();
            this.signupLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerCPRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerTableDatabaseDataSet = new Project.ProjectDatabaseDataSet();
            this.customerTableAdapter = new Project.ProjectDatabaseDataSetTableAdapters.CustomerTableAdapter();
            this.signupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTableDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // signupPanel
            // 
            this.signupPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.signupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPanel.Controls.Add(this.checkBoxHide);
            this.signupPanel.Controls.Add(this.addressTextBox);
            this.signupPanel.Controls.Add(this.addressLabel);
            this.signupPanel.Controls.Add(this.phoneNumberTextBox);
            this.signupPanel.Controls.Add(this.agreeCheckBox);
            this.signupPanel.Controls.Add(this.emailTextBox);
            this.signupPanel.Controls.Add(this.emailLabel);
            this.signupPanel.Controls.Add(this.phoneNumberLabel);
            this.signupPanel.Controls.Add(this.passwordTextBox);
            this.signupPanel.Controls.Add(this.customerCPRTextBox);
            this.signupPanel.Controls.Add(this.passwordLabel);
            this.signupPanel.Controls.Add(this.customerCPRLabel);
            this.signupPanel.Location = new System.Drawing.Point(16, 58);
            this.signupPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signupPanel.Name = "signupPanel";
            this.signupPanel.Size = new System.Drawing.Size(419, 339);
            this.signupPanel.TabIndex = 0;
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.AutoSize = true;
            this.checkBoxHide.Location = new System.Drawing.Point(279, 82);
            this.checkBoxHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(62, 20);
            this.checkBoxHide.TabIndex = 5;
            this.checkBoxHide.Text = "Show";
            this.checkBoxHide.UseVisualStyleBackColor = true;
            this.checkBoxHide.CheckedChanged += new System.EventHandler(this.checkBoxHide_CheckedChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Location = new System.Drawing.Point(145, 235);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(201, 22);
            this.addressTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.addressLabel.Location = new System.Drawing.Point(23, 235);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 16;
            this.addressLabel.Text = "Address";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(145, 127);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(201, 22);
            this.phoneNumberTextBox.TabIndex = 2;
            // 
            // agreeCheckBox
            // 
            this.agreeCheckBox.AutoSize = true;
            this.agreeCheckBox.Location = new System.Drawing.Point(26, 288);
            this.agreeCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.agreeCheckBox.Name = "agreeCheckBox";
            this.agreeCheckBox.Size = new System.Drawing.Size(209, 20);
            this.agreeCheckBox.TabIndex = 6;
            this.agreeCheckBox.Text = "Agree to terms and conditions.";
            this.agreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Location = new System.Drawing.Point(145, 181);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(201, 22);
            this.emailTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.emailLabel.Location = new System.Drawing.Point(23, 177);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.phoneNumberLabel.Location = new System.Drawing.Point(23, 127);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneNumberLabel.TabIndex = 10;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(145, 80);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(129, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // customerCPRTextBox
            // 
            this.customerCPRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerCPRTextBox.Location = new System.Drawing.Point(145, 31);
            this.customerCPRTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerCPRTextBox.Name = "customerCPRTextBox";
            this.customerCPRTextBox.Size = new System.Drawing.Size(201, 22);
            this.customerCPRTextBox.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordLabel.Location = new System.Drawing.Point(23, 80);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password ";
            // 
            // customerCPRLabel
            // 
            this.customerCPRLabel.AutoSize = true;
            this.customerCPRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customerCPRLabel.Location = new System.Drawing.Point(23, 31);
            this.customerCPRLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerCPRLabel.Name = "customerCPRLabel";
            this.customerCPRLabel.Size = new System.Drawing.Size(100, 17);
            this.customerCPRLabel.TabIndex = 6;
            this.customerCPRLabel.Text = "Customer CPR";
            // 
            // signupLabel
            // 
            this.signupLabel.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLabel.Location = new System.Drawing.Point(157, 12);
            this.signupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(109, 42);
            this.signupLabel.TabIndex = 15;
            this.signupLabel.Text = "Sign Up";
            this.signupLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(145, 405);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(123, 32);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create Account";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(472, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(471, 256);
            this.dataGridView1.TabIndex = 18;
            // 
            // customerCPRDataGridViewTextBoxColumn
            // 
            this.customerCPRDataGridViewTextBoxColumn.DataPropertyName = "Customer CPR";
            this.customerCPRDataGridViewTextBoxColumn.HeaderText = "Customer CPR";
            this.customerCPRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerCPRDataGridViewTextBoxColumn.Name = "customerCPRDataGridViewTextBoxColumn";
            this.customerCPRDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.CustomerTableDatabaseDataSet;
            this.customerBindingSource.CurrentChanged += new System.EventHandler(this.customerBindingSource_CurrentChanged);
            // 
            // CustomerTableDatabaseDataSet
            // 
            this.CustomerTableDatabaseDataSet.DataSetName = "CustomerTableDatabaseDataSet";
            this.CustomerTableDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(453, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.signupPanel);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.createButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerSignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Sign Up";
            this.Load += new System.EventHandler(this.CustomerSignUpForm_Load);
            this.signupPanel.ResumeLayout(false);
            this.signupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTableDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signupPanel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.CheckBox agreeCheckBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label customerCPRLabel;
        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectDatabaseDataSet CustomerTableDatabaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private ProjectDatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCPRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox customerCPRTextBox;
    }
}