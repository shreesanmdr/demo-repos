
namespace Aushadi
{
    partial class UserDataControl
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnSerachFromUsername = new System.Windows.Forms.Button();
            this.lblRecommend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(280, 107);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(84, 30);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "UserID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserID.Location = new System.Drawing.Point(371, 107);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(123, 29);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserName.Location = new System.Drawing.Point(280, 241);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(215, 29);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserName_MouseClick);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUserName.Location = new System.Drawing.Point(280, 183);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(116, 30);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username:";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserPassword.Location = new System.Drawing.Point(280, 358);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(215, 29);
            this.txtUserPassword.TabIndex = 5;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUserPassword.Location = new System.Drawing.Point(280, 307);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(111, 30);
            this.lblUserPassword.TabIndex = 4;
            this.lblUserPassword.Text = "Password:";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePassword.Location = new System.Drawing.Point(322, 441);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(129, 51);
            this.btnUpdatePassword.TabIndex = 7;
            this.btnUpdatePassword.Text = "Update";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUserDelete.Location = new System.Drawing.Point(538, 441);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(129, 51);
            this.btnUserDelete.TabIndex = 8;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCreateUser.Location = new System.Drawing.Point(88, 441);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(129, 51);
            this.btnCreateUser.TabIndex = 9;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnSerachFromUsername
            // 
            this.btnSerachFromUsername.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerachFromUsername.Location = new System.Drawing.Point(523, 234);
            this.btnSerachFromUsername.Name = "btnSerachFromUsername";
            this.btnSerachFromUsername.Size = new System.Drawing.Size(129, 41);
            this.btnSerachFromUsername.TabIndex = 10;
            this.btnSerachFromUsername.Text = "Search";
            this.btnSerachFromUsername.UseVisualStyleBackColor = true;
            this.btnSerachFromUsername.Click += new System.EventHandler(this.btnSerachFromUsername_Click);
            // 
            // lblRecommend
            // 
            this.lblRecommend.AutoSize = true;
            this.lblRecommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommend.Location = new System.Drawing.Point(282, 139);
            this.lblRecommend.Name = "lblRecommend";
            this.lblRecommend.Size = new System.Drawing.Size(148, 16);
            this.lblRecommend.TabIndex = 11;
            this.lblRecommend.Text = "Recommended ID = ";
            // 
            // UserDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRecommend);
            this.Controls.Add(this.btnSerachFromUsername);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.btnUserDelete);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserID);
            this.Name = "UserDataControl";
            this.Size = new System.Drawing.Size(770, 600);
            this.Load += new System.EventHandler(this.UserDataControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnSerachFromUsername;
        private System.Windows.Forms.Label lblRecommend;
    }
}
