using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_C__DVLD_Project
{
    public partial class FormManageApplicationTypes : Form
    {
        private DataTable _dtAllApplicationTypes;

        public FormManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _RefreshApplicationTypesList()
        {
            DGVManageApplicationTypes.DataSource = clsApplicationTypes.GetAllApplicationTypes();
            LblRecord.Text = DGVManageApplicationTypes.Rows.Count.ToString();

            DGVManageApplicationTypes.Columns[0].HeaderText = "ID";
            DGVManageApplicationTypes.Columns[0].Width = 110;

            DGVManageApplicationTypes.Columns[1].HeaderText = "Title";
            DGVManageApplicationTypes.Columns[1].Width = 250;

            DGVManageApplicationTypes.Columns[2].HeaderText = "Fees";
            DGVManageApplicationTypes.Columns[2].Width = 60;
        }
        private void FormManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypesList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormEditApplicationTypes((int)DGVManageApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
