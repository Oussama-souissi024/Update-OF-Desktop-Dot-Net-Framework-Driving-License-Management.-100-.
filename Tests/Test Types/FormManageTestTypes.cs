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
    public partial class FormManageTestTypes : Form
    {
        public FormManageTestTypes()
        {
            InitializeComponent();
        }

        private void _RefreshTestTypesList()
        {
            DGVManageTestTypes.DataSource = clsTestTypes.GetAllTestTypes();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypesList();
            LblRecord.Text = DGVManageTestTypes.Rows.Count.ToString();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormEditTestTypes((clsTestTypes.enTestType) DGVManageTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
