using CrmBl.Model;
using System;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class Main : Form
    {
        CrmContext db;
        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var catalogProduct = new Catalog<Product>(db.Products);
            //catalogProduct.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products);
            catalogProduct.Show();

            //var catalogProduct = new Catalog();
        }

        private void werehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogWerehouse = new Catalog<Werehouse>(db.Werehouses);
            catalogWerehouse.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCategoryProducts = new Catalog<CategoryProducts>(db.CategoryProductsAll);
            catalogCategoryProducts.Show();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCurrentRate = new Catalog<CurrentRate>(db.CurrentRates);
            catalogCurrentRate.Show();
        }

        // this is addition position
        private void ProductAppendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductAddForm();
            if(form.ShowDialog() == DialogResult.OK) 
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
                
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void WerehouseAppendToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formWerehouse = new WerehouseAddForm();
            if (formWerehouse.ShowDialog() == DialogResult.OK)
            {
                db.Werehouses.Add(formWerehouse.Werehouse);
                db.SaveChanges();

            }
        }

        private void CategoryAppendToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formCategory = new CategoryProducAddForm();
            if (formCategory.ShowDialog() == DialogResult.OK)
            {
                db.CategoryProductsAll.Add(formCategory.CategoryProducts);
                db.SaveChanges();

            }
        }
    }
}
