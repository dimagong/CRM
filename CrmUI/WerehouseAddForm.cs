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
        public WerehouseAddForm(Werehouse werehouse) : this()
        {
            Werehouse = werehouse;
            textBox1.Text = Werehouse.NameWerehouse;  //Werehouse.NameWerehouse
            textBox2.Text = Werehouse.AddressWerehouse;  //"Hello";
        }

        private void WerehouseAddForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Werehouse != null)
            {
                //var w = Werehouse;
                //w.NameWerehouse = textBox1.Text;
                Werehouse.NameWerehouse = textBox1.Text;
                Werehouse.AddressWerehouse = textBox2.Text;

            }
            else
            {
                Werehouse = new Werehouse()
                {
                    NameWerehouse = textBox1.Text,
                    AddressWerehouse = textBox2.Text
                };

            }

            Close();


            //var w = Werehouse ?? new Werehouse();
            //w.NameWerehouse = textBox1.Text;
            //w.AddressWerehouse = textBox2.Text;
            //Close();

            //Werehouse = new Werehouse()
            //{
            //    NameWerehouse = textBox1.Text,
            //    AddressWerehouse = textBox2.Text
            //};

            //Close();



        }
    }
}
