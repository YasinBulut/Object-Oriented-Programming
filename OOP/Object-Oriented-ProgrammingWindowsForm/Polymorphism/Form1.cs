using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            Bread bread = new Bread("EKMEK",1,"KEPEKLİ",120);
            basket.ProdutAdd(bread);
            MessageBox.Show(basket.TotalPrice().ToString());
        }
    }
}
