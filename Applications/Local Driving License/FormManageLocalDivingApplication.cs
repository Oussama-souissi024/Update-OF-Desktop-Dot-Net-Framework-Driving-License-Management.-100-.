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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Full_C__DVLD_Project
{
    public partial class FormManageLocalDivingApplication : Form
    {
        int _UserID;
        private DataTable _dtAllLocalDrivingLicenseApplications;

        public FormManageLocalDivingApplication(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }


        private void _RefreshApplicationList()
        {

            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplication();
            DGVManageApplication.DataSource = _dtAllLocalDrivingLicenseApplications;

            if (DGVManageApplication.Rows.Count > 0 )
            {
                DGVManageApplication.Columns[0].HeaderText = "L.D.L.AppID";
                DGVManageApplication.Columns[0].Width = 70;

                DGVManageApplication.Columns[1].HeaderText = "Driving Class ";
                DGVManageApplication.Columns[1].Width = 200;

                DGVManageApplication.Columns[2].HeaderText = "National No";
                DGVManageApplication.Columns[2].Width = 70;

                DGVManageApplication.Columns[3].HeaderText = "Full Name";
                DGVManageApplication.Columns[3].Width = 200;

                DGVManageApplication.Columns[4].HeaderText = "Application Date";
                DGVManageApplication.Columns[4].Width = 120;

                DGVManageApplication.Columns[5].HeaderText = "Passed Tests";
                DGVManageApplication.Columns[5].Width = 100;

                DGVManageApplication.Columns[6].HeaderText = "Status";
                DGVManageApplication.Columns[6].Width = 70;
            }
            comboBoxFilterApplicationsList.SelectedIndex = 0;
        }

        private void FormManageLocalDivingApplication_Load(object sender, EventArgs e)
        {
            _RefreshApplicationList();
            LblRecord.Text = DGVManageApplication.Rows.Count.ToString();
        }

        private void pictureBoxAddApplication_Click(object sender, EventArgs e)
        {
            Form frm = new FormNewLocalDrivingLicenseApplication(_UserID);
            frm.ShowDialog();

        }

        private void comboBoxFilterApplicationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFindApplicationByText.Text = "";
            textBoxFindApplicationByText.Focus();
            textBoxFindApplicationByText.Visible = (comboBoxFilterApplicationsList.Text != "None");
        }

        private void textBoxFindApplicationByText_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //map selected filter real column name
            switch (comboBoxFilterApplicationsList.Text)
            {
                case "Local Driving License ApplicationID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "Status";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (textBoxFindApplicationByText.Text == "" || textBoxFindApplicationByText.Text == "None")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                LblRecord.Text = DGVManageApplication.Rows.Count.ToString();

                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID" || FilterColumn == "Passed Tests")
                //in this case we deal with integer not string.
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, textBoxFindApplicationByText.Text.Trim());
            else
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, textBoxFindApplicationByText.Text.Trim());

            LblRecord.Text = DGVManageApplication.Rows.Count.ToString();

        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormShowApplicationInfo((int)DGVManageApplication.CurrentRow.Cells[0].Value, (int)DGVManageApplication.CurrentRow.Cells[5].Value);
            frm.ShowDialog();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)DGVManageApplication.CurrentRow.Cells[0].Value;

            if (clsLocalDrivingLicenseApplications.DeleteLocalDrivingLicenseAppliation(LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh the form again.
                _RefreshApplicationList();
            }
            else
            {
                MessageBox.Show("Could not delete application, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)DGVManageApplication.CurrentRow.Cells[0].Value;

            if (clsLocalDrivingLicenseApplications.CanceledLocalDrivingApplicationByID(LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("Application Canceled Successfully.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh the form again.
                _RefreshApplicationList();
            }
            else
            {
                MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _ScheduleTest(clsTestTypes.enTestType TestType)
        {

            int LocalDrivingLicenseApplicationID = (int)DGVManageApplication.CurrentRow.Cells[0].Value;
            FormListTestAppointments frm = new FormListTestAppointments(LocalDrivingLicenseApplicationID, TestType);
            frm.ShowDialog();
            //refresh
            FormManageLocalDivingApplication_Load(null, null);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DGVManageApplication.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplications LocalDrivingLicenseApplication =
                    clsLocalDrivingLicenseApplications.FindByLocalDrivingAppLicenseID
                                                    (LocalDrivingLicenseApplicationID);

            int TotalPassedTests = (int)DGVManageApplication.CurrentRow.Cells[5].Value;

            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            //Enabled only if person passed all tests and Does not have license. 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            showLicenseToolStripMenuItem.Enabled = LicenseExists;
            ScheduleTestToolStripMenuItem.Enabled = !LicenseExists;

            //Enable/Disable Cancel Menue Item
            //We only canel the applications with status=new.
            cancelApplicationToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enApplicationStatus.New);

            //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            deleteApplicationToolStripMenuItem.Enabled =
                (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enApplicationStatus.New);



            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.VisionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.StreetTest);

            ScheduleTestToolStripMenuItem.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enApplicationStatus.New);

            if (ScheduleTestToolStripMenuItem.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                ScheduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                ScheduleWritingTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                ScheduleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }



        }

        private void ScheduleVisionTestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypes.enTestType.VisionTest);
        }

        private void ScheduleWritingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypes.enTestType.WrittenTest);
        }

        private void ScheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypes.enTestType.StreetTest);
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DGVManageApplication.CurrentRow.Cells[0].Value;
            Form frm = new FormIssueDriverLicenseFirstTime(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            //refresh
            FormManageLocalDivingApplication_Load(null, null);
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DGVManageApplication.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalDrivingLicenseApplications.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID).GetActiveLicenseID();

            if (LicenseID != -1)
            {
                Form frm = new FormShowLicenseInfo(LicenseID);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DGVManageApplication.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplications localDrivingLicenseApplication = clsLocalDrivingLicenseApplications.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            Form frm = new FormShowPersonLicenseHistory(localDrivingLicenseApplication.ApplicationPersonID);
            frm.ShowDialog();
        }
    }
}
