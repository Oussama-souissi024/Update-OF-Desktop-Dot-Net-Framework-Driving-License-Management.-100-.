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
    public partial class FormRenewLicense : Form
    {
        private int _NewLicenseID = -1;
        private int _LicenseID;
        public FormRenewLicense()
        {
            InitializeComponent();
        }

        private void FormRenewLicense_Load(object sender, EventArgs e)
        {
            textBoxFindLicenseID.Focus();
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;
            lblApplicationFees.Text = clsApplicationTypes.Find((int)clsApplications.enApplicationType.RenewDrivingLicense).Fees.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;

            lblExpirationDate.Text = "[??/??/????]";
            lblLicenseFees.Text = "???";
            lblOldLicenseID.Text = "???";       
            lblTotalFees.Text = "???";

        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             Form frm = new FormShowPersonLicenseHistory(clsDrivers.GetPersonIDByDriverID(userControlLicenseInfo1.LicenseDetails.DriverID));
            frm.ShowDialog();
        }

        private void _FillGroupBoxApplicationNewLicenseInfo(int LicenseID)
        {
            if(!clsLicenses.IsExpired(LicenseID))
            {
                MessageBox.Show("This License Is Not Expired");
                return;
            }

            int DefaultValidityLength = userControlLicenseInfo1.LicenseDetails.LicenseClassIfo.DefaultValidityLength;
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            lblLicenseFees.Text = userControlLicenseInfo1.LicenseDetails.LicenseClassIfo.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = userControlLicenseInfo1.LicenseDetails.Notes;
            lblOldLicenseID.Text = LicenseID.ToString();

            buttonSave.Enabled = true;
            llShowLicenseHistory.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicenses NewLicense = userControlLicenseInfo1.LicenseDetails.RenewLicense(txtNotes.Text.Trim(),clsGlobal.CurrentUser.UserID); ;

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRenewedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            buttonSave.Enabled = false;
            llShowLicenseInfo.Enabled = true;

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new FormShowLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
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
                userControlLicenseInfo1.LicenseID = _LicenseID;
                userControlLicenseInfo1.FillLicenseInformation(_LicenseID);

                _FillGroupBoxApplicationNewLicenseInfo(_LicenseID);
            }
            else
            {
                MessageBox.Show("Invalid License ID");
                return;
            }
        }
    }
}
