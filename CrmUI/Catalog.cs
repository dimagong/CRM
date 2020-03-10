using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        CrmContext db;
        DbSet<T> set;
        public Catalog(DbSet<T> set, CrmContext db)
        {
            InitializeComponent();
            this.db = db;
            this.set = set;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //public Catalog()
        //{
            //
        //}
        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        // here add new positions ..............................................////
        private void button1_Click(object sender, EventArgs e)
        {
            if(typeof(T) == typeof(Product))
            {
                var form = new ProductAddForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Products.Add(form.Product);
                    db.SaveChanges();
                    MessageBox.Show("This item has been appended.");
                }
            }
            else if(typeof(T) == typeof(CategoryProducts))
            {
                var form = new CategoryProducAddForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.CategoryProductsAll.Add(form.CategoryProducts);
                    db.SaveChanges();
                    MessageBox.Show("This item has been appended.");
                }
            }
            else if (typeof(T) == typeof(CurrentRate))
            {

            }
            else if (typeof(T) == typeof(Werehouse))
            {
                var form = new WerehouseAddForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Werehouses.Add(form.Werehouse);
                    db.SaveChanges();
                    MessageBox.Show("This item has been appended.");
                }
            }

        }

        // this is change items and properties.........................../////
        private void button2_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Product))
            {
                var product = set.Find(id) as Product;
                if (product != null)
                {
                    var form = new ProductAddForm(product);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        product = form.Product;
                        db.SaveChanges();
                        //dataGridView.Update();
                        MessageBox.Show("This item has been modified.");
                    }
                }

            }
            else if (typeof(T) == typeof(CategoryProducts))
            {
                var category = set.Find(id) as CategoryProducts;
                if (category != null)
                {
                    var form = new CategoryProducAddForm(category);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        category = form.CategoryProducts;
                        db.SaveChanges();
                        dataGridView.Update();
                        MessageBox.Show("This item has been modified.");
                    }
                }


            }
            else if (typeof(T) == typeof(Werehouse))
            {
                var werehouse = set.Find(id) as Werehouse;
                if (werehouse != null)
                {
                    var form = new WerehouseAddForm(werehouse);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        werehouse = form.Werehouse;
                        db.SaveChanges();
                        dataGridView.Update();
                        MessageBox.Show("This item has been modified.");
                    }
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Product))
            {
                var product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
                
                MessageBox.Show("This item has been deleted.");
            }
            else if (typeof(T) == typeof(CategoryProducts))
            {
                var category = db.CategoryProductsAll.Find(id);
                db.CategoryProductsAll.Remove(category);
                db.SaveChanges();
                
                MessageBox.Show("This item has been deleted.");
            }
            else if (typeof(T) == typeof(Werehouse))
            {
                var werehouse = db.Werehouses.Find(id);
                db.Werehouses.Remove(werehouse);
                db.SaveChanges();
                MessageBox.Show("This item has been deleted.");
            }

        }
    }
}
