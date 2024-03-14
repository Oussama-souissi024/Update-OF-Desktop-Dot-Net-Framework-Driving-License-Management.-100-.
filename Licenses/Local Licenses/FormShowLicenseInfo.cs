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
    public partial class FormShowLicenseInfo : Form
    {
        private int _LicenseID;
        public FormShowLicenseInfo(int licenseID)
        {
            InitializeComponent();
            _LicenseID = licenseID;
        }

        private void FormShowLicenseInfo_Load(object sender, EventArgs e)
        {
            userControlDriverLicenseInfo1.LoadInfo(_LicenseID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
