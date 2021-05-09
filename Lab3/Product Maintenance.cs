
//Lab3 description
// Create Windows Forms application called "ProductMaintenance" that lets the user maintain products.
// The application consists of two forms "ProductMaintenance" and "Add+Modify Products"
// This file present the code wirtten for "ProductMaintenance" form
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
using Microsoft.EntityFrameworkCore;


namespace Lab3
{
    // Entity Framework set up
    public partial class ProductMaintenance : Form // Declaration of Class for "ProductMaintenance" form
    {
        TechSupportContext context;
        Product myProduct;
        public bool addButtonStatus = false;
        public ProductMaintenance()
        {
            InitializeComponent();
        }


        // Load operation 
        private void ProductMaintenance_Load(object sender, EventArgs e)
        {
            
            LoadGridView();
        }

        // "LoadGridView" function will load the grid
        // Connection string to SQL Database "TechSupport"
        private void LoadGridView()
        {
            context = new TechSupportContext(ConfigurationManager.ConnectionStrings["TechSupport"].
                        ConnectionString);
            GridViewProduct.AutoGenerateColumns = false;
            GridViewProduct.DataSource = context.Products.ToList();
        }


        // A method/operation that adds, saves, and loads a new row with data entered by user
        private void Add_Click(object sender, EventArgs e)
        {
            myProduct = new Product(); // defining new Product
            addProduct addProduct = new addProduct() // Open addProduct form
            {
                addButtonStatus = true, // defining Add buton's status
                myProduct = myProduct

            };
            var r = addProduct.ShowDialog(); // Variable that displays ShowDialog
            if (r == DialogResult.OK) // Checking dialog result
            {
                myProduct = addProduct.myProduct;
                context.Products.Add(myProduct);
                context.SaveChanges();
                LoadGridView();
            }
        }

        // Select method
        // SelectedRows operation selects the row to be modified
        private void GridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (GridViewProduct.SelectedRows.Count > 0) // Check if there is at least 1 selectedRow
            {
                myProduct = (Product)GridViewProduct.SelectedRows[0].DataBoundItem;
            }
        }

        // Delete method/operation removes, saves, and loads selected row
        private void Remove_Click(object sender, EventArgs e)
        {
            context.Products.Remove(myProduct);
            context.SaveChanges();
            LoadGridView();
        }

        // Update/Modify method/operation modifies, saves, and loads selected row
        private void Modify_Click(object sender, EventArgs e)
        {
            addProduct addProduct = new addProduct();
            addProduct.myProduct = myProduct;
            var r = addProduct.ShowDialog(); // variable that displays ShowDialog
            if (r == DialogResult.OK)
            {
                context.SaveChanges();
                LoadGridView();
            }
        }

        // Exit button terminates the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
