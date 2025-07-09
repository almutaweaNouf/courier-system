namespace Project
{
    partial class CustomerServicesForm
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
            this.servicesGroupBox = new System.Windows.Forms.GroupBox();
            this.newOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.continueButton = new System.Windows.Forms.Button();
            this.rescheduleOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelRadioButton = new System.Windows.Forms.RadioButton();
            this.packagingRadioButton = new System.Windows.Forms.RadioButton();
            this.orderDetailsRadioButton = new System.Windows.Forms.RadioButton();
            this.orderDeatailsPictureBox = new System.Windows.Forms.PictureBox();
            this.newDeliveryPictureBox = new System.Windows.Forms.PictureBox();
            this.packagingPictureBox = new System.Windows.Forms.PictureBox();
            this.cancelPictureBox = new System.Windows.Forms.PictureBox();
            this.reschedulePictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.returnToMainFormToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.learnMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.servicesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDeatailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDeliveryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reschedulePictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicesGroupBox
            // 
            this.servicesGroupBox.Controls.Add(this.newOrderRadioButton);
            this.servicesGroupBox.Controls.Add(this.continueButton);
            this.servicesGroupBox.Controls.Add(this.rescheduleOrderRadioButton);
            this.servicesGroupBox.Controls.Add(this.cancelRadioButton);
            this.servicesGroupBox.Controls.Add(this.packagingRadioButton);
            this.servicesGroupBox.Controls.Add(this.orderDetailsRadioButton);
            this.servicesGroupBox.Controls.Add(this.orderDeatailsPictureBox);
            this.servicesGroupBox.Controls.Add(this.newDeliveryPictureBox);
            this.servicesGroupBox.Controls.Add(this.packagingPictureBox);
            this.servicesGroupBox.Controls.Add(this.cancelPictureBox);
            this.servicesGroupBox.Controls.Add(this.reschedulePictureBox);
            this.servicesGroupBox.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.servicesGroupBox.Location = new System.Drawing.Point(12, 40);
            this.servicesGroupBox.Name = "servicesGroupBox";
            this.servicesGroupBox.Size = new System.Drawing.Size(642, 350);
            this.servicesGroupBox.TabIndex = 1;
            this.servicesGroupBox.TabStop = false;
            this.servicesGroupBox.Text = "Offered Services on FNS System";
            // 
            // newOrderRadioButton
            // 
            this.newOrderRadioButton.AutoSize = true;
            this.newOrderRadioButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderRadioButton.Location = new System.Drawing.Point(29, 153);
            this.newOrderRadioButton.Name = "newOrderRadioButton";
            this.newOrderRadioButton.Size = new System.Drawing.Size(129, 19);
            this.newOrderRadioButton.TabIndex = 0;
            this.newOrderRadioButton.TabStop = true;
            this.newOrderRadioButton.Text = "&Place new Delivery ";
            this.newOrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.continueButton.Location = new System.Drawing.Point(256, 310);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(82, 24);
            this.continueButton.TabIndex = 5;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // rescheduleOrderRadioButton
            // 
            this.rescheduleOrderRadioButton.AutoSize = true;
            this.rescheduleOrderRadioButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rescheduleOrderRadioButton.Location = new System.Drawing.Point(471, 153);
            this.rescheduleOrderRadioButton.Name = "rescheduleOrderRadioButton";
            this.rescheduleOrderRadioButton.Size = new System.Drawing.Size(136, 19);
            this.rescheduleOrderRadioButton.TabIndex = 2;
            this.rescheduleOrderRadioButton.TabStop = true;
            this.rescheduleOrderRadioButton.Text = "&Reschedule my Order";
            this.rescheduleOrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // cancelRadioButton
            // 
            this.cancelRadioButton.AutoSize = true;
            this.cancelRadioButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelRadioButton.Location = new System.Drawing.Point(132, 287);
            this.cancelRadioButton.Name = "cancelRadioButton";
            this.cancelRadioButton.Size = new System.Drawing.Size(112, 19);
            this.cancelRadioButton.TabIndex = 3;
            this.cancelRadioButton.TabStop = true;
            this.cancelRadioButton.Text = "&Cancel my Order";
            this.cancelRadioButton.UseVisualStyleBackColor = true;
            // 
            // packagingRadioButton
            // 
            this.packagingRadioButton.AutoSize = true;
            this.packagingRadioButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagingRadioButton.Location = new System.Drawing.Point(359, 287);
            this.packagingRadioButton.Name = "packagingRadioButton";
            this.packagingRadioButton.Size = new System.Drawing.Size(130, 19);
            this.packagingRadioButton.TabIndex = 4;
            this.packagingRadioButton.TabStop = true;
            this.packagingRadioButton.Text = "Pac&kaging Services ";
            this.packagingRadioButton.UseVisualStyleBackColor = true;
            // 
            // orderDetailsRadioButton
            // 
            this.orderDetailsRadioButton.AutoSize = true;
            this.orderDetailsRadioButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsRadioButton.Location = new System.Drawing.Point(240, 153);
            this.orderDetailsRadioButton.Name = "orderDetailsRadioButton";
            this.orderDetailsRadioButton.Size = new System.Drawing.Size(147, 19);
            this.orderDetailsRadioButton.TabIndex = 1;
            this.orderDetailsRadioButton.TabStop = true;
            this.orderDetailsRadioButton.Text = "&Show my Order Details";
            this.orderDetailsRadioButton.UseVisualStyleBackColor = true;
            // 
            // orderDeatailsPictureBox
            // 
            this.orderDeatailsPictureBox.Image = global::Project.Properties.Resources.deatails;
            this.orderDeatailsPictureBox.Location = new System.Drawing.Point(256, 43);
            this.orderDeatailsPictureBox.Name = "orderDeatailsPictureBox";
            this.orderDeatailsPictureBox.Size = new System.Drawing.Size(118, 104);
            this.orderDeatailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderDeatailsPictureBox.TabIndex = 4;
            this.orderDeatailsPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.orderDeatailsPictureBox, "my order information");
            // 
            // newDeliveryPictureBox
            // 
            this.newDeliveryPictureBox.Image = global::Project.Properties.Resources.groceries;
            this.newDeliveryPictureBox.Location = new System.Drawing.Point(29, 54);
            this.newDeliveryPictureBox.Name = "newDeliveryPictureBox";
            this.newDeliveryPictureBox.Size = new System.Drawing.Size(108, 93);
            this.newDeliveryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newDeliveryPictureBox.TabIndex = 3;
            this.newDeliveryPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.newDeliveryPictureBox, "Create new delivery order ");
            // 
            // packagingPictureBox
            // 
            this.packagingPictureBox.Image = global::Project.Properties.Resources.order;
            this.packagingPictureBox.Location = new System.Drawing.Point(371, 188);
            this.packagingPictureBox.Name = "packagingPictureBox";
            this.packagingPictureBox.Size = new System.Drawing.Size(108, 93);
            this.packagingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.packagingPictureBox.TabIndex = 2;
            this.packagingPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.packagingPictureBox, "Packag your order");
            // 
            // cancelPictureBox
            // 
            this.cancelPictureBox.Image = global::Project.Properties.Resources.cancelled;
            this.cancelPictureBox.Location = new System.Drawing.Point(136, 188);
            this.cancelPictureBox.Name = "cancelPictureBox";
            this.cancelPictureBox.Size = new System.Drawing.Size(108, 93);
            this.cancelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cancelPictureBox.TabIndex = 1;
            this.cancelPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.cancelPictureBox, "Cancel your order");
            // 
            // reschedulePictureBox
            // 
            this.reschedulePictureBox.Image = global::Project.Properties.Resources.rerschedule;
            this.reschedulePictureBox.Location = new System.Drawing.Point(486, 54);
            this.reschedulePictureBox.Name = "reschedulePictureBox";
            this.reschedulePictureBox.Size = new System.Drawing.Size(108, 93);
            this.reschedulePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reschedulePictureBox.TabIndex = 0;
            this.reschedulePictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.reschedulePictureBox, "reschedule your order");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.learnMoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainFormToolStripMenuItem,
            this.toolStripSeparator1,
            this.returnToMainFormToolStripMenuItem1,
            this.exitToolStripMenuItem,
            this.toolStripSeparator2});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // returnToMainFormToolStripMenuItem
            // 
            this.returnToMainFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.returnToMainFormToolStripMenuItem.Name = "returnToMainFormToolStripMenuItem";
            this.returnToMainFormToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.returnToMainFormToolStripMenuItem.Text = "Change Apperance";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.containerToolStripMenuItem,
            this.backColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // containerToolStripMenuItem
            // 
            this.containerToolStripMenuItem.Name = "containerToolStripMenuItem";
            this.containerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.containerToolStripMenuItem.Text = "Container ";
            this.containerToolStripMenuItem.Click += new System.EventHandler(this.containerToolStripMenuItem_Click);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.backColorToolStripMenuItem.Text = "BackColor";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // returnToMainFormToolStripMenuItem1
            // 
            this.returnToMainFormToolStripMenuItem1.Name = "returnToMainFormToolStripMenuItem1";
            this.returnToMainFormToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.returnToMainFormToolStripMenuItem1.Text = "Return to Main Form";
            this.returnToMainFormToolStripMenuItem1.Click += new System.EventHandler(this.returnToMainFormToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aboutUsToolStripMenuItem.Text = "&About us ";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // learnMoreToolStripMenuItem
            // 
            this.learnMoreToolStripMenuItem.Name = "learnMoreToolStripMenuItem";
            this.learnMoreToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.learnMoreToolStripMenuItem.Text = "Learn &More";
            this.learnMoreToolStripMenuItem.Click += new System.EventHandler(this.learnMoreToolStripMenuItem_Click);
            // 
            // CustomerServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(666, 402);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.servicesGroupBox);
            this.Name = "CustomerServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Services";
            this.servicesGroupBox.ResumeLayout(false);
            this.servicesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDeatailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDeliveryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reschedulePictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox servicesGroupBox;
        public System.Windows.Forms.RadioButton newOrderRadioButton;
        private System.Windows.Forms.Button continueButton;
        public System.Windows.Forms.RadioButton rescheduleOrderRadioButton;
        public System.Windows.Forms.RadioButton cancelRadioButton;
        public System.Windows.Forms.RadioButton packagingRadioButton;
        public System.Windows.Forms.RadioButton orderDetailsRadioButton;
        private System.Windows.Forms.PictureBox orderDeatailsPictureBox;
        private System.Windows.Forms.PictureBox newDeliveryPictureBox;
        private System.Windows.Forms.PictureBox packagingPictureBox;
        private System.Windows.Forms.PictureBox cancelPictureBox;
        private System.Windows.Forms.PictureBox reschedulePictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem returnToMainFormToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem learnMoreToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}