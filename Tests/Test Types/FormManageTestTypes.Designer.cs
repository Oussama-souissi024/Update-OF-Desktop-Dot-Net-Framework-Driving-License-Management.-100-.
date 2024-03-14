namespace Full_C__DVLD_Project
{
    partial class FormManageTestTypes
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
            this.pbApplicationTypesmage = new System.Windows.Forms.PictureBox();
            this.DGVManageTestTypes = new System.Windows.Forms.DataGridView();
            this.LblRecord = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypesmage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVManageTestTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(216, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Test Types";
            // 
            // pbApplicationTypesmage
            // 
            this.pbApplicationTypesmage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbApplicationTypesmage.Image = global::Full_C__DVLD_Project.Properties.Resources.TestType_512;
            this.pbApplicationTypesmage.InitialImage = null;
            this.pbApplicationTypesmage.Location = new System.Drawing.Point(259, 6);
            this.pbApplicationTypesmage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbApplicationTypesmage.Name = "pbApplicationTypesmage";
            this.pbApplicationTypesmage.Size = new System.Drawing.Size(120, 110);
            this.pbApplicationTypesmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationTypesmage.TabIndex = 117;
            this.pbApplicationTypesmage.TabStop = false;
            // 
            // DGVManageTestTypes
            // 
            this.DGVManageTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVManageTestTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVManageTestTypes.Location = new System.Drawing.Point(92, 166);
            this.DGVManageTestTypes.Name = "DGVManageTestTypes";
            this.DGVManageTestTypes.Size = new System.Drawing.Size(447, 121);
            this.DGVManageTestTypes.TabIndex = 118;
            // 
            // LblRecord
            // 
            this.LblRecord.AutoSize = true;
            this.LblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecord.Location = new System.Drawing.Point(151, 312);
            this.LblRecord.Name = "LblRecord";
            this.LblRecord.Size = new System.Drawing.Size(23, 15);
            this.LblRecord.TabIndex = 120;
            this.LblRecord.Text = "??";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecord.Location = new System.Drawing.Point(89, 312);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(65, 15);
            this.labelRecord.TabIndex = 119;
            this.labelRecord.Text = "# Record";
            // 
            // button1
            // 
            this.button1.Image = global::Full_C__DVLD_Project.Properties.Resources.cancelledbutton2;
            this.button1.Location = new System.Drawing.Point(288, 293);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(55, 54);
            this.button1.TabIndex = 121;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // editTestTypeToolStripMenuItem
            // 
            this.editTestTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTestTypeToolStripMenuItem.Image = global::Full_C__DVLD_Project.Properties.Resources.Manage_test;
            this.editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            this.editTestTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            this.editTestTypeToolStripMenuItem.Click += new System.EventHandler(this.editTestTypeToolStripMenuItem_Click);
            // 
            // FormManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblRecord);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.DGVManageTestTypes);
            this.Controls.Add(this.pbApplicationTypesmage);
            this.Controls.Add(this.label1);
            this.Name = "FormManageTestTypes";
            this.Text = "FormManageTestTypes";
            this.Load += new System.EventHandler(this.FormManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypesmage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVManageTestTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbApplicationTypesmage;
        private System.Windows.Forms.DataGridView DGVManageTestTypes;
        private System.Windows.Forms.Label LblRecord;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editTestTypeToolStripMenuItem;
    }
}