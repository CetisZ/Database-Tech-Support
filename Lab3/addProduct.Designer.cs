
namespace Lab3
{
    partial class addProduct
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
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.productCode = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.releaseDate = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(148, 45);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 23);
            this.txtProductCode.TabIndex = 0;
            this.txtProductCode.Tag = "Product Code";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(148, 110);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 23);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.Tag = "Product Name";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(148, 184);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(100, 23);
            this.txtVersion.TabIndex = 2;
            this.txtVersion.Tag = "Version";
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(148, 254);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(100, 23);
            this.txtReleaseDate.TabIndex = 3;
            this.txtReleaseDate.Tag = "Release Date";
            // 
            // productCode
            // 
            this.productCode.AutoSize = true;
            this.productCode.Location = new System.Drawing.Point(39, 51);
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(80, 15);
            this.productCode.TabIndex = 4;
            this.productCode.Tag = "Product Code";
            this.productCode.Text = "Product Code";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(39, 109);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(81, 15);
            this.productName.TabIndex = 5;
            this.productName.Tag = "Product Name";
            this.productName.Text = "ProductName";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(39, 183);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(45, 15);
            this.version.TabIndex = 6;
            this.version.Text = "Version";
            // 
            // releaseDate
            // 
            this.releaseDate.AutoSize = true;
            this.releaseDate.Location = new System.Drawing.Point(39, 253);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(73, 15);
            this.releaseDate.TabIndex = 7;
            this.releaseDate.Text = "Release Date";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(94, 321);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(347, 370);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.version);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productCode);
            this.Controls.Add(this.txtReleaseDate);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Name = "addProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.addProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.Label productCode;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label releaseDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}