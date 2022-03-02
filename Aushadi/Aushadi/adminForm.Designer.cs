
namespace Aushadi
{
    partial class adminForm
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
            this.adminControlPanel = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnMarketing = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnUserControls = new System.Windows.Forms.Button();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.btnBillReport = new System.Windows.Forms.Button();
            this.adminControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminControlPanel
            // 
            this.adminControlPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminControlPanel.Controls.Add(this.btnBillReport);
            this.adminControlPanel.Controls.Add(this.btnReport);
            this.adminControlPanel.Controls.Add(this.btnMarketing);
            this.adminControlPanel.Controls.Add(this.btnProduct);
            this.adminControlPanel.Controls.Add(this.btnUserControls);
            this.adminControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminControlPanel.Location = new System.Drawing.Point(0, 0);
            this.adminControlPanel.Name = "adminControlPanel";
            this.adminControlPanel.Size = new System.Drawing.Size(200, 736);
            this.adminControlPanel.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(30, 442);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(137, 70);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Products Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnMarketing
            // 
            this.btnMarketing.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMarketing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarketing.Location = new System.Drawing.Point(30, 333);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Size = new System.Drawing.Size(137, 70);
            this.btnMarketing.TabIndex = 5;
            this.btnMarketing.Text = "Medicine Sales";
            this.btnMarketing.UseVisualStyleBackColor = false;
            this.btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(30, 224);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(137, 70);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Product Data Controls";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnUserControls
            // 
            this.btnUserControls.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUserControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserControls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUserControls.Location = new System.Drawing.Point(30, 110);
            this.btnUserControls.Name = "btnUserControls";
            this.btnUserControls.Size = new System.Drawing.Size(137, 70);
            this.btnUserControls.TabIndex = 3;
            this.btnUserControls.Text = "User Data Controls";
            this.btnUserControls.UseVisualStyleBackColor = false;
            this.btnUserControls.Click += new System.EventHandler(this.btnUserControls_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bodyPanel.Location = new System.Drawing.Point(199, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(700, 736);
            this.bodyPanel.TabIndex = 1;
            // 
            // btnBillReport
            // 
            this.btnBillReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBillReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillReport.Location = new System.Drawing.Point(30, 563);
            this.btnBillReport.Name = "btnBillReport";
            this.btnBillReport.Size = new System.Drawing.Size(137, 70);
            this.btnBillReport.TabIndex = 7;
            this.btnBillReport.Text = "Sales Report";
            this.btnBillReport.UseVisualStyleBackColor = false;
            this.btnBillReport.Click += new System.EventHandler(this.btnBillReport_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 736);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.adminControlPanel);
            this.MaximizeBox = false;
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aushadi Admin";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.adminControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminControlPanel;
        private System.Windows.Forms.Button btnMarketing;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnUserControls;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBillReport;
    }
}