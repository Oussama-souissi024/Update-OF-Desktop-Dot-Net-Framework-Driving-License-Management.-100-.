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
    public partial class FormListDrivers : Form
    {
        private DataTable _dtAllDrivers;
        public FormListDrivers()
        {
            InitializeComponent();
        }

        private void FormListDrivers_Load(object sender, EventArgs e)
        {
            comboBoxFilterDriversList.SelectedIndex = 0;
            _dtAllDrivers = clsDrivers.GetAllDrivers();
            DGVMAnageDrivers.DataSource = _dtAllDrivers;
            LblRecord.Text = DGVMAnageDrivers.Rows.Count.ToString();
            if (DGVMAnageDrivers.Rows.Count > 0)
            {
                DGVMAnageDrivers.Columns[0].HeaderText = "Driver ID";
                DGVMAnageDrivers.Columns[0].Width = 120;

                DGVMAnageDrivers.Columns[1].HeaderText = "Person ID";
                DGVMAnageDrivers.Columns[1].Width = 120;

                DGVMAnageDrivers.Columns[2].HeaderText = "National No.";
                DGVMAnageDrivers.Columns[2].Width = 140;

                DGVMAnageDrivers.Columns[3].HeaderText = "Full Name";
                DGVMAnageDrivers.Columns[3].Width = 320;

                DGVMAnageDrivers.Columns[4].HeaderText = "Date";
                DGVMAnageDrivers.Columns[4].Width = 170;

                DGVMAnageDrivers.Columns[5].HeaderText = "Active Licenses";
                DGVMAnageDrivers.Columns[5].Width = 150;
            }
        }

        private void comboBoxFilterDriversList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFindDriverByText.Visible = (comboBoxFilterDriversList.Text != "None");


            if (comboBoxFilterDriversList.Text == "None")
            {
                textBoxFindDriverByText.Enabled = false;
            }
            else
                textBoxFindDriverByText.Enabled = true;

            textBoxFindDriverByText.Text = "";
            textBoxFindDriverByText.Focus();
        }

        private void textBoxFindDriverByText_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (comboBoxFilterDriversList.Text)
            {
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (textBoxFindDriverByText.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                LblRecord.Text = DGVMAnageDrivers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
                //in this case we deal with numbers not string.
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, textBoxFindDriverByText.Text.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, textBoxFindDriverByText.Text.Trim());

            LblRecord.Text = _dtAllDrivers.Rows.Count.ToString();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DGVMAnageDrivers.CurrentRow.Cells[1].Value;
            Form frm = new FormShowPersonDetails(PersonID);
            frm.ShowDialog();
            //refresh
            FormListDrivers_Load(null, null);
        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet.");
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DGVMAnageDrivers.CurrentRow.Cells[1].Value;
            Form frm = new FormShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }
    }
}