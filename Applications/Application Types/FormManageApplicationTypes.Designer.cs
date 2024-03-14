namespace Full_C__DVLD_Project
{
    partial class FormManageApplicationTypes
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
            this.LblRecord = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.DGVManageApplicationTypes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.editApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbApplicationTypesmage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVManageApplicationTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypesmage)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRecord
            // 
            this.LblRecord.AutoSize = true;
            this.LblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecord.Location = new System.Drawing.Point(116, 416);
            this.LblRecord.Name = "LblRecord";
            this.LblRecord.Size = new System.Drawing.Size(23, 15);
            this.LblRecord.TabIndex = 126;
            this.LblRecord.Text = "??";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecord.Location = new System.Drawing.Point(54, 416);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(65, 15);
            this.labelRecord.TabIndex = 125;
            this.labelRecord.Text = "# Record";
            // 
            // DGVManageApplicationTypes
            // 
            this.DGVManageApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVManageApplicationTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVManageApplicationTypes.Location = new System.Drawing.Point(52, 184);
            this.DGVManageApplicationTypes.Name = "DGVManageApplicationTypes";
            this.DGVManageApplicationTypes.Size = new System.Drawing.Size(466, 207);
            this.DGVManageApplicationTypes.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(141, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 30);
            this.label1.TabIndex = 122;
            this.label1.Text = "Manage Application Types";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicationTypesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 48);
            // 
            // button1
            // 
            this.button1.Image = global::Full_C__DVLD_Project.Properties.Resources.cancelledbutton2;
            this.button1.Location = new System.Drawing.Point(253, 397);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(55, 54);
            this.button1.TabIndex = 127;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editApplicationTypesToolStripMenuItem
            // 
            this.editApplicationTypesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editApplicationTypesToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.application;
            this.editApplicationTypesToolStripMenuItem.Name = "editApplicationTypesToolStripMenuItem";
            this.editApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.editApplicationTypesToolStripMenuItem.Text = "Edit Application Types";
            this.editApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypesToolStripMenuItem_Click);
            // 
            // pbApplicationTypesmage
            // 
            this.pbApplicationTypesmage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbApplicationTypesmage.Image = global::Full_C__DVLD_Project.Properties.Resources.Application_Types_512;
            this.pbApplicationTypesmage.InitialImage = null;
            this.pbApplicationTypesmage.Location = new System.Drawing.Point(219, 24);
            this.pbApplicationTypesmage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbApplicationTypesmage.Name = "pbApplicationTypesmage";
            this.pbApplicationTypesmage.Size = new System.Drawing.Size(120, 110);
            this.pbApplicationTypesmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationTypesmage.TabIndex = 123;
            this.pbApplicationTypesmage.TabStop = false;
            // 
            // FormManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblRecord);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.DGVManageApplicationTypes);
            this.Controls.Add(this.pbApplicationTypesmage);
            this.Controls.Add(this.label1);
            this.Name = "FormManageApplicationTypes";
            this.Text = "FormManageApplicationTypes";
            this.Load += new System.EventHandler(this.FormManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVManageApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypesmage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblRecord;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.DataGridView DGVManageApplicationTypes;
        private System.Windows.Forms.PictureBox pbApplicationTypesmage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypesToolStripMenuItem;
    }
}