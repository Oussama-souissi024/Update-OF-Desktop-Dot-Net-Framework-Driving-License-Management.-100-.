using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using Full_C__DVLD_Project.Golobal_Classes;
using Microsoft.Win32;

namespace Full_C__DVLD_Project
{
    public partial class MainForm : Form
    {
        public int UserID;
        public MainForm(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListPeople frm = new FormListPeople() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            panel1.Visible = true;
            frm.Show();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers frm = new FormUsers() { TopLevel = false, FormBorderStyle = FormBorderStyle.None};
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            panel1.Visible = true;
            frm.Show();

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormShowUserDetails(UserID);
            frm.ShowDialog();           
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            this.Hide();
            Authentication frm = new Authentication();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormChangePassword(UserID);
            frm.ShowDialog();
        }

        private void manageDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormDetainLicense(UserID);
            frm.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormNewLocalDrivingLicenseApplication(16);
                frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm = new FormManageLocalDivingApplication(UserID) { TopLevel = false, FormBorderStyle = FormBorderStyle.None } ;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            panel1.Visible = true;
            frm.Show();
        }

        private void manegeTestTyprsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormManageTestTypes();
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormManageApplicationTypes();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormDetainLicense(UserID);
            frm.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormListDrivers() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            panel1.Visible = true;
            frm.Show();
        }

        private void internationalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormNewInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormRenewLicense();
            frm.ShowDialog();
        }

		private void lostDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form frm = new FormReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();
		}

		private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form frm = new FormReleaseDetainedLicense();
            frm.ShowDialog();
		}

		private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new FormManageLocalDivingApplication(UserID) { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
			panel1.Controls.Clear();
			panel1.Controls.Add(frm);
			panel1.Visible = true;
			frm.Show();
		}

		private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
            panel1.Hide();
		}

		private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new FormListInternationalLicesnseApplications() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
			panel1.Controls.Clear();
			panel1.Controls.Add(frm);
			panel1.Visible = true;
			frm.Show();
		}
	}
}
