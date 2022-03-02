
namespace Aushadi
{
    partial class logIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usrLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.txtUsrName = new System.Windows.Forms.TextBox();
            this.txtUsrPassword = new System.Windows.Forms.TextBox();
            this.btnLogIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usrLabel
            // 
            this.usrLabel.AutoSize = true;
            this.usrLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic);
            this.usrLabel.Location = new System.Drawing.Point(123, 55);
            this.usrLabel.Name = "usrLabel";
            this.usrLabel.Size = new System.Drawing.Size(103, 30);
            this.usrLabel.TabIndex = 0;
            this.usrLabel.Text = "Username";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic);
            this.pwdLabel.Location = new System.Drawing.Point(127, 150);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(96, 30);
            this.pwdLabel.TabIndex = 1;
            this.pwdLabel.Text = "Password";
            // 
            // txtUsrName
            // 
            this.txtUsrName.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtUsrName.Location = new System.Drawing.Point(50, 97);
            this.txtUsrName.Name = "txtUsrName";
            this.txtUsrName.Size = new System.Drawing.Size(250, 35);
            this.txtUsrName.TabIndex = 3;
            // 
            // txtUsrPassword
            // 
            this.txtUsrPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtUsrPassword.Location = new System.Drawing.Point(50, 195);
            this.txtUsrPassword.Name = "txtUsrPassword";
            this.txtUsrPassword.PasswordChar = '*';
            this.txtUsrPassword.Size = new System.Drawing.Size(250, 35);
            this.txtUsrPassword.TabIndex = 4;
            this.txtUsrPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIN
            // 
            this.btnLogIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIN.Location = new System.Drawing.Point(125, 275);
            this.btnLogIN.Name = "btnLogIN";
            this.btnLogIN.Size = new System.Drawing.Size(100, 47);
            this.btnLogIN.TabIndex = 5;
            this.btnLogIN.Text = "Log in";
            this.btnLogIN.UseVisualStyleBackColor = true;
            this.btnLogIN.Click += new System.EventHandler(this.btnLogIN_Click);
            // 
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.btnLogIN);
            this.Controls.Add(this.txtUsrPassword);
            this.Controls.Add(this.txtUsrName);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.usrLabel);
            this.Name = "logIn";
            this.Size = new System.Drawing.Size(350, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.TextBox txtUsrName;
        private System.Windows.Forms.TextBox txtUsrPassword;
        private System.Windows.Forms.Button btnLogIN;
    }
}
