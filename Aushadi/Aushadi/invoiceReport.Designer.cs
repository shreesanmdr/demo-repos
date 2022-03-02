
namespace Aushadi
{
    partial class invoiceReport
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceSingle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValuebox2 = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.selectionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productQuantity,
            this.priceSingle,
            this.priceMass});
            this.dgvReport.Location = new System.Drawing.Point(52, 130);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(600, 550);
            this.dgvReport.TabIndex = 13;
            // 
            // productID
            // 
            this.productID.DataPropertyName = "InvoiceID";
            this.productID.HeaderText = "Invoice ID";
            this.productID.Name = "productID";
            this.productID.Width = 75;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "InvoiceDate";
            this.productName.HeaderText = "Invoice Date";
            this.productName.Name = "productName";
            this.productName.Width = 250;
            // 
            // productQuantity
            // 
            this.productQuantity.DataPropertyName = "NetAmount";
            this.productQuantity.HeaderText = "Total";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Width = 75;
            // 
            // priceSingle
            // 
            this.priceSingle.DataPropertyName = "PaidAmount";
            this.priceSingle.HeaderText = "Paid Amount";
            this.priceSingle.Name = "priceSingle";
            this.priceSingle.Width = 75;
            // 
            // priceMass
            // 
            this.priceMass.DataPropertyName = "Balance";
            this.priceMass.HeaderText = "Return Amount";
            this.priceMass.Name = "priceMass";
            this.priceMass.Width = 75;
            // 
            // txtValuebox2
            // 
            this.txtValuebox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuebox2.Location = new System.Drawing.Point(239, 75);
            this.txtValuebox2.Name = "txtValuebox2";
            this.txtValuebox2.Size = new System.Drawing.Size(327, 26);
            this.txtValuebox2.TabIndex = 19;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(48, 78);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(185, 20);
            this.lblValue.TabIndex = 17;
            this.lblValue.Text = "Enter your value here:";
            // 
            // selectionBox
            // 
            this.selectionBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.selectionBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectionBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.selectionBox.FormattingEnabled = true;
            this.selectionBox.Items.AddRange(new object[] {
            "Search all",
            "Search by invoice ID",
            "Search by total is higher than",
            "Search by total is lower than"});
            this.selectionBox.Location = new System.Drawing.Point(217, 21);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(435, 33);
            this.selectionBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Category:";
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAll.Location = new System.Drawing.Point(572, 68);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(80, 35);
            this.btnSearchAll.TabIndex = 14;
            this.btnSearchAll.Text = "Search";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // invoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.txtValuebox2);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.selectionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchAll);
            this.Name = "invoiceReport";
            this.Size = new System.Drawing.Size(700, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.TextBox txtValuebox2;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ComboBox selectionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceSingle;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceMass;
    }
}
