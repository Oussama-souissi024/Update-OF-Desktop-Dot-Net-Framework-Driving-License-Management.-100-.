using DVLDBusinessLayer;
using Full_C__DVLD_Project.Golobal_Classes;
using Full_C__DVLD_Project.Properties;
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
    public partial class UserControlDriverLicenseInfo : UserControl
    {
        private int _LicenseID;
        private clsLicenses _License;
        public UserControlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicenses SelectedLicenseInfo
        { get { return _License; } }
 

        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicenses.Find(_LicenseID);
            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }

            lblLicenseID.Text = _License.LicenseID.ToString();
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";
            lblClass.Text = _License.LicenseClassIfo.ClassName;
            lblFullName.Text = clsPeople.GetFullNameByPersonID(_License.DriverInfo.PersonInfo.PresonID);
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = _License.DriverInfo.PersonInfo.Gendor == 1 ? "Male" : "Female";
            lblDateOfBirth.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.DateOfBirth);

            lblDriverID.Text = _License.DriverID.ToString();
            lblIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lblExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lblIssueReason.Text = _License.IssueReasonText;
            lblNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;
            pbPersonImage.Load(_License.DriverInfo.PersonInfo.ImagePath);

        }

        private void UserControlDriverLicenseInfo_Load(object sender, EventArgs e)
        {

        }

       
    }
}
