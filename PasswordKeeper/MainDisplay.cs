using DTOs;
using LoginsLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasswordKeeper
{
    public partial class MainDisplay : Form
    {
        public LoginLogic ll = new LoginLogic();
        private bool showPlainTextPass = false;
        public bool ignoreTextChange;

        private List<LoginDdlDTO> allLogins;
        public static LoginDTO selectedLogin;

        private MasterAuth ma;
        public MainDisplay(MasterAuth master)
        {
            InitializeComponent();
            CenterToScreen();
            containerMain.Hide();
            lblAccountHeader.Hide();
            txtSearch.Text = "Search";
            txtSearch.GotFocus += new System.EventHandler(this.txtSearch_GotFocus);
            txtSearch.LostFocus += new System.EventHandler(this.txtSearch_LostFocus);
            ma = master;
        }

        private void txtSearch_GotFocus(Object sender, EventArgs e)
        {
            RemoveText();
        }
        private void txtSearch_LostFocus(Object sender, EventArgs e)
        {
            AddText();
        }
        public void RemoveText()
        {
            if (txtSearch.Text == "Search") 
            {
                txtSearch.Text = "";
            }
        }

        public void AddText()
        {
            if (txtSearch.Text != "Search")
            {
                txtSearch.Text = "Search";
                ignoreTextChange = false;
            }
        }
        private void MainDisplay_Load(object sender, EventArgs e)
        {
            allLogins = ll.getAllAccounts();

            listboxAccount.DataSource = allLogins;
            listboxAccount.DisplayMember = "Account";
            listboxAccount.ValueMember = "LoginID";
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (!showPlainTextPass)
            {
                btnShowHide.Text = "Hide";
                showPlainTextPass = true;
                txtPassword.Text = selectedLogin.PlainTextPassword;
            }
            else
            {
                btnShowHide.Text = "Show";
                showPlainTextPass = false;
                txtPassword.Text = selectedLogin.Password;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var addLogin = new AddLogin(this);
            addLogin.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            allLogins = ll.getAllAccounts();

            listboxAccount.DataSource = allLogins;
            listboxAccount.DisplayMember = "Account";
            listboxAccount.ValueMember = "LoginID";
        }

        private void listboxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxAccount.SelectedIndex != 0)
            {
                var loginDto = ll.getLoginInfo(listboxAccount.SelectedValue.ToString());
                containerMain.Show();
                lblAccountHeader.Show();
                showPlainTextPass = false;
                btnShowHide.Text = "Show";
                lblAccountName.Text = loginDto.Account;
                txtUsername.Text = loginDto.Username;
                txtPassword.Text = loginDto.Password;
                txtWebsite.Text = loginDto.Website;
                txtRenewalDate.Text = loginDto.RenewalDate.ToString();
                txtMonthlyPrice.Text = loginDto.PricePerMonth;
                selectedLogin = loginDto;

            }
            else
            {
                containerMain.Hide();
                lblAccountHeader.Hide();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (ignoreTextChange)
            { return; }

            if (allLogins != null && txtSearch.Text != "Search")
            {
                int index = allLogins.FindIndex(l => l.Account.StartsWith(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase));
                if (index == -1)
                {
                    DialogResult dr = MessageBox.Show("No similar logins found.", "Error", MessageBoxButtons.OK);


                    if (dr == DialogResult.OK)
                    {
                        ignoreTextChange = true;

                        listboxAccount.Select();
                        ignoreTextChange = false;
                    }
                }
                else
                {
                    listboxAccount.SelectedIndex = index;
                }
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            var update = new UpdatePassword(this);
            update.Show();
            
        }

        public void refreshMainDisplay()
        {
            btnRefresh.PerformClick();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
