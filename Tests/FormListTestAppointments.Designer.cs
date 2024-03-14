namespace Full_C__DVLD_Project
{
    partial class FormListTestAppointments
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.DGVLicenseTestAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            this.pbTestTypeImage = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.userControlApplicationInfo1 = new Full_C__DVLD_Project.UserControlApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLicenseTestAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(468, 116);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(152, 30);
            this.LblTitle.TabIndex = 171;
            this.LblTitle.Text = "Schedule Test ";
            // 
            // DGVLicenseTestAppointments
            // 
            this.DGVLicenseTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLicenseTestAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVLicenseTestAppointments.Location = new System.Drawing.Point(771, 233);
            this.DGVLicenseTestAppointments.Name = "DGVLicenseTestAppointments";
            this.DGVLicenseTestAppointments.Size = new System.Drawing.Size(457, 203);
            this.DGVLicenseTestAppointments.TabIndex = 172;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
            // 
            // editTestToolStripMenuItem
            // 
            this.editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";
            this.editTestToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editTestToolStripMenuItem.Text = "Edit Test";
            this.editTestToolStripMenuItem.Click += new System.EventHandler(this.editTestToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 173;
            this.label1.Text = "Appointments:";
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAppointment.Image = global::Full_C__DVLD_Project.Properties.Resources.add_appointment;
            this.btnAddNewAppointment.Location = new System.Drawing.Point(1175, 171);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(53, 47);
            this.btnAddNewAppointment.TabIndex = 174;
            this.btnAddNewAppointment.UseVisualStyleBackColor = true;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // pbTestTypeImage
            // 
            this.pbTestTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTestTypeImage.Image = global::Full_C__DVLD_Project.Properties.Resources.drivingTest;
            this.pbTestTypeImage.InitialImage = null;
            this.pbTestTypeImage.Location = new System.Drawing.Point(519, 8);
            this.pbTestTypeImage.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pbTestTypeImage.Name = "pbTestTypeImage";
            this.pbTestTypeImage.Size = new System.Drawing.Size(166, 105);
            this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTestTypeImage.TabIndex = 170;
            this.pbTestTypeImage.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.Image = global::Full_C__DVLD_Project.Properties.Resources.save;
            this.buttonSave.Location = new System.Drawing.Point(1014, 477);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(56, 59);
            this.buttonSave.TabIndex = 175;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(840, 454);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(20, 17);
            this.lblRecordsCount.TabIndex = 177;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(771, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 176;
            this.label2.Text = "# Records:";
            // 
            // buttonClose
            // 
            this.buttonClose.Image = global::Full_C__DVLD_Project.Properties.Resources.cancelledbutton2;
            this.buttonClose.Location = new System.Drawing.Point(940, 477);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonClose.Size = new System.Drawing.Size(55, 59);
            this.buttonClose.TabIndex = 183;
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // userControlApplicationInfo1
            // 
            this.userControlApplicationInfo1.LocalDrivingLicenseApplicationID = 0;
            this.userControlApplicationInfo1.Location = new System.Drawing.Point(0, 145);
            this.userControlApplicationInfo1.Name = "userControlApplicationInfo1";
            this.userControlApplicationInfo1.PassedTest = 0;
            this.userControlApplicationInfo1.Size = new System.Drawing.Size(765, 386);
            this.userControlApplicationInfo1.TabIndex = 0;
            // 
            // FormListTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 548);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVLicenseTestAppointments);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.pbTestTypeImage);
            this.Controls.Add(this.userControlApplicationInfo1);
            this.Name = "FormListTestAppointments";
            this.Text = "FormListTestAppointments";
            this.Load += new System.EventHandler(this.FormListTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLicenseTestAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlApplicationInfo userControlApplicationInfo1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private System.Windows.Forms.DataGridView DGVLicenseTestAppointments;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAddNewAppointment;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}