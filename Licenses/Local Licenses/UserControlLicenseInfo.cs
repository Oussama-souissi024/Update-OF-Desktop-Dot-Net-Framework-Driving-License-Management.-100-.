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
    public partial class UserControlLicenseInfo : UserControl
    {
        public int LicenseID { get; set; }
        public clsLicenses LicenseDetails { get; set; }
        public string IsDetained { set { LblIsDetained.Text = value; } }


        public UserControlLicenseInfo()
        {
            InitializeComponent();
        }

        private string _GetLicenseClassNameByLicenseClassID(int LicenseClassID) 
        {
            return  clsLicenseClasses.GetLicenseClassNameByLicenseClassID(LicenseClassID);
        }

        private string _GetLicenceDriverNameByLicenseID(int LicenseID) 
        {
            return clsLicenses.GetLicenceDriverNameByLicenseID(LicenseID);
        }

        private string _GetLicenseDriverNationalNoByLicenseID(int LicenseID)
        {
            return clsLicenses.GetLicenseDriverNationalNoByLicenseID(LicenseID);
        }

        private string _GetLicenseDriverGendorByLicenceID(int LicenseID)
        {
            return clsLicenses.GetLicenseDriverGendorByLicenceID(LicenseID);
        }

        private DateTime _GetLicenseDriverDateOfBirthByLicenseID(int LicenseID)
        {
            return clsLicenses.GetLicenseDriverDateOfBirthByLicenseID(LicenseID);
        }

        private string _GetLicenseDriverImagePathByLicenseID(int LicenseID)
        {
            return clsLicenses.GetLicenseDriverImagePathByLicenseID(LicenseID);
        }

        public void FillLabelIsDetained()
        {

        }
        public void FillLicenseInformation(int LicenseID)
        {
            LicenseDetails = clsLicenses.Find(LicenseID);
            if(LicenseDetails == null)
            {
                MessageBox.Show("Eror To Load License Information");
                return;
            }

            if (_GetLicenseClassNameByLicenseClassID(LicenseDetails.LicenseClass) != "")
                LblClass.Text = _GetLicenseClassNameByLicenseClassID(LicenseDetails.LicenseClass);
            else
            {
                MessageBox.Show("Eror to load License Name");
                return;
            }

            if (_GetLicenceDriverNameByLicenseID(LicenseID) != "")
                LblName.Text = _GetLicenceDriverNameByLicenseID(LicenseID);
            else
            {
                MessageBox.Show("Eror to load License Driver Name");
                return;
            }

            LblLicenseID.Text = LicenseDetails.LicenseID.ToString();

            if (_GetLicenseDriverNationalNoByLicenseID(LicenseID) != "")
                LblNationalNo.Text = _GetLicenseDriverNationalNoByLicenseID(LicenseID);
            else
            {
                MessageBox.Show("Eror to load License Driver National Number");
                return;
            }

            if (_GetLicenseDriverGendorByLicenceID(LicenseID) != "")
                LblGendor.Text = _GetLicenseDriverGendorByLicenceID(LicenseID);
            else
            {
                MessageBox.Show("Eror to load License Driver Gendor");
                return;
            }

            dateTimePickerIssueDate.Value = LicenseDetails.IssueDate;
            LblIssueReason.Text = LicenseDetails.IssueReason.ToString();
            LblNotes.Text = LicenseDetails.Notes;
            LblIsActive.Text = LicenseDetails.IsActive.ToString();

            if (_GetLicenseDriverDateOfBirthByLicenseID(LicenseID) != DateTime.Now)
                dateTimePickerDateOfBirth.Value = _GetLicenseDriverDateOfBirthByLicenseID(LicenseID);
            else
            {
                MessageBox.Show("Eror to load License Driver Date Of Birth");
                return;
            }

            LblDriverID.Text = LicenseDetails.DriverID.ToString();
            dateTimePickerExpirationDate.Value = LicenseDetails.ExpirationDate;

            string imagepath = _GetLicenseDriverImagePathByLicenseID(LicenseID);
            if  (imagepath != "")
                pictureBox1.ImageLocation = imagepath;
            else
            {
                MessageBox.Show("Eror to load License Driver ImagePath");
                return;
            }

            LblIsDetained.Text = (clsDetainedLicenses.IsLicenseDetained(LicenseID)) ?   "Yes" :  "No";
        }

        private void UserControlLicenseInfo_Load(object sender, EventArgs e)
        {
            //FillLicenseInformation(LicenseID);
        }
    }
}
