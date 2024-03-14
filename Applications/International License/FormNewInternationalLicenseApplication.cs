using DVLDBusinessLayer;
using Full_C__DVLD_Project.Golobal_Classes;
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
    public partial class FormNewInternationalLicenseApplication : Form
    {
        int _InternationalLicenseID = -1;
        int _LicenseID = -1 ;

        public FormNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _LicenseID = (int)Convert.ToInt32(textBoxFindLicenseID.Text);

            if (clsLicenses.IsLicenseExist(_LicenseID))
            {
                userControlDriverLicenseInfo1.LoadInfo(_LicenseID);
                lblLocalLicenseID.Text = _LicenseID.ToString();
                lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
                lblIssueDate.Text = lblApplicationDate.Text;
                lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(1));//add one year.
                lblFees.Text = clsApplicationTypes.Find((int)clsApplications.enApplicationType.NewInternationalLicense).Fees.ToString();
                lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
                buttonIssueLicense.Enabled = true;
                LblIssueLicense.Enabled = true;
                llShowLicenseHistory.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid License ID");
                return;
            }
        }

  

        private void buttonIssueLicense_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsInternationalLicense InternationalLicense = new clsInternationalLicense();
            //those are the information for the base application, because it inhirts from application, they are part of the sub class.

            InternationalLicense.ApplicationPersonID = userControlDriverLicenseInfo1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = clsApplications.enApplicationStatus.Completed;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = clsApplicationTypes.Find((int)clsApplications.enApplicationType.NewInternationalLicense).Fees;
            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;


            InternationalLicense.DriverID = userControlDriverLicenseInfo1.SelectedLicenseInfo.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = userControlDriverLicenseInfo1.SelectedLicenseInfo.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);

            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (!InternationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            MessageBox.Show("International License Issued Successfully with ID=" + InternationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            buttonIssueLicense.Enabled = false;
            LblIssueLicense.Enabled = false;
            llShowLicenseInfo.Enabled = true;
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new FormShowInternationalLicenseInfo(_InternationalLicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new FormShowPersonLicenseHistory(clsDrivers.GetPersonIDByDriverID(clsLicenses.GetDriverIDByLicenseID(_LicenseID)));
            frm.ShowDialog();
        }
    }
}
