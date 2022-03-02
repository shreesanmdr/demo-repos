
namespace Aushadi
{
    partial class reportControl
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
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectionBox = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValuebox1 = new System.Windows.Forms.TextBox();
            this.txtValuebox2 = new System.Windows.Forms.TextBox();
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
            this.dgvReport.Location = new System.Drawing.Point(50, 131);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(600, 550);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick);
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            this.productID.Width = 75;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.Width = 250;
            // 
            // productQuantity
            // 
            this.productQuantity.DataPropertyName = "productQuantity";
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Width = 75;
            // 
            // priceSingle
            // 
            this.priceSingle.DataPropertyName = "priceSingle";
            this.priceSingle.HeaderText = "Price@1";
            this.priceSingle.Name = "priceSingle";
            this.priceSingle.Width = 75;
            // 
            // priceMass
            // 
            this.priceMass.DataPropertyName = "priceMass";
            this.priceMass.HeaderText = "Price@10";
            this.priceMass.Name = "priceMass";
            this.priceMass.Width = 75;
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAll.Location = new System.Drawing.Point(570, 69);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(80, 35);
            this.btnSearchAll.TabIndex = 1;
            this.btnSearchAll.Text = "Search";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Category:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectionBox
            // 
            this.selectionBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.selectionBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectionBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.selectionBox.FormattingEnabled = true;
            this.selectionBox.Items.AddRange(new object[] {
            "Search all",
            "Search price@1 greater than",
            "Search price@1 lower than",
            "Search price@10 greater than",
            "Search price@10 lower than",
            "Search quantity is more than",
            "Search quantity is lesser than",
            "Search by price@10 is greater than price @1 by",
            "Search by price@10 is lower than price @1 by",
            "Search by name contains"});
            this.selectionBox.Location = new System.Drawing.Point(215, 22);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(435, 33);
            this.selectionBox.TabIndex = 9;
            this.selectionBox.SelectedIndexChanged += new System.EventHandler(this.selectionBox_SelectedIndexChanged);
            this.selectionBox.SelectedValueChanged += new System.EventHandler(this.selectionBox_SelectedValueChanged);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(46, 79);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(185, 20);
            this.lblValue.TabIndex = 10;
            this.lblValue.Text = "Enter your value here:";
            this.lblValue.Click += new System.EventHandler(this.lblValue_Click);
            // 
            // txtValuebox1
            // 
            this.txtValuebox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuebox1.Location = new System.Drawing.Point(237, 73);
            this.txtValuebox1.Name = "txtValuebox1";
            this.txtValuebox1.Size = new System.Drawing.Size(327, 26);
            this.txtValuebox1.TabIndex = 11;
            this.txtValuebox1.TextChanged += new System.EventHandler(this.txtValuebox1_TextChanged);
            // 
            // txtValuebox2
            // 
            this.txtValuebox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuebox2.Location = new System.Drawing.Point(237, 73);
            this.txtValuebox2.Name = "txtValuebox2";
            this.txtValuebox2.Size = new System.Drawing.Size(327, 26);
            this.txtValuebox2.TabIndex = 12;
            this.txtValuebox2.Visible = false;
            this.txtValuebox2.TextChanged += new System.EventHandler(this.txtValuebox2_TextChanged);
            this.txtValuebox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValuebox2_KeyPress);
            // 
            // reportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValuebox2);
            this.Controls.Add(this.txtValuebox1);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.selectionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.dgvReport);
            this.Name = "reportControl";
            this.Size = new System.Drawing.Size(700, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectionBox;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValuebox1;
        private System.Windows.Forms.TextBox txtValuebox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceSingle;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceMass;
    }
}
