
namespace PasswordKeeper
{
    partial class MasterAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterAuth));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAuthMaster = new System.Windows.Forms.Button();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.mainLoginContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainLoginContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(160, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 24);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(160, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 24);
            this.txtPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(79, 73);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 18);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnAuthMaster
            // 
            this.btnAuthMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthMaster.Location = new System.Drawing.Point(210, 203);
            this.btnAuthMaster.Name = "btnAuthMaster";
            this.btnAuthMaster.Size = new System.Drawing.Size(80, 27);
            this.btnAuthMaster.TabIndex = 4;
            this.btnAuthMaster.Text = "Log In";
            this.btnAuthMaster.UseVisualStyleBackColor = true;
            this.btnAuthMaster.Click += new System.EventHandler(this.btnAuthMaster_Click);
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(132, 153);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(236, 34);
            this.lblErrorPassword.TabIndex = 5;
            this.lblErrorPassword.Text = "Username or Password is Incorrect. \r\nPlease Try Again.";
            this.lblErrorPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainLoginContainer
            // 
            this.mainLoginContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLoginContainer.BackColor = System.Drawing.SystemColors.Control;
            this.mainLoginContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainLoginContainer.Controls.Add(this.txtUsername);
            this.mainLoginContainer.Controls.Add(this.lblErrorPassword);
            this.mainLoginContainer.Controls.Add(this.txtPassword);
            this.mainLoginContainer.Controls.Add(this.btnAuthMaster);
            this.mainLoginContainer.Controls.Add(this.lblUsername);
            this.mainLoginContainer.Controls.Add(this.label2);
            this.mainLoginContainer.Location = new System.Drawing.Point(150, 70);
            this.mainLoginContainer.Name = "mainLoginContainer";
            this.mainLoginContainer.Size = new System.Drawing.Size(500, 300);
            this.mainLoginContainer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "PasswordKeeper";
            // 
            // MasterAuth
            // 
            this.AcceptButton = this.btnAuthMaster;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainLoginContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterAuth";
            this.Text = "PasswordKeeper";
            this.mainLoginContainer.ResumeLayout(false);
            this.mainLoginContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAuthMaster;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Panel mainLoginContainer;
        private System.Windows.Forms.Label label1;
    }
}

