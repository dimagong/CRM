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
    public partial class WerehouseAddForm : Form
    {
        public Werehouse Werehouse { set; get; }
        public WerehouseAddForm()
        {
            InitializeComponent();
        }

        private void WerehouseAddForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Werehouse = new Werehouse() 
            {
                NameWerehouse = textBox1.Text
            };
            Close();
        }
    }
}
