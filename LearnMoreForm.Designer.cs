namespace Project
{
    partial class LearnMoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnMoreForm));
            this.contactInfoLabel = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            this.learnMoreLabel = new System.Windows.Forms.Label();
            this.FNSLabel = new System.Windows.Forms.Label();
            this.UOBpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doneByLabel = new System.Windows.Forms.Label();
            this.namesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UOBpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contactInfoLabel
            // 
            this.contactInfoLabel.Location = new System.Drawing.Point(472, 232);
            this.contactInfoLabel.Name = "contactInfoLabel";
            this.contactInfoLabel.Size = new System.Drawing.Size(277, 35);
            this.contactInfoLabel.TabIndex = 20;
            this.contactInfoLabel.Text = "For more details visit our official website www.FNS.com. or contact us through em" +
    "ail: fnscompany@gmail.com.";
            // 
            // informationLabel
            // 
            this.informationLabel.Location = new System.Drawing.Point(269, 112);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(396, 78);
            this.informationLabel.TabIndex = 19;
            this.informationLabel.Text = resources.GetString("informationLabel.Text");
            // 
            // learnMoreLabel
            // 
            this.learnMoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnMoreLabel.Location = new System.Drawing.Point(269, 68);
            this.learnMoreLabel.Name = "learnMoreLabel";
            this.learnMoreLabel.Size = new System.Drawing.Size(386, 35);
            this.learnMoreLabel.TabIndex = 18;
            this.learnMoreLabel.Text = "Choose FNS Courier & Cargo for your delivery requirements, and experience hassle-" +
    "free shipping with the utmost convenience and reliability.";
            // 
            // FNSLabel
            // 
            this.FNSLabel.AutoSize = true;
            this.FNSLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FNSLabel.Location = new System.Drawing.Point(331, 21);
            this.FNSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FNSLabel.Name = "FNSLabel";
            this.FNSLabel.Size = new System.Drawing.Size(214, 29);
            this.FNSLabel.TabIndex = 17;
            this.FNSLabel.Text = "FNS  Courier && Cargo Systems";
            // 
            // UOBpictureBox
            // 
            this.UOBpictureBox.Image = global::Project.Properties.Resources.University_of_Bahrain;
            this.UOBpictureBox.Location = new System.Drawing.Point(661, 12);
            this.UOBpictureBox.Name = "UOBpictureBox";
            this.UOBpictureBox.Size = new System.Drawing.Size(88, 88);
            this.UOBpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UOBpictureBox.TabIndex = 21;
            this.UOBpictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.FNSLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // doneByLabel
            // 
            this.doneByLabel.AutoSize = true;
            this.doneByLabel.Location = new System.Drawing.Point(290, 190);
            this.doneByLabel.Name = "doneByLabel";
            this.doneByLabel.Size = new System.Drawing.Size(50, 13);
            this.doneByLabel.TabIndex = 22;
            this.doneByLabel.Text = "Done by:";
            // 
            // namesLabel
            // 
            this.namesLabel.AutoSize = true;
            this.namesLabel.Location = new System.Drawing.Point(346, 190);
            this.namesLabel.Name = "namesLabel";
            this.namesLabel.Size = new System.Drawing.Size(377, 13);
            this.namesLabel.TabIndex = 23;
            this.namesLabel.Text = "202005491 Nouf Almutawea , 202205030 Sara Ahmed , 202204540 Fatima Ali";
            // 
            // LearnMoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(757, 289);
            this.Controls.Add(this.namesLabel);
            this.Controls.Add(this.doneByLabel);
            this.Controls.Add(this.UOBpictureBox);
            this.Controls.Add(this.contactInfoLabel);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.learnMoreLabel);
            this.Controls.Add(this.FNSLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LearnMoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn More";
            ((System.ComponentModel.ISupportInitialize)(this.UOBpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contactInfoLabel;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label learnMoreLabel;
        private System.Windows.Forms.Label FNSLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox UOBpictureBox;
        private System.Windows.Forms.Label doneByLabel;
        private System.Windows.Forms.Label namesLabel;
    }
}