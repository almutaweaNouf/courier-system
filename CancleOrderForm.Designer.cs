namespace Project
{
    partial class CancleOrderForm
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
            System.Windows.Forms.Label order_IDLabel;
            this.canaelPanel = new System.Windows.Forms.Panel();
            this.order_IDTextBox = new System.Windows.Forms.TextBox();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancleOrderDatabaseDataSet = new Project.cancleOrderDatabaseDataSet();
            this.showMyOrdersButton = new System.Windows.Forms.Button();
            this.reasonsComboBox = new System.Windows.Forms.ComboBox();
            this.customerCPRTextBox = new System.Windows.Forms.TextBox();
            this.CustomerCPRlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.agreeCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.orderCancellationLabel = new System.Windows.Forms.Label();
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
            this.ordersTableAdapter = new Project.cancleOrderDatabaseDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new Project.cancleOrderDatabaseDataSetTableAdapters.TableAdapterManager();
            order_IDLabel = new System.Windows.Forms.Label();
            this.canaelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancleOrderDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // order_IDLabel
            // 
            order_IDLabel.AutoSize = true;
            order_IDLabel.Location = new System.Drawing.Point(11, 99);
            order_IDLabel.Name = "order_IDLabel";
            order_IDLabel.Size = new System.Drawing.Size(50, 13);
            order_IDLabel.TabIndex = 10;
            order_IDLabel.Text = "Order ID:";
            // 
            // canaelPanel
            // 
            this.canaelPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.canaelPanel.Controls.Add(this.order_IDTextBox);
            this.canaelPanel.Controls.Add(order_IDLabel);
            this.canaelPanel.Controls.Add(this.showMyOrdersButton);
            this.canaelPanel.Controls.Add(this.reasonsComboBox);
            this.canaelPanel.Controls.Add(this.customerCPRTextBox);
            this.canaelPanel.Controls.Add(this.CustomerCPRlabel);
            this.canaelPanel.Controls.Add(this.label2);
            this.canaelPanel.Location = new System.Drawing.Point(16, 64);
            this.canaelPanel.Margin = new System.Windows.Forms.Padding(2);
            this.canaelPanel.Name = "canaelPanel";
            this.canaelPanel.Size = new System.Drawing.Size(290, 184);
            this.canaelPanel.TabIndex = 0;
            // 
            // order_IDTextBox
            // 
            this.order_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Order ID", true));
            this.order_IDTextBox.Location = new System.Drawing.Point(162, 99);
            this.order_IDTextBox.Name = "order_IDTextBox";
            this.order_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.order_IDTextBox.TabIndex = 11;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.cancleOrderDatabaseDataSet;
            // 
            // cancleOrderDatabaseDataSet
            // 
            this.cancleOrderDatabaseDataSet.DataSetName = "cancleOrderDatabaseDataSet";
            this.cancleOrderDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showMyOrdersButton
            // 
            this.showMyOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.showMyOrdersButton.Location = new System.Drawing.Point(93, 146);
            this.showMyOrdersButton.Margin = new System.Windows.Forms.Padding(2);
            this.showMyOrdersButton.Name = "showMyOrdersButton";
            this.showMyOrdersButton.Size = new System.Drawing.Size(92, 26);
            this.showMyOrdersButton.TabIndex = 2;
            this.showMyOrdersButton.Text = "Show my Orders";
            this.showMyOrdersButton.UseVisualStyleBackColor = true;
            this.showMyOrdersButton.Click += new System.EventHandler(this.showMyOrdersButton_Click);
            // 
            // reasonsComboBox
            // 
            this.reasonsComboBox.FormattingEnabled = true;
            this.reasonsComboBox.Items.AddRange(new object[] {
            "Changed my mind",
            "Bought wrong item(s)",
            "Found cheaper alternative ",
            "Placed duplicated order",
            "Other"});
            this.reasonsComboBox.Location = new System.Drawing.Point(162, 61);
            this.reasonsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.reasonsComboBox.Name = "reasonsComboBox";
            this.reasonsComboBox.Size = new System.Drawing.Size(96, 21);
            this.reasonsComboBox.TabIndex = 1;
            // 
            // customerCPRTextBox
            // 
            this.customerCPRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerCPRTextBox.Location = new System.Drawing.Point(162, 17);
            this.customerCPRTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerCPRTextBox.Name = "customerCPRTextBox";
            this.customerCPRTextBox.Size = new System.Drawing.Size(98, 20);
            this.customerCPRTextBox.TabIndex = 0;
            // 
            // CustomerCPRlabel
            // 
            this.CustomerCPRlabel.AutoSize = true;
            this.CustomerCPRlabel.Location = new System.Drawing.Point(11, 24);
            this.CustomerCPRlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerCPRlabel.Name = "CustomerCPRlabel";
            this.CustomerCPRlabel.Size = new System.Drawing.Size(82, 13);
            this.CustomerCPRlabel.TabIndex = 2;
            this.CustomerCPRlabel.Text = "Customer CPR :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reason for Cancellation";
            // 
            // agreeCheckBox
            // 
            this.agreeCheckBox.AutoSize = true;
            this.agreeCheckBox.Location = new System.Drawing.Point(16, 373);
            this.agreeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.agreeCheckBox.Name = "agreeCheckBox";
            this.agreeCheckBox.Size = new System.Drawing.Size(169, 17);
            this.agreeCheckBox.TabIndex = 4;
            this.agreeCheckBox.Text = "I Agree for cancelling my order";
            this.agreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelButton.Location = new System.Drawing.Point(189, 365);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 31);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel my Order";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // orderCancellationLabel
            // 
            this.orderCancellationLabel.AutoSize = true;
            this.orderCancellationLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCancellationLabel.Location = new System.Drawing.Point(90, 21);
            this.orderCancellationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderCancellationLabel.Name = "orderCancellationLabel";
            this.orderCancellationLabel.Size = new System.Drawing.Size(141, 29);
            this.orderCancellationLabel.TabIndex = 10;
            this.orderCancellationLabel.Text = "Order Cancellation";
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 60);
            this.dataGridView1.TabIndex = 1;
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
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project.cancleOrderDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CancleOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(324, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.canaelPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.orderCancellationLabel);
            this.Controls.Add(this.agreeCheckBox);
            this.Name = "CancleOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancle Order";
            this.Load += new System.EventHandler(this.CancleOrderForm_Load);
            this.canaelPanel.ResumeLayout(false);
            this.canaelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancleOrderDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel canaelPanel;
        private System.Windows.Forms.ComboBox reasonsComboBox;
        private System.Windows.Forms.TextBox customerCPRTextBox;
        private System.Windows.Forms.CheckBox agreeCheckBox;
        private System.Windows.Forms.Label CustomerCPRlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label orderCancellationLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cancleOrderDatabaseDataSet cancleOrderDatabaseDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private cancleOrderDatabaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCPRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button showMyOrdersButton;
        private System.Windows.Forms.TextBox order_IDTextBox;
        private cancleOrderDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}