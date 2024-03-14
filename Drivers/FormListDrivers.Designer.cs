namespace Full_C__DVLD_Project
{
    partial class FormListDrivers
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
            this.labelManagePeople = new System.Windows.Forms.Label();
            this.LblRecord = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.comboBoxFilterDriversList = new System.Windows.Forms.ComboBox();
            this.textBoxFindDriverByText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVMAnageDrivers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInternationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMAnageDrivers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManagePeople
            // 
            this.labelManagePeople.AutoSize = true;
            this.labelManagePeople.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagePeople.ForeColor = System.Drawing.Color.Red;
            this.labelManagePeople.Location = new System.Drawing.Point(359, 113);
            this.labelManagePeople.Name = "labelManagePeople";
            this.labelManagePeople.Size = new System.Drawing.Size(166, 30);
            this.labelManagePeople.TabIndex = 11;
            this.labelManagePeople.Text = "Manage Drivers";
            // 
            // LblRecord
            // 
            this.LblRecord.AutoSize = true;
            this.LblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecord.Location = new System.Drawing.Point(74, 12);
            this.LblRecord.Name = "LblRecord";
            this.LblRecord.Size = new System.Drawing.Size(23, 15);
            this.LblRecord.TabIndex = 16;
            this.LblRecord.Text = "??";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecord.Location = new System.Drawing.Point(12, 12);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(65, 15);
            this.labelRecord.TabIndex = 15;
            this.labelRecord.Text = "# Record";
            // 
            // comboBoxFilterDriversList
            // 
            this.comboBoxFilterDriversList.FormattingEnabled = true;
            this.comboBoxFilterDriversList.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No.",
            "Full Name"});
            this.comboBoxFilterDriversList.Location = new System.Drawing.Point(94, 144);
            this.comboBoxFilterDriversList.Name = "comboBoxFilterDriversList";
            this.comboBoxFilterDriversList.Size = new System.Drawing.Size(138, 21);
            this.comboBoxFilterDriversList.TabIndex = 20;
            this.comboBoxFilterDriversList.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterDriversList_SelectedIndexChanged);
            // 
            // textBoxFindDriverByText
            // 
            this.textBoxFindDriverByText.Location = new System.Drawing.Point(256, 145);
            this.textBoxFindDriverByText.Name = "textBoxFindDriverByText";
            this.textBoxFindDriverByText.Size = new System.Drawing.Size(143, 20);
            this.textBoxFindDriverByText.TabIndex = 19;
            this.textBoxFindDriverByText.Visible = false;
            this.textBoxFindDriverByText.TextChanged += new System.EventHandler(this.textBoxFindDriverByText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filter By";
            // 
            // DGVMAnageDrivers
            // 
            this.DGVMAnageDrivers.AllowUserToAddRows = false;
            this.DGVMAnageDrivers.AllowUserToDeleteRows = false;
            this.DGVMAnageDrivers.AllowUserToOrderColumns = true;
            this.DGVMAnageDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVMAnageDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMAnageDrivers.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVMAnageDrivers.Location = new System.Drawing.Point(12, 171);
            this.DGVMAnageDrivers.Name = "DGVMAnageDrivers";
            this.DGVMAnageDrivers.ReadOnly = true;
            this.DGVMAnageDrivers.Size = new System.Drawing.Size(916, 289);
            this.DGVMAnageDrivers.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.issueInternationalLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(252, 70);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Full_C__DVLD_Project.Properties.Resources.ListDrivers;
            this.pictureBox1.Location = new System.Drawing.Point(366, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.Sechdule_Test;
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.showPersonInfoToolStripMenuItem.Text = "&Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // issueInternationalLicenseToolStripMenuItem
            // 
            this.issueInternationalLicenseToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.world;
            this.issueInternationalLicenseToolStripMenuItem.Name = "issueInternationalLicenseToolStripMenuItem";
            this.issueInternationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.issueInternationalLicenseToolStripMenuItem.Text = "Issue International License";
            this.issueInternationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueInternationalLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.history;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // FormListDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 465);
            this.Controls.Add(this.DGVMAnageDrivers);
            this.Controls.Add(this.comboBoxFilterDriversList);
            this.Controls.Add(this.textBoxFindDriverByText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblRecord);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.labelManagePeople);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormListDrivers";
            this.Text = "FormListDrivers";
            this.Load += new System.EventHandler(this.FormListDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMAnageDrivers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManagePeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblRecord;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.ComboBox comboBoxFilterDriversList;
        private System.Windows.Forms.TextBox textBoxFindDriverByText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVMAnageDrivers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueInternationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}