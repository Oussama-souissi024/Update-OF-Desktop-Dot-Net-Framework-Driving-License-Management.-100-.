using DVLDBusinessLayer;
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
    public partial class FormListTestAppointments : Form
    {
        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID;
        private clsTestTypes.enTestType _TestType = clsTestTypes.enTestType.VisionTest;
        public FormListTestAppointments(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;

        }

        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {

                case clsTestTypes.enTestType.VisionTest:
                    {
                        LblTitle.Text = "Vision Test Appointments";
                        this.Text = LblTitle.Text;
                        pbTestTypeImage.Image = Resources.visionTest;
                        break;
                    }

                case clsTestTypes.enTestType.WrittenTest:
                    {
                        LblTitle.Text = "Written Test Appointments";
                        this.Text = LblTitle.Text;
                        pbTestTypeImage.Image = Resources.writenTest;
                        break;
                    }
                case clsTestTypes.enTestType.StreetTest:
                    {
                        LblTitle.Text = "Street Test Appointments";
                        this.Text = LblTitle.Text;
                        pbTestTypeImage.Image = Resources.drivingTest;
                        break;
                    }
            }

        }

        private void FormListTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();


            userControlApplicationInfo1.FillApplicationBasinInfoByApplicationID(_LocalDrivingLicenseApplicationID);
            userControlApplicationInfo1.FillLocalDrivingApplicationInfoByID(_LocalDrivingLicenseApplicationID);

            _dtLicenseTestAppointments = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID, _TestType);

            DGVLicenseTestAppointments.DataSource = _dtLicenseTestAppointments;
            lblRecordsCount.Text = DGVLicenseTestAppointments.Rows.Count.ToString();

            if (DGVLicenseTestAppointments.Rows.Count > 0)
            {
                DGVLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                DGVLicenseTestAppointments.Columns[0].Width = 120;

                DGVLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                DGVLicenseTestAppointments.Columns[1].Width = 140;

                DGVLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                DGVLicenseTestAppointments.Columns[2].Width = 80;

                DGVLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                DGVLicenseTestAppointments.Columns[3].Width = 80;
            }
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplications localDrivingLicenseApplication = clsLocalDrivingLicenseApplications.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);


            if (localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //---
            clsTest LastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_TestType);

            if (LastTest == null)
            {
                FormScheduleTest frm1 = new FormScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
                frm1.ShowDialog();
                FormListTestAppointments_Load(null, null);
                return;
            }

            //if person already passed the test s/he cannot retak it.
            if (LastTest.TestResult == true)
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormScheduleTest frm2 = new FormScheduleTest(LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID, _TestType);
            frm2.ShowDialog();
            FormListTestAppointments_Load(null, null);
            //---
        }

        private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)DGVLicenseTestAppointments.CurrentRow.Cells[0].Value;


            FormScheduleTest frm = new FormScheduleTest(_LocalDrivingLicenseApplicationID, _TestType, TestAppointmentID);
            frm.ShowDialog();
            FormListTestAppointments_Load(null, null);

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)DGVLicenseTestAppointments.CurrentRow.Cells[0].Value;

            Form frm = new FormTakeTest(TestAppointmentID, _TestType);
            frm.ShowDialog();
            FormListTestAppointments_Load(null, null);
        }

      
    }
}
