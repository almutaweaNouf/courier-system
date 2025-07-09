namespace Project
{
    partial class OrderDeatailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCPRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDeatailsDatabaseDataSet = new Project.OrderDeatailsDatabaseDataSet();
            this.continuetrackOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerCPRLabel = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new Project.OrderDeatailsDatabaseDataSetTableAdapters.OrdersTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDeatailsDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(288, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Order Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(18, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 141);
            this.panel2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerCPRDataGridViewTextBoxColumn,
            this.deliveryTypeDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.packageDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 106);
            this.dataGridView1.TabIndex = 19;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerCPRDataGridViewTextBoxColumn
            // 
            this.customerCPRDataGridViewTextBoxColumn.DataPropertyName = "Customer CPR";
            this.customerCPRDataGridViewTextBoxColumn.HeaderText = "Customer CPR";
            this.customerCPRDataGridViewTextBoxColumn.Name = "customerCPRDataGridViewTextBoxColumn";
            // 
            // deliveryTypeDataGridViewTextBoxColumn
            // 
            this.deliveryTypeDataGridViewTextBoxColumn.DataPropertyName = "Delivery Type";
            this.deliveryTypeDataGridViewTextBoxColumn.HeaderText = "Delivery Type";
            this.deliveryTypeDataGridViewTextBoxColumn.Name = "deliveryTypeDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "Arrival Date";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "Arrival Date";
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            // 
            // packageDataGridViewTextBoxColumn
            // 
            this.packageDataGridViewTextBoxColumn.DataPropertyName = "Package";
            this.packageDataGridViewTextBoxColumn.HeaderText = "Package";
            this.packageDataGridViewTextBoxColumn.Name = "packageDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.orderDeatailsDatabaseDataSet;
            // 
            // orderDeatailsDatabaseDataSet
            // 
            this.orderDeatailsDatabaseDataSet.DataSetName = "OrderDeatailsDatabaseDataSet";
            this.orderDeatailsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // continuetrackOrder
            // 
            this.continuetrackOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.continuetrackOrder.Location = new System.Drawing.Point(314, 274);
            this.continuetrackOrder.Name = "continuetrackOrder";
            this.continuetrackOrder.Size = new System.Drawing.Size(77, 28);
            this.continuetrackOrder.TabIndex = 1;
            this.continuetrackOrder.Text = "Continue";
            this.continuetrackOrder.UseVisualStyleBackColor = true;
            this.continuetrackOrder.Click += new System.EventHandler(this.continuetrackOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.customerIDTextBox);
            this.panel1.Controls.Add(this.CustomerCPRLabel);
            this.panel1.Location = new System.Drawing.Point(223, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 49);
            this.panel1.TabIndex = 0;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(121, 15);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox.TabIndex = 0;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.customerIDTextBox_TextChanged);
            // 
            // CustomerCPRLabel
            // 
            this.CustomerCPRLabel.AutoSize = true;
            this.CustomerCPRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CustomerCPRLabel.Location = new System.Drawing.Point(15, 15);
            this.CustomerCPRLabel.Name = "CustomerCPRLabel";
            this.CustomerCPRLabel.Size = new System.Drawing.Size(76, 13);
            this.CustomerCPRLabel.TabIndex = 5;
            this.CustomerCPRLabel.Text = "Customer CPR";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // OrderDeatailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(693, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.continuetrackOrder);
            this.Controls.Add(this.panel1);
            this.Name = "OrderDeatailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Deatails";
            this.Load += new System.EventHandler(this.OrderDeatailsForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDeatailsDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button continuetrackOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Label CustomerCPRLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OrderDeatailsDatabaseDataSet orderDeatailsDatabaseDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private OrderDeatailsDatabaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCPRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}