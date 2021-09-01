
namespace PasswordKeeper
{
    partial class MainDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDisplay));
            this.containerMain = new System.Windows.Forms.Panel();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.lblRenewal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtRenewalDate = new System.Windows.Forms.TextBox();
            this.txtMonthlyPrice = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listboxAccount = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAccountHeader = new System.Windows.Forms.Label();
            this.containerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerMain
            // 
            this.containerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerMain.Controls.Add(this.btnUpdatePassword);
            this.containerMain.Controls.Add(this.btnShowHide);
            this.containerMain.Controls.Add(this.lblRenewal);
            this.containerMain.Controls.Add(this.lblPrice);
            this.containerMain.Controls.Add(this.lblWebsite);
            this.containerMain.Controls.Add(this.lblPassword);
            this.containerMain.Controls.Add(this.lblUsername);
            this.containerMain.Controls.Add(this.txtRenewalDate);
            this.containerMain.Controls.Add(this.txtMonthlyPrice);
            this.containerMain.Controls.Add(this.txtWebsite);
            this.containerMain.Controls.Add(this.txtPassword);
            this.containerMain.Controls.Add(this.lblAccountName);
            this.containerMain.Controls.Add(this.txtUsername);
            this.containerMain.Location = new System.Drawing.Point(150, 163);
            this.containerMain.Name = "containerMain";
            this.containerMain.Size = new System.Drawing.Size(500, 275);
            this.containerMain.TabIndex = 1;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(290, 102);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(85, 27);
            this.btnUpdatePassword.TabIndex = 12;
            this.btnUpdatePassword.Text = "Update";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // btnShowHide
            // 
            this.btnShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHide.Location = new System.Drawing.Point(124, 102);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(85, 27);
            this.btnShowHide.TabIndex = 11;
            this.btnShowHide.Text = "Show";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // lblRenewal
            // 
            this.lblRenewal.AutoSize = true;
            this.lblRenewal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewal.Location = new System.Drawing.Point(15, 225);
            this.lblRenewal.Name = "lblRenewal";
            this.lblRenewal.Size = new System.Drawing.Size(104, 18);
            this.lblRenewal.TabIndex = 10;
            this.lblRenewal.Text = "Renewal Date:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(73, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 18);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebsite.Location = new System.Drawing.Point(53, 155);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(66, 18);
            this.lblWebsite.TabIndex = 8;
            this.lblWebsite.Text = "Website:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(40, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 18);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(38, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 18);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // txtRenewalDate
            // 
            this.txtRenewalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenewalDate.Location = new System.Drawing.Point(124, 222);
            this.txtRenewalDate.Name = "txtRenewalDate";
            this.txtRenewalDate.Size = new System.Drawing.Size(250, 24);
            this.txtRenewalDate.TabIndex = 5;
            // 
            // txtMonthlyPrice
            // 
            this.txtMonthlyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyPrice.Location = new System.Drawing.Point(124, 187);
            this.txtMonthlyPrice.Name = "txtMonthlyPrice";
            this.txtMonthlyPrice.Size = new System.Drawing.Size(250, 24);
            this.txtMonthlyPrice.TabIndex = 4;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebsite.Location = new System.Drawing.Point(124, 152);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(250, 24);
            this.txtWebsite.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(125, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 24);
            this.txtPassword.TabIndex = 2;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(150, 4);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(200, 18);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "label1";
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(125, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 24);
            this.txtUsername.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(529, 53);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 35);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(529, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listboxAccount
            // 
            this.listboxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxAccount.FormattingEnabled = true;
            this.listboxAccount.ItemHeight = 18;
            this.listboxAccount.Location = new System.Drawing.Point(275, 12);
            this.listboxAccount.Name = "listboxAccount";
            this.listboxAccount.Size = new System.Drawing.Size(250, 130);
            this.listboxAccount.TabIndex = 4;
            this.listboxAccount.SelectedIndexChanged += new System.EventHandler(this.listboxAccount_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(86, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 24);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(672, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 35);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAccountHeader
            // 
            this.lblAccountHeader.AutoSize = true;
            this.lblAccountHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHeader.Location = new System.Drawing.Point(154, 146);
            this.lblAccountHeader.Name = "lblAccountHeader";
            this.lblAccountHeader.Size = new System.Drawing.Size(115, 24);
            this.lblAccountHeader.TabIndex = 7;
            this.lblAccountHeader.Text = "Account Info";
            // 
            // MainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblAccountHeader);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listboxAccount);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.containerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainDisplay";
            this.Text = "PasswordKeeper";
            this.Load += new System.EventHandler(this.MainDisplay_Load);
            this.containerMain.ResumeLayout(false);
            this.containerMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel containerMain;
        private System.Windows.Forms.TextBox txtRenewalDate;
        private System.Windows.Forms.TextBox txtMonthlyPrice;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Label lblRenewal;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox listboxAccount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAccountHeader;
    }
}