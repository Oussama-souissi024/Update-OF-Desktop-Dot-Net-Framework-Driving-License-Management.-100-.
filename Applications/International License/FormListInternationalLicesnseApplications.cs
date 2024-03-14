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
	public partial class FormListInternationalLicesnseApplications : Form
	{
		private DataTable _dtInternationalLicenseApplications;
		public FormListInternationalLicesnseApplications()
		{
			InitializeComponent();
		}

		private void FormListInternationalLicesnseApplications_Load(object sender, EventArgs e)
		{
			_dtInternationalLicenseApplications = clsInternationalLicense.GetAllInternationalLicenses();
			comboBoxFilterInteernationalApplicationsList.SelectedIndex = 0;

			DGVInternationalLicenses.DataSource = _dtInternationalLicenseApplications;
			labelRecord.Text = DGVInternationalLicenses.Rows.Count.ToString();

			if (DGVInternationalLicenses.Rows.Count > 0)
			{
				DGVInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
				DGVInternationalLicenses.Columns[0].Width = 160;

				DGVInternationalLicenses.Columns[1].HeaderText = "Application ID";
				DGVInternationalLicenses.Columns[2].HeaderText = "Driver ID";
				DGVInternationalLicenses.Columns[2].Width = 130;

				DGVInternationalLicenses.Columns[3].HeaderText = "L.License ID";
				DGVInternationalLicenses.Columns[3].Width = 130;

				DGVInternationalLicenses.Columns[4].HeaderText = "Issue Date";
				DGVInternationalLicenses.Columns[4].Width = 180;

				DGVInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
				DGVInternationalLicenses.Columns[5].Width = 180;

				DGVInternationalLicenses.Columns[6].HeaderText = "Is Active";
				DGVInternationalLicenses.Columns[6].Width = 120;

			}
		}

		private void pictureBoxAddInternationalApplication_Click(object sender, EventArgs e)
		{
			Form frm = new FormNewInternationalLicenseApplication();
			frm.ShowDialog();
		}

		private void comboBoxFilterInteernationalApplicationsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxFilterInteernationalApplicationsList.Text == "Is Active")
			{
				textBoxFindInternationalApplicationByText.Visible = false;
				cbIsReleased.Visible = true;
				cbIsReleased.Focus();
				cbIsReleased.SelectedIndex = 0;
			}

			else

			{

				textBoxFindInternationalApplicationByText.Visible = (comboBoxFilterInteernationalApplicationsList.Text != "None");
				cbIsReleased.Visible = false;

				if (comboBoxFilterInteernationalApplicationsList.Text == "None")
				{
					textBoxFindInternationalApplicationByText.Enabled = false;
					//_dtDetainedLicenses.DefaultView.RowFilter = "";
					//lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();

				}
				else
					textBoxFindInternationalApplicationByText.Enabled = true;

				textBoxFindInternationalApplicationByText.Text = "";
				textBoxFindInternationalApplicationByText.Focus();
			}
		}

		private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int DriverID = (int)DGVInternationalLicenses.CurrentRow.Cells[2].Value;
			int PersonID = clsDrivers.FindByDriverID(DriverID).PersonID;

			Form frm = new FormShowPersonDetails(PersonID);
			frm.ShowDialog();
		}

		private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int InternationalLicenseID = (int)DGVInternationalLicenses.CurrentRow.Cells[0].Value;
			Form frm = new FormShowInternationalLicenseInfo(InternationalLicenseID);
			frm.ShowDialog();
		}

		private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int DriverID = (int)DGVInternationalLicenses.CurrentRow.Cells[2].Value;
			int PersonID = clsDrivers.FindByDriverID(DriverID).PersonID;
			Form frm = new FormShowPersonLicenseHistory(PersonID);
			frm.ShowDialog();
		}

		private void textBoxFindInternationalApplicationByText_TextChanged(object sender, EventArgs e)
		{
			string FilterColumn = "";
			//Map Selected Filter to real Column name 
			switch (comboBoxFilterInteernationalApplicationsList.Text)
			{
				case "International License ID":
					FilterColumn = "InternationalLicenseID";
					break;
				case "Application ID":
					{
						FilterColumn = "ApplicationID";
						break;
					};

				case "Driver ID":
					FilterColumn = "DriverID";
					break;

				case "Local License ID":
					FilterColumn = "IssuedUsingLocalLicenseID";
					break;

				case "Is Active":
					FilterColumn = "IsActive";
					break;


				default:
					FilterColumn = "None";
					break;
			}


			//Reset the filters in case nothing selected or filter value conains nothing.
			if (textBoxFindInternationalApplicationByText.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtInternationalLicenseApplications.DefaultView.RowFilter = "";
				labelRecord.Text = DGVInternationalLicenses.Rows.Count.ToString();
				return;
			}



			_dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, textBoxFindInternationalApplicationByText.Text.Trim());

			labelRecord.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();
		}
	}
}
