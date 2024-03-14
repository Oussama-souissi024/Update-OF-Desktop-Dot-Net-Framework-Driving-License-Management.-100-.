namespace Full_C__DVLD_Project
{
    partial class FormTakeTest
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
            this.userControlSecheduledTest1 = new Full_C__DVLD_Project.UserControlSecheduledTest();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // userControlSecheduledTest1
            // 
            this.userControlSecheduledTest1.Location = new System.Drawing.Point(45, -14);
            this.userControlSecheduledTest1.Name = "userControlSecheduledTest1";
            this.userControlSecheduledTest1.Size = new System.Drawing.Size(381, 502);
            this.userControlSecheduledTest1.TabIndex = 0;
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMessage.ForeColor = System.Drawing.Color.Red;
            this.lblUserMessage.Location = new System.Drawing.Point(261, 494);
            this.lblUserMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(194, 17);
            this.lblUserMessage.TabIndex = 223;
            this.lblUserMessage.Text = "You cannot change the results";
            this.lblUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserMessage.Visible = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(132, 526);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(333, 91);
            this.txtNotes.TabIndex = 222;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Location = new System.Drawing.Point(200, 492);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(41, 17);
            this.rbFail.TabIndex = 221;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Checked = true;
            this.rbPass.Location = new System.Drawing.Point(132, 492);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(48, 17);
            this.rbPass.TabIndex = 220;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Full_C__DVLD_Project.Properties.Resources.Show_Details;
            this.pictureBox7.Location = new System.Drawing.Point(84, 526);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 219;
            this.pictureBox7.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 526);
            this.label10.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 218;
            this.label10.Text = "Notes:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Full_C__DVLD_Project.Properties.Resources.results;
            this.pictureBox4.Location = new System.Drawing.Point(84, 490);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 217;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 490);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 216;
            this.label8.Text = "Result:";
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::Full_C__DVLD_Project.Properties.Resources.save;
            this.buttonSave.Location = new System.Drawing.Point(264, 623);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(51, 54);
            this.buttonSave.TabIndex = 224;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Full_C__DVLD_Project.Properties.Resources.cancelledbutton2;
            this.button2.Location = new System.Drawing.Point(177, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 54);
            this.button2.TabIndex = 225;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 689);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.userControlSecheduledTest1);
            this.Name = "FormTakeTest";
            this.Text = "FormTakeTest";
            this.Load += new System.EventHandler(this.FormTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlSecheduledTest userControlSecheduledTest1;
        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button2;
    }
}