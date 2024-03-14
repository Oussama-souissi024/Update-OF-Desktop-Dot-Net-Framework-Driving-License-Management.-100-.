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
    public partial class UserControlApplicationInfo : UserControl
    {
        public int PersonID  { get; set; }
    public int LocalDrivingLicenseApplicationID { get; set; }
        public int PassedTest { get; set; }

        clsApplications _Application;
        public UserControlApplicationInfo()
        {
            InitializeComponent();
        }

        public void FillApplicationBasinInfoByApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int AppliationID = clsLocalDrivingLicenseApplications.GetApplicationIDByLDApplicationID(LocalDrivingLicenseApplicationID);
            _Application = clsApplications.FindApplicationByID(AppliationID);
            if(_Application != null)
            {
                LblID.Text = AppliationID.ToString();
                LblStatus.Text = _Application.ApplicationStatus.ToString();
                LblFees.Text = _Application.PaidFees.ToString();
                LblType.Text = clsApplicationTypes.GetApplicationTypeTitleByApplicationTypeID(_Application.ApplicationTypeID);
                dateTimePickerApplicationDate.Value = _Application.ApplicationDate;
                dateTimePickerStatusDate.Value = _Application.LastStatusDate;
                LblCreatedBy.Text = clsUsers.GetUserNameByUserID(_Application.CreatedByUserID);
                LblApplicant.Text = clsPeople.GetFullNameByPersonID(_Application.ApplicationPersonID);
                PersonID = _Application.ApplicationPersonID;
            }
        }

        public void FillLocalDrivingApplicationInfoByID(int LocalDrivingLicenseApplicationID)
        {
            LblLocalApplicationID.Text = LocalDrivingLicenseApplicationID.ToString();
            LblLicenseClass.Text = clsLocalDrivingLicenseApplications.GetLicenseClasNameByID(LocalDrivingLicenseApplicationID);
            LblPassedTest.Text = PassedTest.ToString();

            LblShowLicenseInfo.Enabled = (PassedTest == 3);
            pictureBoxLicenseInfo.Enabled = (PassedTest == 3);

        }
        private void UserControlApplicationInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabelViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new FormShowPersonDetails(PersonID);
            frm.ShowDialog();
        }
    }
}
