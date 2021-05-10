using Project_Maintenance_Lab3.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Project_Maintenance_Lab3
{
    public partial class Form1 : Form
    {
        TechSupportContext context;
        Product currentProduct;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            context = new TechSupportContext();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = context.Products.ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewProduct AddProduct = new frmNewProduct();
            AddProduct.Buttonadd = true;
            AddProduct.ShowDialog();
            Display();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            context.Products.Remove(currentProduct);
            context.SaveChanges();
            Display();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                currentProduct = (Product)dataGridView.SelectedRows[0].DataBoundItem;
            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            frmNewProduct modifyProduct = new frmNewProduct();
            modifyProduct.currentProduct = currentProduct;
            modifyProduct.ShowDialog();
            context.SaveChanges();
            Display();
        }
    }
}
