
namespace PasswordKeeper
{
    partial class UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            this.btnSubmitUpdate = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtVerifyPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblVerifyPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmitUpdate
            // 
            this.btnSubmitUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitUpdate.Location = new System.Drawing.Point(167, 103);
            this.btnSubmitUpdate.Name = "btnSubmitUpdate";
            this.btnSubmitUpdate.Size = new System.Drawing.Size(100, 27);
            this.btnSubmitUpdate.TabIndex = 0;
            this.btnSubmitUpdate.Text = "Update";
            this.btnSubmitUpdate.UseVisualStyleBackColor = true;
            this.btnSubmitUpdate.Click += new System.EventHandler(this.btnSubmitUpdate_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(142, 37);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(181, 24);
            this.txtNewPass.TabIndex = 1;
            // 
            // txtVerifyPass
            // 
            this.txtVerifyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerifyPass.Location = new System.Drawing.Point(142, 73);
            this.txtVerifyPass.Name = "txtVerifyPass";
            this.txtVerifyPass.Size = new System.Drawing.Size(181, 24);
            this.txtVerifyPass.TabIndex = 2;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(23, 40);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(113, 18);
            this.lblNewPass.TabIndex = 3;
            this.lblNewPass.Text = "New Password:";
            // 
            // lblVerifyPass
            // 
            this.lblVerifyPass.AutoSize = true;
            this.lblVerifyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyPass.Location = new System.Drawing.Point(17, 76);
            this.lblVerifyPass.Name = "lblVerifyPass";
            this.lblVerifyPass.Size = new System.Drawing.Size(119, 18);
            this.lblVerifyPass.TabIndex = 4;
            this.lblVerifyPass.Text = "Verify Password:";
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 167);
            this.Controls.Add(this.lblVerifyPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.txtVerifyPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.btnSubmitUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatePassword";
            this.Text = "Update Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitUpdate;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtVerifyPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblVerifyPass;
    }
}