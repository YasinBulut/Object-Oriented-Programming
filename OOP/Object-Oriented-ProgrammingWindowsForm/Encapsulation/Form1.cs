using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estate estate = new Estate() { City1 = txtsemt.Text, Room1 =Convert.ToInt32(txtodasayisi.Text) , Floor1 = Convert.ToInt32(txtkatno.Text), Domain1 = Convert.ToInt32(txtalan.Text) };
            ListViewItem kayit = new ListViewItem();
            kayit.Text = estate.City1;
            kayit.SubItems.Add(estate.Room1.ToString());
            kayit.SubItems.Add(estate.Floor1.ToString());
            kayit.SubItems.Add(estate.Domain1.ToString());
            listView1.Items.Add(kayit);

        }
    }
}
