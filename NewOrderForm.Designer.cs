namespace Project
{
    partial class NewOrderForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.NewOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.customerCPRLabel = new System.Windows.Forms.Label();
            this.customerCPRtextBox = new System.Windows.Forms.TextBox();
            this.kgLabel = new System.Windows.Forms.Label();
            this.PackagingPanel = new System.Windows.Forms.GroupBox();
            this.bronzeRoadPictureBox = new System.Windows.Forms.PictureBox();
            this.bronzeRoadRadioButton = new System.Windows.Forms.RadioButton();
            this.goldenAirPictureBox = new System.Windows.Forms.PictureBox();
            this.silverOceanPictureBox = new System.Windows.Forms.PictureBox();
            this.silverOceanRadioButton = new System.Windows.Forms.RadioButton();
            this.goldenAirRadioButton = new System.Windows.Forms.RadioButton();
            this.ArriveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arriveDateLabel = new System.Windows.Forms.Label();
            this.Destinationabel = new System.Windows.Forms.Label();
            this.contentComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryTypeLabel = new System.Windows.Forms.Label();
            this.DeliveryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
            this.ordersNewDatabaseDataSet = new Project.OrdersNewDatabaseDataSet();
            this.ordersTableAdapter = new Project.OrdersNewDatabaseDataSetTableAdapters.OrdersTableAdapter();
            this.continueButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NewOrderGroupBox.SuspendLayout();
            this.PackagingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bronzeRoadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenAirPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverOceanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersNewDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.backButton.Location = new System.Drawing.Point(366, 407);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // NewOrderGroupBox
            // 
            this.NewOrderGroupBox.Controls.Add(this.customerCPRLabel);
            this.NewOrderGroupBox.Controls.Add(this.customerCPRtextBox);
            this.NewOrderGroupBox.Controls.Add(this.kgLabel);
            this.NewOrderGroupBox.Controls.Add(this.PackagingPanel);
            this.NewOrderGroupBox.Controls.Add(this.ArriveDateTimePicker);
            this.NewOrderGroupBox.Controls.Add(this.arriveDateLabel);
            this.NewOrderGroupBox.Controls.Add(this.Destinationabel);
            this.NewOrderGroupBox.Controls.Add(this.contentComboBox);
            this.NewOrderGroupBox.Controls.Add(this.deliveryTypeLabel);
            this.NewOrderGroupBox.Controls.Add(this.DeliveryTypeComboBox);
            this.NewOrderGroupBox.Controls.Add(this.weightTextBox);
            this.NewOrderGroupBox.Controls.Add(this.DestinationTextBox);
            this.NewOrderGroupBox.Controls.Add(this.weightLabel);
            this.NewOrderGroupBox.Controls.Add(this.ContentLabel);
            this.NewOrderGroupBox.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NewOrderGroupBox.Location = new System.Drawing.Point(17, 24);
            this.NewOrderGroupBox.Name = "NewOrderGroupBox";
            this.NewOrderGroupBox.Size = new System.Drawing.Size(546, 377);
            this.NewOrderGroupBox.TabIndex = 0;
            this.NewOrderGroupBox.TabStop = false;
            this.NewOrderGroupBox.Text = "New Delivery Order ";
            // 
            // customerCPRLabel
            // 
            this.customerCPRLabel.AutoSize = true;
            this.customerCPRLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.customerCPRLabel.Location = new System.Drawing.Point(141, 40);
            this.customerCPRLabel.Name = "customerCPRLabel";
            this.customerCPRLabel.Size = new System.Drawing.Size(82, 15);
            this.customerCPRLabel.TabIndex = 27;
            this.customerCPRLabel.Text = "customer CPR";
            // 
            // customerCPRtextBox
            // 
            this.customerCPRtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerCPRtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customerCPRtextBox.Location = new System.Drawing.Point(241, 38);
            this.customerCPRtextBox.Name = "customerCPRtextBox";
            this.customerCPRtextBox.Size = new System.Drawing.Size(125, 20);
            this.customerCPRtextBox.TabIndex = 0;
            // 
            // kgLabel
            // 
            this.kgLabel.AutoSize = true;
            this.kgLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.kgLabel.Location = new System.Drawing.Point(449, 111);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(26, 15);
            this.kgLabel.TabIndex = 25;
            this.kgLabel.Text = "KG";
            // 
            // PackagingPanel
            // 
            this.PackagingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PackagingPanel.Controls.Add(this.bronzeRoadPictureBox);
            this.PackagingPanel.Controls.Add(this.bronzeRoadRadioButton);
            this.PackagingPanel.Controls.Add(this.goldenAirPictureBox);
            this.PackagingPanel.Controls.Add(this.silverOceanPictureBox);
            this.PackagingPanel.Controls.Add(this.silverOceanRadioButton);
            this.PackagingPanel.Controls.Add(this.goldenAirRadioButton);
            this.PackagingPanel.Location = new System.Drawing.Point(36, 198);
            this.PackagingPanel.Name = "PackagingPanel";
            this.PackagingPanel.Size = new System.Drawing.Size(462, 150);
            this.PackagingPanel.TabIndex = 8;
            this.PackagingPanel.TabStop = false;
            this.PackagingPanel.Text = "Offered Packages";
            // 
            // bronzeRoadPictureBox
            // 
            this.bronzeRoadPictureBox.Image = global::Project.Properties.Resources.truck;
            this.bronzeRoadPictureBox.Location = new System.Drawing.Point(333, 30);
            this.bronzeRoadPictureBox.Name = "bronzeRoadPictureBox";
            this.bronzeRoadPictureBox.Size = new System.Drawing.Size(103, 92);
            this.bronzeRoadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bronzeRoadPictureBox.TabIndex = 7;
            this.bronzeRoadPictureBox.TabStop = false;
            // 
            // bronzeRoadRadioButton
            // 
            this.bronzeRoadRadioButton.AutoSize = true;
            this.bronzeRoadRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bronzeRoadRadioButton.Location = new System.Drawing.Point(339, 128);
            this.bronzeRoadRadioButton.Name = "bronzeRoadRadioButton";
            this.bronzeRoadRadioButton.Size = new System.Drawing.Size(87, 17);
            this.bronzeRoadRadioButton.TabIndex = 6;
            this.bronzeRoadRadioButton.TabStop = true;
            this.bronzeRoadRadioButton.Text = "Bronze Road";
            this.toolTip1.SetToolTip(this.bronzeRoadRadioButton, "10$");
            this.bronzeRoadRadioButton.UseVisualStyleBackColor = true;
            // 
            // goldenAirPictureBox
            // 
            this.goldenAirPictureBox.Image = global::Project.Properties.Resources.GoldenAirPlane;
            this.goldenAirPictureBox.Location = new System.Drawing.Point(27, 27);
            this.goldenAirPictureBox.Name = "goldenAirPictureBox";
            this.goldenAirPictureBox.Size = new System.Drawing.Size(100, 95);
            this.goldenAirPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goldenAirPictureBox.TabIndex = 5;
            this.goldenAirPictureBox.TabStop = false;
            // 
            // silverOceanPictureBox
            // 
            this.silverOceanPictureBox.Image = global::Project.Properties.Resources.SilverSteamShip;
            this.silverOceanPictureBox.Location = new System.Drawing.Point(167, 30);
            this.silverOceanPictureBox.Name = "silverOceanPictureBox";
            this.silverOceanPictureBox.Size = new System.Drawing.Size(103, 92);
            this.silverOceanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.silverOceanPictureBox.TabIndex = 4;
            this.silverOceanPictureBox.TabStop = false;
            // 
            // silverOceanRadioButton
            // 
            this.silverOceanRadioButton.AutoSize = true;
            this.silverOceanRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.silverOceanRadioButton.Location = new System.Drawing.Point(183, 126);
            this.silverOceanRadioButton.Name = "silverOceanRadioButton";
            this.silverOceanRadioButton.Size = new System.Drawing.Size(86, 17);
            this.silverOceanRadioButton.TabIndex = 2;
            this.silverOceanRadioButton.TabStop = true;
            this.silverOceanRadioButton.Text = "Silver Ocean";
            this.toolTip1.SetToolTip(this.silverOceanRadioButton, "25$");
            this.silverOceanRadioButton.UseVisualStyleBackColor = true;
            // 
            // goldenAirRadioButton
            // 
            this.goldenAirRadioButton.AutoSize = true;
            this.goldenAirRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.goldenAirRadioButton.Location = new System.Drawing.Point(41, 123);
            this.goldenAirRadioButton.Name = "goldenAirRadioButton";
            this.goldenAirRadioButton.Size = new System.Drawing.Size(74, 17);
            this.goldenAirRadioButton.TabIndex = 3;
            this.goldenAirRadioButton.TabStop = true;
            this.goldenAirRadioButton.Text = "Golden Air";
            this.toolTip1.SetToolTip(this.goldenAirRadioButton, "35$");
            this.goldenAirRadioButton.UseVisualStyleBackColor = true;
            // 
            // ArriveDateTimePicker
            // 
            this.ArriveDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ArriveDateTimePicker.Location = new System.Drawing.Point(203, 155);
            this.ArriveDateTimePicker.Name = "ArriveDateTimePicker";
            this.ArriveDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ArriveDateTimePicker.TabIndex = 5;
            // 
            // arriveDateLabel
            // 
            this.arriveDateLabel.AutoSize = true;
            this.arriveDateLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.arriveDateLabel.Location = new System.Drawing.Point(128, 155);
            this.arriveDateLabel.Name = "arriveDateLabel";
            this.arriveDateLabel.Size = new System.Drawing.Size(69, 15);
            this.arriveDateLabel.TabIndex = 23;
            this.arriveDateLabel.Text = "Arrive Date";
            // 
            // Destinationabel
            // 
            this.Destinationabel.AutoSize = true;
            this.Destinationabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.Destinationabel.Location = new System.Drawing.Point(270, 67);
            this.Destinationabel.Name = "Destinationabel";
            this.Destinationabel.Size = new System.Drawing.Size(68, 15);
            this.Destinationabel.TabIndex = 14;
            this.Destinationabel.Text = "Destination";
            // 
            // contentComboBox
            // 
            this.contentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.contentComboBox.FormattingEnabled = true;
            this.contentComboBox.Items.AddRange(new object[] {
            "Furniture",
            "Documents",
            "Dry fruits",
            "Electonic Items",
            "Food items",
            "Gift",
            "Home Applinces",
            "Clothes",
            "Bags",
            "Other"});
            this.contentComboBox.Location = new System.Drawing.Point(105, 101);
            this.contentComboBox.Name = "contentComboBox";
            this.contentComboBox.Size = new System.Drawing.Size(121, 21);
            this.contentComboBox.TabIndex = 2;
            // 
            // deliveryTypeLabel
            // 
            this.deliveryTypeLabel.AutoSize = true;
            this.deliveryTypeLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.deliveryTypeLabel.Location = new System.Drawing.Point(20, 71);
            this.deliveryTypeLabel.Name = "deliveryTypeLabel";
            this.deliveryTypeLabel.Size = new System.Drawing.Size(76, 15);
            this.deliveryTypeLabel.TabIndex = 13;
            this.deliveryTypeLabel.Tag = "Delivry";
            this.deliveryTypeLabel.Text = "Delivery type";
            // 
            // DeliveryTypeComboBox
            // 
            this.DeliveryTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DeliveryTypeComboBox.FormattingEnabled = true;
            this.DeliveryTypeComboBox.Items.AddRange(new object[] {
            "International",
            "Domestic"});
            this.DeliveryTypeComboBox.Location = new System.Drawing.Point(105, 67);
            this.DeliveryTypeComboBox.Name = "DeliveryTypeComboBox";
            this.DeliveryTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.DeliveryTypeComboBox.TabIndex = 1;
            // 
            // weightTextBox
            // 
            this.weightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.weightTextBox.Location = new System.Drawing.Point(343, 106);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 4;
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DestinationTextBox.Location = new System.Drawing.Point(343, 64);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(100, 20);
            this.DestinationTextBox.TabIndex = 3;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.weightLabel.Location = new System.Drawing.Point(270, 109);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(46, 15);
            this.weightLabel.TabIndex = 15;
            this.weightLabel.Text = "Weight";
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.ContentLabel.Location = new System.Drawing.Point(20, 109);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(51, 15);
            this.ContentLabel.TabIndex = 18;
            this.ContentLabel.Text = "Content ";
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
            this.dataGridView1.Location = new System.Drawing.Point(606, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 165);
            this.dataGridView1.TabIndex = 18;
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
            this.ordersBindingSource.DataSource = this.ordersNewDatabaseDataSet;
            // 
            // ordersNewDatabaseDataSet
            // 
            this.ordersNewDatabaseDataSet.DataSetName = "OrdersNewDatabaseDataSet";
            this.ordersNewDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(488, 407);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click_1);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(581, 438);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.NewOrderGroupBox);
            this.Name = "NewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Delivery Order";
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.NewOrderGroupBox.ResumeLayout(false);
            this.NewOrderGroupBox.PerformLayout();
            this.PackagingPanel.ResumeLayout(false);
            this.PackagingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bronzeRoadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldenAirPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverOceanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersNewDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox NewOrderGroupBox;
        private System.Windows.Forms.GroupBox PackagingPanel;
        private System.Windows.Forms.PictureBox bronzeRoadPictureBox;
        private System.Windows.Forms.RadioButton bronzeRoadRadioButton;
        private System.Windows.Forms.PictureBox goldenAirPictureBox;
        private System.Windows.Forms.PictureBox silverOceanPictureBox;
        private System.Windows.Forms.RadioButton silverOceanRadioButton;
        private System.Windows.Forms.RadioButton goldenAirRadioButton;
        private System.Windows.Forms.DateTimePicker ArriveDateTimePicker;
        private System.Windows.Forms.Label arriveDateLabel;
        private System.Windows.Forms.Label Destinationabel;
        private System.Windows.Forms.ComboBox contentComboBox;
        private System.Windows.Forms.Label deliveryTypeLabel;
        private System.Windows.Forms.ComboBox DeliveryTypeComboBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label kgLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OrdersNewDatabaseDataSet ordersNewDatabaseDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private OrdersNewDatabaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCPRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label customerCPRLabel;
        private System.Windows.Forms.TextBox customerCPRtextBox;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}