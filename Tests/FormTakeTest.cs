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
    public partial class FormTakeTest : Form
    {
        private int _AppointmentID;
        private clsTestTypes.enTestType _TestType;

        private int _TestID = -1;
        private clsTest _Test;
        public FormTakeTest(int AppointmentID, clsTestTypes.enTestType TestType)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _TestType = TestType;
        }

        private void FormTakeTest_Load(object sender, EventArgs e)
        {
            userControlSecheduledTest1.TestTypeID = _TestType;

            userControlSecheduledTest1.LoadInfo(_AppointmentID);

            if (userControlSecheduledTest1.TestAppointmentID == -1)
                buttonSave.Enabled = false;
            else
                buttonSave.Enabled = true;


            int _TestID = userControlSecheduledTest1.TestID;
            if (_TestID != -1)
            {
                _Test = clsTest.Find(_TestID);

                if (_Test.TestResult)
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;
                txtNotes.Text = _Test.Notes;

                lblUserMessage.Visible = true;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
            }

            else
                _Test = new clsTest();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
               )
            {
                return;
            }

            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
