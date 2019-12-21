namespace ProductsManager
{
    partial class AddEditForm
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
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.labelSku = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelTM = new System.Windows.Forms.Label();
            this.textBoxTM = new System.Windows.Forms.TextBox();
            this.labelPrName = new System.Windows.Forms.Label();
            this.textBoxPrName = new System.Windows.Forms.TextBox();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelStoreUn = new System.Windows.Forms.Label();
            this.textBoxStoreUn = new System.Windows.Forms.TextBox();
            this.labelProductDetails = new System.Windows.Forms.Label();
            this.textBoxProductDetails = new System.Windows.Forms.TextBox();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonCancel);
            this.groupBoxButtons.Controls.Add(this.buttonSave);
            this.groupBoxButtons.Location = new System.Drawing.Point(33, 632);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(327, 66);
            this.groupBoxButtons.TabIndex = 0;
            this.groupBoxButtons.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(189, 19);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 35);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(22, 17);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 35);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adding Products:";
            // 
            // textBoxSku
            // 
            this.textBoxSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSku.Location = new System.Drawing.Point(36, 122);
            this.textBoxSku.MaxLength = 5;
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(470, 24);
            this.textBoxSku.TabIndex = 2;
            // 
            // labelSku
            // 
            this.labelSku.AutoSize = true;
            this.labelSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSku.Location = new System.Drawing.Point(32, 99);
            this.labelSku.Name = "labelSku";
            this.labelSku.Size = new System.Drawing.Size(112, 20);
            this.labelSku.TabIndex = 1;
            this.labelSku.Text = "SKU Number";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(32, 153);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(81, 20);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategory.Location = new System.Drawing.Point(36, 176);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(470, 24);
            this.textBoxCategory.TabIndex = 2;
            // 
            // labelTM
            // 
            this.labelTM.AutoSize = true;
            this.labelTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTM.Location = new System.Drawing.Point(32, 215);
            this.labelTM.Name = "labelTM";
            this.labelTM.Size = new System.Drawing.Size(99, 20);
            this.labelTM.TabIndex = 1;
            this.labelTM.Text = "Trade Mark";
            // 
            // textBoxTM
            // 
            this.textBoxTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTM.Location = new System.Drawing.Point(36, 238);
            this.textBoxTM.Name = "textBoxTM";
            this.textBoxTM.Size = new System.Drawing.Size(470, 24);
            this.textBoxTM.TabIndex = 2;
            // 
            // labelPrName
            // 
            this.labelPrName.AutoSize = true;
            this.labelPrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrName.Location = new System.Drawing.Point(32, 275);
            this.labelPrName.Name = "labelPrName";
            this.labelPrName.Size = new System.Drawing.Size(122, 20);
            this.labelPrName.TabIndex = 1;
            this.labelPrName.Text = "Product Name";
            // 
            // textBoxPrName
            // 
            this.textBoxPrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrName.Location = new System.Drawing.Point(36, 298);
            this.textBoxPrName.Name = "textBoxPrName";
            this.textBoxPrName.Size = new System.Drawing.Size(470, 24);
            this.textBoxPrName.TabIndex = 2;
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupplier.Location = new System.Drawing.Point(32, 337);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(75, 20);
            this.labelSupplier.TabIndex = 1;
            this.labelSupplier.Text = "Supplier";
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSupplier.Location = new System.Drawing.Point(36, 360);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(470, 24);
            this.textBoxSupplier.TabIndex = 2;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(32, 390);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(97, 20);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price, UAH";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(36, 413);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(470, 24);
            this.textBoxPrice.TabIndex = 2;
            // 
            // labelStoreUn
            // 
            this.labelStoreUn.AutoSize = true;
            this.labelStoreUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStoreUn.Location = new System.Drawing.Point(29, 448);
            this.labelStoreUn.Name = "labelStoreUn";
            this.labelStoreUn.Size = new System.Drawing.Size(121, 20);
            this.labelStoreUn.TabIndex = 1;
            this.labelStoreUn.Text = "Storage Unite";
            // 
            // textBoxStoreUn
            // 
            this.textBoxStoreUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStoreUn.Location = new System.Drawing.Point(33, 471);
            this.textBoxStoreUn.Name = "textBoxStoreUn";
            this.textBoxStoreUn.Size = new System.Drawing.Size(470, 24);
            this.textBoxStoreUn.TabIndex = 2;
            // 
            // labelProductDetails
            // 
            this.labelProductDetails.AutoSize = true;
            this.labelProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductDetails.Location = new System.Drawing.Point(29, 509);
            this.labelProductDetails.Name = "labelProductDetails";
            this.labelProductDetails.Size = new System.Drawing.Size(132, 20);
            this.labelProductDetails.TabIndex = 1;
            this.labelProductDetails.Text = "Product Details";
            // 
            // textBoxProductDetails
            // 
            this.textBoxProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProductDetails.Location = new System.Drawing.Point(33, 532);
            this.textBoxProductDetails.MaximumSize = new System.Drawing.Size(470, 90);
            this.textBoxProductDetails.MinimumSize = new System.Drawing.Size(0, 90);
            this.textBoxProductDetails.Multiline = true;
            this.textBoxProductDetails.Name = "textBoxProductDetails";
            this.textBoxProductDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxProductDetails.Size = new System.Drawing.Size(470, 90);
            this.textBoxProductDetails.TabIndex = 2;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(561, 709);
            this.Controls.Add(this.textBoxProductDetails);
            this.Controls.Add(this.labelProductDetails);
            this.Controls.Add(this.textBoxStoreUn);
            this.Controls.Add(this.labelStoreUn);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.textBoxPrName);
            this.Controls.Add(this.labelPrName);
            this.Controls.Add(this.textBoxTM);
            this.Controls.Add(this.labelTM);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.labelSku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxButtons);
            this.MaximizeBox = false;
            this.Name = "AddEditForm";
            this.Text = "Adding product";
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSku;
        private System.Windows.Forms.Label labelSku;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelTM;
        private System.Windows.Forms.TextBox textBoxTM;
        private System.Windows.Forms.Label labelPrName;
        private System.Windows.Forms.TextBox textBoxPrName;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelStoreUn;
        private System.Windows.Forms.TextBox textBoxStoreUn;
        private System.Windows.Forms.Label labelProductDetails;
        private System.Windows.Forms.TextBox textBoxProductDetails;
    }
}