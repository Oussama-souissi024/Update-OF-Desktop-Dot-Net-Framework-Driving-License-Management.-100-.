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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private bool AuthenticationStatus(string Username, string Password, ref int UserID , ref bool IsActive)
        {
            return clsUsers.Authentication(Username, Password ,ref  UserID, ref IsActive);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int UserID = 0;
            bool IsActive = false;
            if (AuthenticationStatus(textBoxUsername.Text.ToString(), textBoxPassword.Text.ToString(), ref UserID, ref IsActive))
            {
                if (chkRememberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                //incase the user is not active
                if (!IsActive)
                {

                    textBoxUsername.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsUsers _User = clsUsers.GetUserInfoByUserID(UserID);
                clsGlobal.CurrentUser = _User;
                this.Hide();
                Form frm = new MainForm(UserID);
                frm.ShowDialog();
        
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");

                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }

        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                textBoxUsername.Text = UserName;
                textBoxPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }

        
    }
}
