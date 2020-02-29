namespace Relativity_Account_Disable
{
    partial class frmLogin
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
            this.lblLoginToolTip = new System.Windows.Forms.Label();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLoginSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginToolTip
            // 
            this.lblLoginToolTip.AutoSize = true;
            this.lblLoginToolTip.Location = new System.Drawing.Point(41, 37);
            this.lblLoginToolTip.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblLoginToolTip.Name = "lblLoginToolTip";
            this.lblLoginToolTip.Size = new System.Drawing.Size(780, 37);
            this.lblLoginToolTip.TabIndex = 0;
            this.lblLoginToolTip.Text = "Please login using your domain administrator account";
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.Location = new System.Drawing.Point(250, 159);
            this.txtLoginUserName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(805, 44);
            this.txtLoginUserName.TabIndex = 1;
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.AutoSize = true;
            this.lblLoginUserName.Location = new System.Drawing.Point(41, 168);
            this.lblLoginUserName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(179, 37);
            this.lblLoginUserName.TabIndex = 2;
            this.lblLoginUserName.Text = "User Name";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(41, 285);
            this.lblLoginPassword.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(158, 37);
            this.lblLoginPassword.TabIndex = 3;
            this.lblLoginPassword.Text = "Password";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(250, 276);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(805, 44);
            this.txtLoginPassword.TabIndex = 4;
            this.txtLoginPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoginPassword_KeyDown);
            // 
            // btnLoginSubmit
            // 
            this.btnLoginSubmit.Location = new System.Drawing.Point(871, 453);
            this.btnLoginSubmit.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnLoginSubmit.Name = "btnLoginSubmit";
            this.btnLoginSubmit.Size = new System.Drawing.Size(238, 65);
            this.btnLoginSubmit.TabIndex = 5;
            this.btnLoginSubmit.Text = "Login";
            this.btnLoginSubmit.UseVisualStyleBackColor = true;
            this.btnLoginSubmit.Click += new System.EventHandler(this.btnLoginSubmit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 552);
            this.Controls.Add(this.btnLoginSubmit);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginUserName);
            this.Controls.Add(this.txtLoginUserName);
            this.Controls.Add(this.lblLoginToolTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginToolTip;
        private System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLoginSubmit;
    }
}