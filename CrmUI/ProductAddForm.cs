using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class ProductAddForm : Form
    {
        public Product Product { get; set; }

        public ProductAddForm()
        {
            InitializeComponent();
        }

        public ProductAddForm(Product product) :this()
        {
            Product = product;
            textBox1.Text = Product.NameProduct;
            numericUpDown1.Value = Product.PriceBase;
            numericUpDown2.Value = Product.PriceReal;
            textBox2.Text = Product.Category;
            numericUpDown3.Value = Product.Currency;
            numericUpDown4.Value = Product.BarCodeItem;
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Product != null)
            {
                Product.NameProduct = textBox1.Text;
                Product.PriceBase = numericUpDown1.Value;
                Product.PriceReal = numericUpDown2.Value;
                Product.Category = textBox2.Text;
                Product.Currency = numericUpDown3.Value;
                Product.BarCodeItem = Convert.ToInt32(numericUpDown4.Value);
                

            }
            else
            {
                Product = new Product()
                {
                    NameProduct = textBox1.Text,
                    PriceBase = numericUpDown1.Value,
                    PriceReal = numericUpDown2.Value,
                    Category = textBox2.Text,
                    Currency = numericUpDown3.Value,
                    BarCodeItem = Convert.ToInt32(numericUpDown4.Value)
                };

            }

            Close();



            ///////
            //var p = Product ?? new Product();
            //    p.NameProduct = textBox1.Text;
            //p.PriceBase = numericUpDown1.Value;
            //p.PriceReal = numericUpDown2.Value;
            //p.Category = textBox2.Text;
            //p.Currency = numericUpDown3.Value;
            //p.BarCodeItem = Convert.ToInt32(numericUpDown4.Value);

            //Close();
        }
    }
}
