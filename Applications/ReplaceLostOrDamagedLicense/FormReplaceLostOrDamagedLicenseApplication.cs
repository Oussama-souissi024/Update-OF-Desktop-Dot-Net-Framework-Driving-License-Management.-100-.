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
using static DVLDBusinessLayer.clsLicenses;

namespace Full_C__DVLD_Project
{
	public partial class FormReplaceLostOrDamagedLicenseApplication : Form
	{
		private int _NewLicenseID = -1;
		private int _LicenseID;
		public FormReplaceLostOrDamagedLicenseApplication()
		{
			InitializeComponent();
		}

		private void _FillGroupBoxApplicationReplacementLicenseInfo(int LicenseID)
		{
			if (!userControlLicenseInfo1.LicenseDetails.IsActive)
			{
				MessageBox.Show("Selected License is not Not Active, choose an active license."
				  , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			lblOldLicenseID.Text = LicenseID.ToString();
			llShowLicenseHistory.Enabled = true;
			buttonSave.Enabled = true;
		}
		private void buttonSearch_Click(object sender, EventArgs e)
		{
			_LicenseID = (int)Convert.ToInt32(textBoxFindLicenseID.Text);

			if (clsLicenses.IsLicenseExist(_LicenseID))
			{
				userControlLicenseInfo1.LicenseID = _LicenseID;
				userControlLicenseInfo1.FillLicenseInformation(_LicenseID);

				_FillGroupBoxApplicationReplacementLicenseInfo(_LicenseID);
			}
			else
			{
				MessageBox.Show("Invalid License ID");
				return;
			}
		}

		private void FormReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
		{
			textBoxFindLicenseID.Focus();
			lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
			lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;

			rbDamagedLicense.Checked = true;
		}

		private int _GetApplicationTypeID()
		{
			//this will decide which application type to use accirding 
			// to user selection.

			if (rbDamagedLicense.Checked)

				return (int)clsApplications.enApplicationType.ReplaceDamagedDrivingLicense;
			else
				return (int)clsApplications.enApplicationType.ReplaceLostDrivingLicense;
		}

		private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form frm = new FormShowPersonLicenseHistory(clsDrivers.GetPersonIDByDriverID(userControlLicenseInfo1.LicenseDetails.DriverID));
			frm.ShowDialog();
		}

		private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form frm = new FormShowLicenseInfo(_NewLicenseID);
			frm.ShowDialog();
		}

		private enIssueReason _GetIssueReason()
		{
			//this will decide which reason to issue a replacement for

			if (rbDamagedLicense.Checked)

				return enIssueReason.DamagedReplacement;
			else
				return enIssueReason.LostReplacement;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			clsLicenses NewLicense = userControlLicenseInfo1.LicenseDetails.Replace(_GetIssueReason(), clsGlobal.CurrentUser.UserID);

			if (NewLicense == null)
			{
				MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			lblApplicationID2.Text = NewLicense.ApplicationID.ToString();
			_NewLicenseID = NewLicense.LicenseID;

			lblRreplacedLicenseID.Text = _NewLicenseID.ToString();
			MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

			gbReplacementFor.Enabled = false;
			buttonSave.Enabled = false;
			llShowLicenseInfo.Enabled = true;

		}

		private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
		{
			lblTitle.Text = "Replacement for Damaged License";
			this.Text = lblTitle.Text;
			lblApplicationFees.Text = clsApplicationTypes.Find(_GetApplicationTypeID()).Fees.ToString();
		}

		private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
		{
			lblTitle.Text = "Replacement for Lost License";
			this.Text = lblTitle.Text;
			lblApplicationFees.Text = clsApplicationTypes.Find(_GetApplicationTypeID()).Fees.ToString();
		}
	}
}
