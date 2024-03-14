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
    public partial class FormScheduleTest : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        private int _AppointmentID = -1;

        public FormScheduleTest(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID, int AppointmentID = -1)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestTypeID = TestTypeID;
            _AppointmentID = AppointmentID;
        }

        private void FormScheduleTest_Load(object sender, EventArgs e)
        {
            userControllScheduleTest1.TestTypeID = _TestTypeID;
            userControllScheduleTest1.LoadInfo(_LocalDrivingLicenseApplicationID, _AppointmentID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
