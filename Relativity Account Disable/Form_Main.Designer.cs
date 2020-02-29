namespace Relativity_Account_Disable
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtMainPath = new System.Windows.Forms.TextBox();
            this.btnMainBrowse = new System.Windows.Forms.Button();
            this.lblMainToolTip = new System.Windows.Forms.Label();
            this.Instructions = new System.Windows.Forms.Label();
            this.btnMainSubmit = new System.Windows.Forms.Button();
            this.btnMainCancel = new System.Windows.Forms.Button();
            this.txtMainOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMainPath
            // 
            this.txtMainPath.Location = new System.Drawing.Point(41, 805);
            this.txtMainPath.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtMainPath.Name = "txtMainPath";
            this.txtMainPath.Size = new System.Drawing.Size(1439, 44);
            this.txtMainPath.TabIndex = 0;
            // 
            // btnMainBrowse
            // 
            this.btnMainBrowse.Location = new System.Drawing.Point(1507, 803);
            this.btnMainBrowse.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnMainBrowse.Name = "btnMainBrowse";
            this.btnMainBrowse.Size = new System.Drawing.Size(238, 65);
            this.btnMainBrowse.TabIndex = 1;
            this.btnMainBrowse.Text = "Browse";
            this.btnMainBrowse.UseVisualStyleBackColor = true;
            // 
            // lblMainToolTip
            // 
            this.lblMainToolTip.AutoSize = true;
            this.lblMainToolTip.Location = new System.Drawing.Point(41, 751);
            this.lblMainToolTip.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMainToolTip.Name = "lblMainToolTip";
            this.lblMainToolTip.Size = new System.Drawing.Size(711, 37);
            this.lblMainToolTip.TabIndex = 2;
            this.lblMainToolTip.Text = "Please enter the path to the relativity user text file";
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.BackColor = System.Drawing.Color.Gainsboro;
            this.Instructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Instructions.Location = new System.Drawing.Point(32, 26);
            this.Instructions.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(1577, 202);
            this.Instructions.TabIndex = 3;
            this.Instructions.Text = resources.GetString("Instructions.Text");
            // 
            // btnMainSubmit
            // 
            this.btnMainSubmit.Location = new System.Drawing.Point(32, 1454);
            this.btnMainSubmit.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnMainSubmit.Name = "btnMainSubmit";
            this.btnMainSubmit.Size = new System.Drawing.Size(345, 114);
            this.btnMainSubmit.TabIndex = 4;
            this.btnMainSubmit.Text = "Run";
            this.btnMainSubmit.UseVisualStyleBackColor = true;
            this.btnMainSubmit.Click += new System.EventHandler(this.btnMainSubmit_Click);
            // 
            // btnMainCancel
            // 
            this.btnMainCancel.Location = new System.Drawing.Point(396, 1454);
            this.btnMainCancel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnMainCancel.Name = "btnMainCancel";
            this.btnMainCancel.Size = new System.Drawing.Size(238, 114);
            this.btnMainCancel.TabIndex = 5;
            this.btnMainCancel.Text = "Cancel";
            this.btnMainCancel.UseVisualStyleBackColor = true;
            this.btnMainCancel.Click += new System.EventHandler(this.btnMainCancel_Click);
            // 
            // txtMainOutput
            // 
            this.txtMainOutput.Location = new System.Drawing.Point(41, 925);
            this.txtMainOutput.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtMainOutput.MaxLength = 3276700;
            this.txtMainOutput.Multiline = true;
            this.txtMainOutput.Name = "txtMainOutput";
            this.txtMainOutput.ReadOnly = true;
            this.txtMainOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMainOutput.ShortcutsEnabled = false;
            this.txtMainOutput.Size = new System.Drawing.Size(1695, 505);
            this.txtMainOutput.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 1602);
            this.Controls.Add(this.txtMainOutput);
            this.Controls.Add(this.btnMainCancel);
            this.Controls.Add(this.btnMainSubmit);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.lblMainToolTip);
            this.Controls.Add(this.btnMainBrowse);
            this.Controls.Add(this.txtMainPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Relativity Account Disable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMainPath;
        private System.Windows.Forms.Button btnMainBrowse;
        private System.Windows.Forms.Label lblMainToolTip;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Button btnMainSubmit;
        private System.Windows.Forms.Button btnMainCancel;
        private System.Windows.Forms.TextBox txtMainOutput;
    }
}