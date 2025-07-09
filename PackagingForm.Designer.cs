namespace Project
{
    partial class PackagingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.packagingListBox = new System.Windows.Forms.ListBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.packagingTypeLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.packagingLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagingTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagingDatabaseDataSet1 = new Project.PackagingDatabaseDataSet1();
            this.packagingTableAdapter = new Project.PackagingDatabaseDataSet1TableAdapters.PackagingTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagingDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.packagingListBox);
            this.panel1.Controls.Add(this.orderIDTextBox);
            this.panel1.Controls.Add(this.orderIDLabel);
            this.panel1.Controls.Add(this.packagingTypeLabel);
            this.panel1.Location = new System.Drawing.Point(35, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 116);
            this.panel1.TabIndex = 0;
            // 
            // packagingListBox
            // 
            this.packagingListBox.FormattingEnabled = true;
            this.packagingListBox.Items.AddRange(new object[] {
            "Sustainable Packaging",
            "Plastic Packiging ",
            "Paperboard Box ",
            "Cardboard Box",
            "Bubble Wrap (additional)"});
            this.packagingListBox.Location = new System.Drawing.Point(173, 72);
            this.packagingListBox.Name = "packagingListBox";
            this.packagingListBox.Size = new System.Drawing.Size(138, 17);
            this.packagingListBox.TabIndex = 1;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(173, 20);
            this.orderIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(138, 20);
            this.orderIDTextBox.TabIndex = 0;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Location = new System.Drawing.Point(22, 28);
            this.orderIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(47, 13);
            this.orderIDLabel.TabIndex = 2;
            this.orderIDLabel.Text = "Order ID";
            // 
            // packagingTypeLabel
            // 
            this.packagingTypeLabel.AutoSize = true;
            this.packagingTypeLabel.Location = new System.Drawing.Point(22, 72);
            this.packagingTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.packagingTypeLabel.Name = "packagingTypeLabel";
            this.packagingTypeLabel.Size = new System.Drawing.Size(90, 13);
            this.packagingTypeLabel.TabIndex = 1;
            this.packagingTypeLabel.Text = "Packaging Types";
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.continueButton.Location = new System.Drawing.Point(164, 201);
            this.continueButton.Margin = new System.Windows.Forms.Padding(2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(102, 31);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue ";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // packagingLabel
            // 
            this.packagingLabel.AutoSize = true;
            this.packagingLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagingLabel.Location = new System.Drawing.Point(141, 24);
            this.packagingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.packagingLabel.Name = "packagingLabel";
            this.packagingLabel.Size = new System.Drawing.Size(125, 29);
            this.packagingLabel.TabIndex = 13;
            this.packagingLabel.Text = "Order Packaging";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.packagingTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.packagingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(52, 30);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // packagingTypeDataGridViewTextBoxColumn
            // 
            this.packagingTypeDataGridViewTextBoxColumn.DataPropertyName = "Packaging Type";
            this.packagingTypeDataGridViewTextBoxColumn.HeaderText = "Packaging Type";
            this.packagingTypeDataGridViewTextBoxColumn.Name = "packagingTypeDataGridViewTextBoxColumn";
            // 
            // packagingBindingSource
            // 
            this.packagingBindingSource.DataMember = "Packaging";
            this.packagingBindingSource.DataSource = this.packagingDatabaseDataSet1;
            // 
            // packagingDatabaseDataSet1
            // 
            this.packagingDatabaseDataSet1.DataSetName = "PackagingDatabaseDataSet1";
            this.packagingDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packagingTableAdapter
            // 
            this.packagingTableAdapter.ClearBeforeFill = true;
            // 
            // PackagingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(405, 249);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.packagingLabel);
            this.Name = "PackagingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packaging";
            this.Load += new System.EventHandler(this.PackagingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagingDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.Label packagingTypeLabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label packagingLabel;
        private System.Windows.Forms.ListBox packagingListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PackagingDatabaseDataSet1 packagingDatabaseDataSet1;
        private System.Windows.Forms.BindingSource packagingBindingSource;
        private PackagingDatabaseDataSet1TableAdapters.PackagingTableAdapter packagingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagingTypeDataGridViewTextBoxColumn;
    }
}