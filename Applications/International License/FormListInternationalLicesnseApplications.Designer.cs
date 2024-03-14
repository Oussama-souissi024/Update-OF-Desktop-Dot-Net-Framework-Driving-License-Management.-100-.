namespace Full_C__DVLD_Project
{
	partial class FormListInternationalLicesnseApplications
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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboBoxFilterInteernationalApplicationsList = new System.Windows.Forms.ComboBox();
			this.textBoxFindInternationalApplicationByText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.DGVInternationalLicenses = new System.Windows.Forms.DataGridView();
			this.pictureBoxAddInternationalApplication = new System.Windows.Forms.PictureBox();
			this.LblRecord = new System.Windows.Forms.Label();
			this.labelRecord = new System.Windows.Forms.Label();
			this.cbIsReleased = new System.Windows.Forms.ComboBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGVInternationalLicenses)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddInternationalApplication)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(261, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(356, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "International Licesnse Applications";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Full_C__DVLD_Project.Properties.Resources.world1;
			this.pictureBox2.Location = new System.Drawing.Point(496, 81);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(48, 34);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Full_C__DVLD_Project.Properties.Resources.MAnage__application;
			this.pictureBox1.Location = new System.Drawing.Point(382, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 103);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// comboBoxFilterInteernationalApplicationsList
			// 
			this.comboBoxFilterInteernationalApplicationsList.FormattingEnabled = true;
			this.comboBoxFilterInteernationalApplicationsList.Items.AddRange(new object[] {
            "None",
            "International License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
			this.comboBoxFilterInteernationalApplicationsList.Location = new System.Drawing.Point(113, 168);
			this.comboBoxFilterInteernationalApplicationsList.Name = "comboBoxFilterInteernationalApplicationsList";
			this.comboBoxFilterInteernationalApplicationsList.Size = new System.Drawing.Size(138, 21);
			this.comboBoxFilterInteernationalApplicationsList.TabIndex = 24;
			this.comboBoxFilterInteernationalApplicationsList.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterInteernationalApplicationsList_SelectedIndexChanged);
			// 
			// textBoxFindInternationalApplicationByText
			// 
			this.textBoxFindInternationalApplicationByText.Location = new System.Drawing.Point(275, 169);
			this.textBoxFindInternationalApplicationByText.Name = "textBoxFindInternationalApplicationByText";
			this.textBoxFindInternationalApplicationByText.Size = new System.Drawing.Size(143, 20);
			this.textBoxFindInternationalApplicationByText.TabIndex = 23;
			this.textBoxFindInternationalApplicationByText.Visible = false;
			this.textBoxFindInternationalApplicationByText.TextChanged += new System.EventHandler(this.textBoxFindInternationalApplicationByText_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(43, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 22;
			this.label2.Text = "Filter By";
			// 
			// DGVInternationalLicenses
			// 
			this.DGVInternationalLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DGVInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVInternationalLicenses.ContextMenuStrip = this.contextMenuStrip1;
			this.DGVInternationalLicenses.Location = new System.Drawing.Point(41, 195);
			this.DGVInternationalLicenses.Name = "DGVInternationalLicenses";
			this.DGVInternationalLicenses.Size = new System.Drawing.Size(863, 222);
			this.DGVInternationalLicenses.TabIndex = 21;
			// 
			// pictureBoxAddInternationalApplication
			// 
			this.pictureBoxAddInternationalApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxAddInternationalApplication.Image = global::Full_C__DVLD_Project.Properties.Resources.Add_new_application;
			this.pictureBoxAddInternationalApplication.Location = new System.Drawing.Point(837, 137);
			this.pictureBoxAddInternationalApplication.Name = "pictureBoxAddInternationalApplication";
			this.pictureBoxAddInternationalApplication.Size = new System.Drawing.Size(67, 50);
			this.pictureBoxAddInternationalApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAddInternationalApplication.TabIndex = 25;
			this.pictureBoxAddInternationalApplication.TabStop = false;
			this.pictureBoxAddInternationalApplication.Click += new System.EventHandler(this.pictureBoxAddInternationalApplication_Click);
			// 
			// LblRecord
			// 
			this.LblRecord.AutoSize = true;
			this.LblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblRecord.Location = new System.Drawing.Point(104, 420);
			this.LblRecord.Name = "LblRecord";
			this.LblRecord.Size = new System.Drawing.Size(23, 15);
			this.LblRecord.TabIndex = 27;
			this.LblRecord.Text = "??";
			// 
			// labelRecord
			// 
			this.labelRecord.AutoSize = true;
			this.labelRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRecord.Location = new System.Drawing.Point(42, 420);
			this.labelRecord.Name = "labelRecord";
			this.labelRecord.Size = new System.Drawing.Size(65, 15);
			this.labelRecord.TabIndex = 26;
			this.labelRecord.Text = "# Record";
			// 
			// cbIsReleased
			// 
			this.cbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIsReleased.FormattingEnabled = true;
			this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
			this.cbIsReleased.Location = new System.Drawing.Point(257, 168);
			this.cbIsReleased.Name = "cbIsReleased";
			this.cbIsReleased.Size = new System.Drawing.Size(121, 21);
			this.cbIsReleased.TabIndex = 164;
			this.cbIsReleased.Visible = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(253, 70);
			// 
			// showApplicationDetailsToolStripMenuItem
			// 
			this.showApplicationDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showApplicationDetailsToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.Show_Details;
			this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
			this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.showApplicationDetailsToolStripMenuItem.Text = "Show Person Details";
			this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
			// 
			// showLicenseToolStripMenuItem
			// 
			this.showLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showLicenseToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.Driving_license_3;
			this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
			this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.showLicenseToolStripMenuItem.Text = "Show License Details";
			this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
			// 
			// showPersonLicenseHistoryToolStripMenuItem
			// 
			this.showPersonLicenseHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showPersonLicenseHistoryToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.driver_;
			this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
			this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
			this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
			// 
			// FormListInternationalLicesnseApplications
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(950, 512);
			this.Controls.Add(this.cbIsReleased);
			this.Controls.Add(this.LblRecord);
			this.Controls.Add(this.labelRecord);
			this.Controls.Add(this.pictureBoxAddInternationalApplication);
			this.Controls.Add(this.comboBoxFilterInteernationalApplicationsList);
			this.Controls.Add(this.textBoxFindInternationalApplicationByText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DGVInternationalLicenses);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "FormListInternationalLicesnseApplications";
			this.Text = "FormListInternationalLicesnseApplications";
			this.Load += new System.EventHandler(this.FormListInternationalLicesnseApplications_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGVInternationalLicenses)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddInternationalApplication)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxFilterInteernationalApplicationsList;
		private System.Windows.Forms.TextBox textBoxFindInternationalApplicationByText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView DGVInternationalLicenses;
		private System.Windows.Forms.PictureBox pictureBoxAddInternationalApplication;
		private System.Windows.Forms.Label LblRecord;
		private System.Windows.Forms.Label labelRecord;
		private System.Windows.Forms.ComboBox cbIsReleased;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
	}
}