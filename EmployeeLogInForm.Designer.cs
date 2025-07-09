namespace Project
{
    partial class EmployeeLogInForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.empLoginPpanel = new System.Windows.Forms.Panel();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.employeePasswordTextBox = new System.Windows.Forms.TextBox();
            this.employeeCPRTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.employeeCPRLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeCPRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDatabaseDataSet = new Project.EmployeeDatabaseDataSet();
            this.employeeTableAdapter = new Project.EmployeeDatabaseDataSetTableAdapters.EmployeeTableAdapter();
            this.empLoginPpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LoginButton.Location = new System.Drawing.Point(118, 198);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(65, 24);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // empLoginPpanel
            // 
            this.empLoginPpanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.empLoginPpanel.Controls.Add(this.checkBoxHide);
            this.empLoginPpanel.Controls.Add(this.employeePasswordTextBox);
            this.empLoginPpanel.Controls.Add(this.employeeCPRTextBox);
            this.empLoginPpanel.Controls.Add(this.passwordLabel);
            this.empLoginPpanel.Controls.Add(this.employeeCPRLabel);
            this.empLoginPpanel.Location = new System.Drawing.Point(14, 62);
            this.empLoginPpanel.Margin = new System.Windows.Forms.Padding(2);
            this.empLoginPpanel.Name = "empLoginPpanel";
            this.empLoginPpanel.Size = new System.Drawing.Size(272, 123);
            this.empLoginPpanel.TabIndex = 0;
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.AutoSize = true;
            this.checkBoxHide.Location = new System.Drawing.Point(214, 80);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(53, 17);
            this.checkBoxHide.TabIndex = 4;
            this.checkBoxHide.Text = "Show";
            this.checkBoxHide.UseVisualStyleBackColor = true;
            this.checkBoxHide.CheckedChanged += new System.EventHandler(this.checkBoxHide_CheckedChanged);
            // 
            // employeePasswordTextBox
            // 
            this.employeePasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeePasswordTextBox.Location = new System.Drawing.Point(104, 77);
            this.employeePasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeePasswordTextBox.Name = "employeePasswordTextBox";
            this.employeePasswordTextBox.Size = new System.Drawing.Size(105, 20);
            this.employeePasswordTextBox.TabIndex = 1;
            this.employeePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // employeeCPRTextBox
            // 
            this.employeeCPRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeCPRTextBox.Location = new System.Drawing.Point(104, 19);
            this.employeeCPRTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.employeeCPRTextBox.Name = "employeeCPRTextBox";
            this.employeeCPRTextBox.Size = new System.Drawing.Size(163, 20);
            this.employeeCPRTextBox.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(22, 84);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // employeeCPRLabel
            // 
            this.employeeCPRLabel.AutoSize = true;
            this.employeeCPRLabel.Location = new System.Drawing.Point(22, 19);
            this.employeeCPRLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeCPRLabel.Name = "employeeCPRLabel";
            this.employeeCPRLabel.Size = new System.Drawing.Size(78, 13);
            this.employeeCPRLabel.TabIndex = 1;
            this.employeeCPRLabel.Text = "Employee CPR";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(85, 21);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(121, 29);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Employee Login";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeCPRDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(205, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(79, 31);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // employeeCPRDataGridViewTextBoxColumn
            // 
            this.employeeCPRDataGridViewTextBoxColumn.DataPropertyName = "Employee CPR";
            this.employeeCPRDataGridViewTextBoxColumn.HeaderText = "Employee CPR";
            this.employeeCPRDataGridViewTextBoxColumn.Name = "employeeCPRDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeDatabaseDataSet;
            // 
            // employeeDatabaseDataSet
            // 
            this.employeeDatabaseDataSet.DataSetName = "EmployeeDatabaseDataSet";
            this.employeeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(300, 231);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.empLoginPpanel);
            this.Controls.Add(this.loginLabel);
            this.Name = "EmployeeLogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Login ";
            this.Load += new System.EventHandler(this.EmployeeLogInForm_Load);
            this.empLoginPpanel.ResumeLayout(false);
            this.empLoginPpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel empLoginPpanel;
        private System.Windows.Forms.TextBox employeePasswordTextBox;
        private System.Windows.Forms.TextBox employeeCPRTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label employeeCPRLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmployeeDatabaseDataSet employeeDatabaseDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeDatabaseDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCPRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}