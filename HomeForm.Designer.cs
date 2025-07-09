namespace Project
{
    partial class HomeForm
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
            this.customerButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.employessPictureBox = new System.Windows.Forms.PictureBox();
            this.clientPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.employessPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(713, 242);
            this.customerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(192, 50);
            this.customerButton.TabIndex = 0;
            this.customerButton.Text = "&Customer ";
            this.toolTip1.SetToolTip(this.customerButton, "Customer to login or signup");
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Location = new System.Drawing.Point(411, 242);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(192, 50);
            this.employeeButton.TabIndex = 1;
            this.employeeButton.Text = "&Employee";
            this.toolTip1.SetToolTip(this.employeeButton, "Employee login");
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.welcomeLabel.Location = new System.Drawing.Point(456, 39);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(376, 34);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "Welcome to FNS  Courier && Cargo Systems";
            // 
            // employessPictureBox
            // 
            this.employessPictureBox.Image = global::Project.Properties.Resources.employee;
            this.employessPictureBox.Location = new System.Drawing.Point(432, 112);
            this.employessPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employessPictureBox.Name = "employessPictureBox";
            this.employessPictureBox.Size = new System.Drawing.Size(145, 123);
            this.employessPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employessPictureBox.TabIndex = 11;
            this.employessPictureBox.TabStop = false;
            // 
            // clientPictureBox
            // 
            this.clientPictureBox.Image = global::Project.Properties.Resources.client_6009864;
            this.clientPictureBox.Location = new System.Drawing.Point(736, 112);
            this.clientPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientPictureBox.Name = "clientPictureBox";
            this.clientPictureBox.Size = new System.Drawing.Size(145, 123);
            this.clientPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clientPictureBox.TabIndex = 10;
            this.clientPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.FNSLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(59, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(963, 320);
            this.Controls.Add(this.employessPictureBox);
            this.Controls.Add(this.clientPictureBox);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.employessPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox employessPictureBox;
        private System.Windows.Forms.PictureBox clientPictureBox;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}