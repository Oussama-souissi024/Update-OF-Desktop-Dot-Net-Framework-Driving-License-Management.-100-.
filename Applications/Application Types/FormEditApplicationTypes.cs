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
    public partial class FormEditApplicationTypes : Form
    {
        private int _ApplicationTypeID = -1;
        private clsApplicationTypes _ApplicationType;
        public FormEditApplicationTypes(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }

        private void FormEditApplicationTypes_Load(object sender, EventArgs e)
        {
            lblApplicationTypeID.Text = _ApplicationTypeID.ToString();

            _ApplicationType = clsApplicationTypes.Find(_ApplicationTypeID);

            if (_ApplicationType != null)
            {
                txtTitle.Text = _ApplicationType.Title;
                txtFees.Text = _ApplicationType.Fees.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _ApplicationType.Title = txtTitle.Text.Trim();
            _ApplicationType.Fees = Convert.ToDecimal(txtFees.Text.Trim());


            if (_ApplicationType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void txtTitle_Validating_1(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
        //    {
        //        e.Cancel = true;
        //        errorProvider1.SetError(txtTitle, "Title cannot be empty!");
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtTitle, null);
        //    };

        //    if (!clsValidatoin.IsNumber(txtFees.Text))
        //    {
        //        e.Cancel = true;
        //        errorProvider1.SetError(txtFees, "Invalid Number.");
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtFees, null);
        //    };
        //}
    }
}
