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
    public partial class CategoryProducAddForm : Form
    {
        public CategoryProducts CategoryProducts { get; set; }
        public CategoryProducAddForm()
        {
            InitializeComponent();
        }

        public CategoryProducAddForm(CategoryProducts category) : this()
        {
            CategoryProducts = category;
            textBox2.Text = CategoryProducts.NameProducts;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (CategoryProducts != null)
            {
                CategoryProducts.NameProducts = textBox2.Text;
            }
            else
            {
                CategoryProducts = new CategoryProducts()
                {
                    NameProducts = textBox2.Text
                };

            }

            Close();

            //var c = CategoryProducts ?? new CategoryProducts();

            //c.NameProducts = textBox2.Text;

            //Close();
        }
    }
}
