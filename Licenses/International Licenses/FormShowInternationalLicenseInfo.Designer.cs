namespace Full_C__DVLD_Project
{
    partial class FormShowInternationalLicenseInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlInternationalDrivingLicenseInfo1 = new Full_C__DVLD_Project.UserControlInternationalDrivingLicenseInfo();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(340, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Driver License Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Full_C__DVLD_Project.Properties.Resources.Driver_License_world;
            this.pictureBox1.Location = new System.Drawing.Point(327, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // userControlInternationalDrivingLicenseInfo1
            // 
            this.userControlInternationalDrivingLicenseInfo1.Location = new System.Drawing.Point(20, 151);
            this.userControlInternationalDrivingLicenseInfo1.Name = "userControlInternationalDrivingLicenseInfo1";
            this.userControlInternationalDrivingLicenseInfo1.Size = new System.Drawing.Size(852, 315);
            this.userControlInternationalDrivingLicenseInfo1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Image = global::Full_C__DVLD_Project.Properties.Resources.cancelledbutton2;
            this.button1.Location = new System.Drawing.Point(393, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 52);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormShowInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControlInternationalDrivingLicenseInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormShowInternationalLicenseInfo";
            this.Text = "FormShowInternationalLicenseInfo";
            this.Load += new System.EventHandler(this.FormShowInternationalLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private UserControlInternationalDrivingLicenseInfo userControlInternationalDrivingLicenseInfo1;
        private System.Windows.Forms.Button button1;
    }
}