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
    public partial class FormReleaseDetainedLicense : Form
    {
        int  _LicenseID;

        public FormReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        private void _FillGroupBoxDetainInfo(int LicenseID)
        {
            clsDetainedLicenses DetaindLicenseInfo = new clsDetainedLicenses();
            DetaindLicenseInfo = clsDetainedLicenses.FindByLicenseID(LicenseID);

            if (! clsDetainedLicenses.IsLicenseDetained(LicenseID) )
            {
                lblDetainID.Text = "??";
                lblDetainDate.Text = DateTime.Now.ToString();
                lblFineFees.Text = "??";
                lblApplicationFees.Text = "??";
                lblTotalFees.Text = "??";
            }
            else
            {
                lblDetainID.Text = DetaindLicenseInfo.DetainID.ToString();
                lblDetainDate.Text = DetaindLicenseInfo.DetainDate.ToString();
                lblFineFees.Text = DetaindLicenseInfo.FineFees.ToString();
                lblApplicationFees.Text = clsApplicationTypes.Find((int)clsApplications.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString();

                decimal applicationFees;
                decimal fineFees;

                if (decimal.TryParse(lblApplicationFees.Text, out applicationFees) && decimal.TryParse(lblFineFees.Text, out fineFees))
                {
                    lblTotalFees.Text = (applicationFees + fineFees).ToString();
                }
                else
                {
                    // Handle the case where conversion fails (e.g., display an error message)
                    MessageBox.Show("Invalid Int Fees");
                    return;
                }
            }
   
            lblLicenseID.Text = LicenseID.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserID.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _LicenseID = (int)Convert.ToInt32(textBoxFindLicenseID.Text);

            if (clsLicenses.IsLicenseExist(_LicenseID))
            {
                userControlLicenseInfo1.LicenseID = _LicenseID;
                userControlLicenseInfo1.FillLicenseInformation(_LicenseID);

                _FillGroupBoxDetainInfo(_LicenseID);

                if (IsLicenseDetained(_LicenseID))
                    buttonSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid License ID");
                return;
            }
        }

      

        public bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenses.IsLicenseDetained(LicenseID);
        }

        private void FormReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            buttonSave.Enabled = false;
            textBoxFindLicenseID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = -1;

            int PersonID = clsDrivers.GetPersonIDByDriverID(clsLicenses.GetDriverIDByLicenseID(_LicenseID));
            if(PersonID != -1)
            {
                int DetainID;
                int.TryParse(lblDetainID.Text, out DetainID);
                if(clsLicenses.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID, PersonID, DetainID, ref ApplicationID))
                {
                    lblApplicationID.Text = ApplicationID.ToString();
                    buttonSave.Enabled = false;
                    MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else 
            {
                MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            userControlLicenseInfo1.IsDetained = "No";
        }
    }
}
