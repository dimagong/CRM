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

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryProducts = new CategoryProducts()
            {
                CategoryProductsId = Convert.ToInt32(textBox1.Text),
                NameProducts = textBox2.Text

            };
            Close();
        }
    }
}
