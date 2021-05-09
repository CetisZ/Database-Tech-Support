
namespace Lab3
{
    partial class ProductMaintenance
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridViewProduct = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewProduct
            // 
            this.GridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.PName,
            this.Version,
            this.ReleaseDate});
            this.GridViewProduct.Location = new System.Drawing.Point(12, 12);
            this.GridViewProduct.MultiSelect = false;
            this.GridViewProduct.Name = "GridViewProduct";
            this.GridViewProduct.RowTemplate.Height = 25;
            this.GridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewProduct.Size = new System.Drawing.Size(430, 338);
            this.GridViewProduct.TabIndex = 0;
            this.GridViewProduct.SelectionChanged += new System.EventHandler(this.GridViewProduct_SelectionChanged);
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Name";
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            // 
            // Version
            // 
            this.Version.DataPropertyName = "Version";
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(61, 367);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(46, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "&Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(120, 367);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(69, 23);
            this.Modify.TabIndex = 2;
            this.Modify.Text = "&Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(197, 367);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(70, 23);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "&Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(323, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(454, 408);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.GridViewProduct);
            this.Name = "ProductMaintenance";
            this.Text = "Product Maintenance";
            this.Load += new System.EventHandler(this.ProductMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button btnExit;
    }
}

