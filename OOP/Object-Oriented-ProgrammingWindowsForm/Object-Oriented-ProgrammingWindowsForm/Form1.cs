using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_ProgrammingWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car()
            {
                Id = 1,
                Brand = "Hyundai",
                Model = "Getz",
                Color = "Beyaz",
                Date = "2013",
                Price = 45000,
                Stok = 4,
                Gear = true,
            };


            int id = car.GoId();
            if (id.ToString() == textBox1.Text)
            {
                lblmarka.Text = car.Brand.ToString();
                lblmodel.Text = car.Model.ToString();
                lblrenk.Text = car.Color.ToString();
                lbltarih.Text = car.Date.ToString();
                lblfiyat.Text = car.Price.ToString();
                lblstok.Text = car.Stok.ToString();
                lblvites.Text = car.Gear.ToString();
            }
            else
            {
                MessageBox.Show("Araç Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
