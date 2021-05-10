using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Maintenance_Lab3.Models;

namespace Project_Maintenance_Lab3
{
    public partial class frmNewProduct : Form
    {
        TechSupportContext context = new TechSupportContext(); //The DB context
        public Product currentProduct { get; set; }
        public bool Buttonadd { get; set; }

        public frmNewProduct()
        {
            InitializeComponent();
        }

        private Product addproduct = null;
        private void frmNewProduct_Load(object sender, EventArgs e)
        {
            if (Buttonadd == true)
            {
                ProductCodeTxt.Text = " ";
                NameTxt.Text = " ";
                VersionTxt.Text = " ";
                ReleaseDateTxt.Text = " ";
            }

            else
            {
                ProductCodeTxt.Enabled = false;
                ProductCodeTxt.Text = currentProduct.ProductCode;
                NameTxt.Text = currentProduct.Name;
                VersionTxt.Text = currentProduct.Version.ToString();
                ReleaseDateTxt.Text = currentProduct.ReleaseDate.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // lauching Add product form
            {
                addproduct = new Product();

                addproduct.ProductCode = ProductCodeTxt.Text;
                addproduct.Name = NameTxt.Text;
                addproduct.Version = Convert.ToDecimal(VersionTxt.Text);
                addproduct.ReleaseDate = Convert.ToDateTime(ReleaseDateTxt.Text);

                if (Buttonadd == true)
                {
                    context.Products.Add(addproduct);
                    MessageBox.Show("New Product added");
                }
                else
                {
                    context.Products.Update(addproduct);
                    MessageBox.Show("Product updated");
                }

                context.SaveChanges();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            if (NameTxt.Text.Length > 50)
                MessageBox.Show("Text should be less than 50 char");
                NameTxt.Focus();
        }

        private void VersionTxt_Validating(object sender, CancelEventArgs e)
        {
            if (NameTxt.Text == "")
                MessageBox.Show("Version is required field example 1.0");
            else if (!(Decimal.TryParse(VersionTxt.Text, out _)))
            {
                MessageBox.Show("Version value must be in decimal example 1.0");
                VersionTxt.Focus();
            }
        }

        private void ProductCodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ProductCodeTxt.Text.Length > 10)
                MessageBox.Show("Text should be less than 10 Char");

            else if (context.Products.Where(p => (p.ProductCode == ProductCodeTxt.Text)).Count() > 0)
                MessageBox.Show("Product code already exist");
        }

        private void ReleaseDateTxt_Validating(object sender, CancelEventArgs e)
        {
            if (!DateTime.TryParse(ReleaseDateTxt.Text, out _))
            {
                MessageBox.Show("Please enter text or numbers not special Char");
            }
        }
    }
}
