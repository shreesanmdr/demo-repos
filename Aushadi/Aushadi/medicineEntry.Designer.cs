
namespace Aushadi
{
    partial class medicineEntry
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMassPrice = new System.Windows.Forms.TextBox();
            this.lblMassPrice = new System.Windows.Forms.Label();
            this.txtSinglePrice = new System.Windows.Forms.TextBox();
            this.lblSinglePrice = new System.Windows.Forms.Label();
            this.txtProductUpdt = new System.Windows.Forms.TextBox();
            this.lblNameUpdt = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMedicineID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.btnSearchFromID = new System.Windows.Forms.Button();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnDelete.Location = new System.Drawing.Point(469, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 43);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnUpdate.Location = new System.Drawing.Point(278, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 43);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnAdd.Location = new System.Drawing.Point(73, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 43);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMassPrice
            // 
            this.txtMassPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtMassPrice.Location = new System.Drawing.Point(278, 332);
            this.txtMassPrice.Name = "txtMassPrice";
            this.txtMassPrice.Size = new System.Drawing.Size(180, 33);
            this.txtMassPrice.TabIndex = 18;
            this.txtMassPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMassPrice_KeyPress);
            // 
            // lblMassPrice
            // 
            this.lblMassPrice.AutoSize = true;
            this.lblMassPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblMassPrice.Location = new System.Drawing.Point(273, 282);
            this.lblMassPrice.Name = "lblMassPrice";
            this.lblMassPrice.Size = new System.Drawing.Size(123, 30);
            this.lblMassPrice.TabIndex = 17;
            this.lblMassPrice.Text = "Price(Mass):";
            // 
            // txtSinglePrice
            // 
            this.txtSinglePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSinglePrice.Location = new System.Drawing.Point(73, 332);
            this.txtSinglePrice.Name = "txtSinglePrice";
            this.txtSinglePrice.Size = new System.Drawing.Size(180, 33);
            this.txtSinglePrice.TabIndex = 16;
            this.txtSinglePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSinglePrice_KeyPress);
            // 
            // lblSinglePrice
            // 
            this.lblSinglePrice.AutoSize = true;
            this.lblSinglePrice.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblSinglePrice.Location = new System.Drawing.Point(73, 282);
            this.lblSinglePrice.Name = "lblSinglePrice";
            this.lblSinglePrice.Size = new System.Drawing.Size(150, 30);
            this.lblSinglePrice.TabIndex = 15;
            this.lblSinglePrice.Text = "Price(Singular):";
            // 
            // txtProductUpdt
            // 
            this.txtProductUpdt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtProductUpdt.Location = new System.Drawing.Point(73, 231);
            this.txtProductUpdt.Name = "txtProductUpdt";
            this.txtProductUpdt.Size = new System.Drawing.Size(576, 33);
            this.txtProductUpdt.TabIndex = 14;
            // 
            // lblNameUpdt
            // 
            this.lblNameUpdt.AutoSize = true;
            this.lblNameUpdt.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblNameUpdt.Location = new System.Drawing.Point(73, 192);
            this.lblNameUpdt.Name = "lblNameUpdt";
            this.lblNameUpdt.Size = new System.Drawing.Size(257, 30);
            this.lblNameUpdt.TabIndex = 13;
            this.lblNameUpdt.Text = "Updated Name of Product";
            // 
            // txtProductName
            // 
            this.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtProductName.Location = new System.Drawing.Point(73, 143);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(453, 33);
            this.txtProductName.TabIndex = 12;
            this.txtProductName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtProductName_MouseClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblName.Location = new System.Drawing.Point(73, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(172, 30);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name of Product";
            // 
            // txtMedicineID
            // 
            this.txtMedicineID.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtMedicineID.Location = new System.Drawing.Point(209, 48);
            this.txtMedicineID.Name = "txtMedicineID";
            this.txtMedicineID.Size = new System.Drawing.Size(129, 33);
            this.txtMedicineID.TabIndex = 23;
            this.txtMedicineID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicineID_KeyPress);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblProductID.Location = new System.Drawing.Point(73, 50);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(117, 30);
            this.lblProductID.TabIndex = 22;
            this.lblProductID.Text = "Product ID:";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.Location = new System.Drawing.Point(464, 61);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(140, 16);
            this.lblRequired.TabIndex = 24;
            this.lblRequired.Text = "Recommended ID=";
            this.lblRequired.Visible = false;
            // 
            // btnSearchFromID
            // 
            this.btnSearchFromID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFromID.Location = new System.Drawing.Point(344, 49);
            this.btnSearchFromID.Name = "btnSearchFromID";
            this.btnSearchFromID.Size = new System.Drawing.Size(114, 32);
            this.btnSearchFromID.TabIndex = 25;
            this.btnSearchFromID.Text = "Search";
            this.btnSearchFromID.UseVisualStyleBackColor = true;
            this.btnSearchFromID.Click += new System.EventHandler(this.btnSearchFromID_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByName.Location = new System.Drawing.Point(535, 143);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(114, 33);
            this.btnSearchByName.TabIndex = 26;
            this.btnSearchByName.Text = "Search";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtQuantity.Location = new System.Drawing.Point(469, 332);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(180, 33);
            this.txtQuantity.TabIndex = 28;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblQuantity.Location = new System.Drawing.Point(464, 282);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(98, 30);
            this.lblQuantity.TabIndex = 27;
            this.lblQuantity.Text = "Quantity:";
            // 
            // medicineEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.btnSearchFromID);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.txtMedicineID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMassPrice);
            this.Controls.Add(this.lblMassPrice);
            this.Controls.Add(this.txtSinglePrice);
            this.Controls.Add(this.lblSinglePrice);
            this.Controls.Add(this.txtProductUpdt);
            this.Controls.Add(this.lblNameUpdt);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblName);
            this.Name = "medicineEntry";
            this.Size = new System.Drawing.Size(730, 460);
            this.Load += new System.EventHandler(this.medicineEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMassPrice;
        private System.Windows.Forms.Label lblMassPrice;
        private System.Windows.Forms.TextBox txtSinglePrice;
        private System.Windows.Forms.Label lblSinglePrice;
        private System.Windows.Forms.TextBox txtProductUpdt;
        private System.Windows.Forms.Label lblNameUpdt;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMedicineID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Button btnSearchFromID;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
    }
}
