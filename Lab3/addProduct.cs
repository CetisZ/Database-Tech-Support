//Lab3 description
// Create Windows Forms application called "ProductMaintenance" that lets the user maintain products.
// The application consists of two forms "ProductMaintenance" and "Add+Modify Products"
// This file present the code wirtten for "Add+Modify Products" form
// Ceti Zyko, 05May2021

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Models;

namespace Lab3
{
    public partial class addProduct : Form    // Declaration of Class for "addProduct" form
    {
        // Connection string to SQL Database "TechSupport"
        TechSupportContext context = new TechSupportContext(ConfigurationManager.ConnectionStrings["TechSupport"].
                        ConnectionString);
        public Product myProduct { get; set; } // accessor method
        public bool addButtonStatus { get; set; } // accessor method

        public addProduct()     
        {
            InitializeComponent();
        }

        // Click event method for btnOK
        // btnOK serves as btnSave to save new entered data by user
        private void btnOK_Click_1(object sender, EventArgs e) 
        {
            if (IsValidData()) // Check if entered data is validated
            { 
            if (addButtonStatus)
                myProduct = new Product();
            LoadData(); // After new data is validated then it can be loaded
            DialogResult = DialogResult.OK;
            }
        }

        // Click event method for btnCancel
        // btnCancel closes "addProduct" form and redirects user to "ProductMaintenance" form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Event method that will load+display "Add Product" or "Modify Product" form, based on btn clicked
        private void addProduct_Load(object sender, EventArgs e)
        {
            if (addButtonStatus) 
            {
                this.txtProductCode.ReadOnly = false;
                this.Text = "Add Product"; // form reads "Add Product" when btn_OK is clicked
            }
            else
            {
                this.txtProductCode.ReadOnly = true;
                this.Text = "Modify product"; // form reads "Modify Product" when btn_Modify is clicked
                DisplayData();
            }
        }

        // "LoadData" function
        // - Insert operation adds row to "ProductsMaintenance" table
        // - Update/Modify operation modifies selected row
        private void LoadData() 
        {
            myProduct.ProductCode = txtProductCode.Text;
            myProduct.Name = txtProductName.Text;
            myProduct.Version = Convert.ToDecimal(txtVersion.Text);
            myProduct.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
        }


        // "DisplayData" fuction
        // Data from "ProductsMaintenance" table is retrieved and displayed
                private void DisplayData()
        {
            txtProductCode.Text = myProduct.ProductCode;
            txtProductName.Text = myProduct.Name;
            txtVersion.Text = myProduct.Version.ToString();
            txtReleaseDate.Text = myProduct.ReleaseDate.ToString();
        }


        // "IsValidData" fuction (see "Validator.cs" file)
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtProductCode.Text, txtProductCode.Tag.ToString());
            errorMessage += Validator.IsMoreThanNumber(txtProductCode.Text, txtProductCode.Tag.ToString(),10);
            errorMessage += Validator.IsPresent(txtProductName.Text, txtProductName.Tag.ToString());
            errorMessage += Validator.IsMoreThanNumber(txtProductName.Text, txtProductName.Tag.ToString(), 50);
            errorMessage += Validator.IsPresent(txtVersion.Text, txtVersion.Tag.ToString());
            errorMessage += Validator.IsDecimal(txtVersion.Text, txtVersion.Tag.ToString());
            errorMessage += Validator.IsDecimal(txtVersion.Text, txtVersion.Tag.ToString());
            errorMessage += Validator.IsDecimcalLength(txtVersion.Text, txtVersion.Tag.ToString());
            errorMessage += Validator.IsPresent(txtReleaseDate.Text, txtReleaseDate.Tag.ToString());
            errorMessage += Validator.IsDate(txtReleaseDate.Text, txtReleaseDate.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
    }
    
    
}
