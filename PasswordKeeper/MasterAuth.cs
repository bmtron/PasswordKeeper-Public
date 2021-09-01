using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginsLogic;
using System.Configuration;

namespace PasswordKeeper
{
    public partial class MasterAuth : Form
    {

        LoginLogic ll = new LoginLogic();
        public MasterAuth()
        {
            InitializeComponent();
            CenterToScreen();
            txtPassword.PasswordChar = '*';
            lblErrorPassword.Hide();
        }

        private void btnAuthMaster_Click(object sender, EventArgs e)
        {
            var userName = txtUsername.Text;
            var pass = txtPassword.Text;

            bool loginState = ll.authenticateMasterLogin(userName, pass);

            if (loginState)
            {
                MainDisplay newMainDisplay = new MainDisplay(this);

                newMainDisplay.Show();
                this.Owner = newMainDisplay;
                Hide();
            }
            else
            {
                lblErrorPassword.Show();
            }
            
        }

        private void MasterAuth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAuthMaster.PerformClick();
            }
        }
    }
}
