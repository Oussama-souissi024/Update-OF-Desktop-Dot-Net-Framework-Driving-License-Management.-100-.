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
    public partial class FormShowPersonLicenseHistory : Form
    {
        private int _PersonID = -1;
        private int _DriverID;
        private clsDrivers _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;


        public FormShowPersonLicenseHistory(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadLocalLicenseInfo()
        {

            _dtDriverLocalLicensesHistory = clsDrivers.GetLicenses(_DriverID);


            dgvLocalLicensesHistory.DataSource = _dtDriverLocalLicensesHistory;
            lblLocalLicensesRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicensesHistory.Columns[0].Width = 110;

                dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvLocalLicensesHistory.Columns[1].Width = 110;

                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].Width = 270;

                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 170;

                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].Width = 170;

                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 110;

            }
        }

        private void _LoadInternationalLicenseInfo()
        {

            _dtDriverInternationalLicensesHistory = clsDrivers.GetInternationalLicenses(_DriverID);


            dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;
            lblInternationalLicensesRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();

            if (dgvInternationalLicensesHistory.Rows.Count > 0)
            {
                dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicensesHistory.Columns[0].Width = 160;

                dgvInternationalLicensesHistory.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicensesHistory.Columns[1].Width = 130;

                dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicensesHistory.Columns[2].Width = 130;

                dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicensesHistory.Columns[3].Width = 180;

                dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicensesHistory.Columns[4].Width = 180;

                dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicensesHistory.Columns[5].Width = 120;

            }
        }

        public void LoadInfo(int DriverID)
        {
            _Driver = clsDrivers.FindByPersonID(_PersonID);
            if (_Driver != null)
                _DriverID = _Driver.DriverID;
            else
            {
                MessageBox.Show("Eror to load Driver informations");
                return;
            }

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();

        }
        private void FormShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {

            if (_PersonID != -1)
            {
                userControlShowPersonDetails1.FillCardInformation(_PersonID);
                LoadInfo(_PersonID);
            }
            else
            {
                MessageBox.Show("Eror to load ");
            }


        }

        
    }
}
