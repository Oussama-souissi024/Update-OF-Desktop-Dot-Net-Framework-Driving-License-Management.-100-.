namespace Full_C__DVLD_Project
{
    partial class FormScheduleTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.userControllScheduleTest1 = new Full_C__DVLD_Project.UserControllScheduleTest();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::Full_C__DVLD_Project.Properties.Resources.cancelledbutton2;
            this.button1.Location = new System.Drawing.Point(212, 534);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(55, 54);
            this.button1.TabIndex = 122;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControllScheduleTest1
            // 
            this.userControllScheduleTest1.Location = new System.Drawing.Point(0, 0);
            this.userControllScheduleTest1.Name = "userControllScheduleTest1";
            this.userControllScheduleTest1.Size = new System.Drawing.Size(506, 602);
            this.userControllScheduleTest1.TabIndex = 123;
            this.userControllScheduleTest1.TestTypeID = DVLDBusinessLayer.clsTestTypes.enTestType.WrittenTest;
            // 
            // FormScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 595);
            this.Controls.Add(this.userControllScheduleTest1);
            this.Controls.Add(this.button1);
            this.Name = "FormScheduleTest";
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.FormScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private UserControllScheduleTest userControllScheduleTest1;
    }
}