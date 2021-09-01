using DTOs;
using LoginsLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordKeeper
{
    public partial class AddLogin : Form
    {
        LoginLogic ll = new LoginLogic();
        private MainDisplay md;
        public AddLogin(MainDisplay main)
        {
            InitializeComponent();
            CenterToParent();
            md = main;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var loginDto = new LoginDTO();
            loginDto.Password = txtAddPassword.Text;
            loginDto.Account = txtAddAccount.Text;
            loginDto.Username = txtAddUsername.Text;
            loginDto.Website = txtAddWebsite.Text;
            loginDto.PricePerMonth = txtAddPrice.Text;
            loginDto.RenewalDate = DateTime.Parse(txtAddRenewalDate.Text.ToString());

            ll.addNewLogin(loginDto);

            DialogResult dr = MessageBox.Show("Your entry has been successfully added.", "Success!", MessageBoxButtons.OK);
            

            if (dr == DialogResult.OK)
            {
                txtAddAccount.Text = "";
                txtAddUsername.Text = "";
                txtAddPassword.Text = "";
                txtAddWebsite.Text = "";
                txtAddPrice.Text = "";
                txtAddRenewalDate.Text = "";
            }
            
        }

        private void btnAddToMain_Click(object sender, EventArgs e)
        {
            
            Close();
            md.Show();
        }
    }
}
