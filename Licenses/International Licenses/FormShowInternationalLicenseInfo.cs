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
    public partial class FormShowInternationalLicenseInfo : Form
    {
        private int _InternationalLicenseID;

        public FormShowInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            userControlInternationalDrivingLicenseInfo1.LoadInfo(_InternationalLicenseID);
        }
    }
}
