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

namespace PasswordKeeper
{
    public partial class UpdatePassword : Form
    {
        public LoginLogic ll = new LoginLogic();
        public MainDisplay md;
        public UpdatePassword(MainDisplay display)
        {
            InitializeComponent();
            CenterToParent();
            txtVerifyPass.PasswordChar = '*';
            txtNewPass.PasswordChar = '*';
            md = display;
        }

        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            var newPass = txtNewPass.Text;
            var verifyPass = txtVerifyPass.Text;

            if (newPass != verifyPass)
            {
                DialogResult dr = MessageBox.Show("Your passwords do no match.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                var currentLogin = MainDisplay.selectedLogin;
                ll.updatePassword(currentLogin, newPass);
                DialogResult dr = MessageBox.Show("Your password has been successfully updated.", "Success!", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    Close();
                    md.refreshMainDisplay();
                }
            }
        }
    }
}
