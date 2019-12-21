namespace ProductsManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonAmend = new System.Windows.Forms.Button();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelCatalogue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShow.Location = new System.Drawing.Point(16, 19);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(150, 60);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Show products";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonAmend
            // 
            this.buttonAmend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAmend.Location = new System.Drawing.Point(443, 19);
            this.buttonAmend.Name = "buttonAmend";
            this.buttonAmend.Size = new System.Drawing.Size(150, 60);
            this.buttonAmend.TabIndex = 1;
            this.buttonAmend.Text = "Amend Products";
            this.buttonAmend.UseVisualStyleBackColor = true;
            this.buttonAmend.Click += new System.EventHandler(this.buttonAmend_Click);
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProducts.Location = new System.Drawing.Point(329, 84);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(119, 33);
            this.labelProducts.TabIndex = 2;
            this.labelProducts.Text = "Products";
            // 
            // labelCatalogue
            // 
            this.labelCatalogue.AutoSize = true;
            this.labelCatalogue.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCatalogue.Location = new System.Drawing.Point(243, 117);
            this.labelCatalogue.Name = "labelCatalogue";
            this.labelCatalogue.Size = new System.Drawing.Size(285, 75);
            this.labelCatalogue.TabIndex = 2;
            this.labelCatalogue.Text = "Catalogue";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonShow);
            this.groupBox1.Controls.Add(this.buttonAmend);
            this.groupBox1.Location = new System.Drawing.Point(80, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(824, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCatalogue);
            this.Controls.Add(this.labelProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Catalogue";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(MainForm_Closing);

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonAmend;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelCatalogue;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

