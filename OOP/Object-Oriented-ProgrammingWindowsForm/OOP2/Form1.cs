using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Human hmn = new Human() { Id = 1, FirsName = "YASİN", LastName = "BULUT", Age = 21, Size = 170,Gender=true,Salary=10000 };
            Personel personel = new Personel() { Id = 1, Departman = "DEVELOPER"};
            if (hmn.Gender == true)
            {
                lblcinsiyet.Text = "ERKEK";
            }
            else
            {
                lblcinsiyet.Text = "KADIN";
            }
            lblad.Text = hmn.FirsName;
            lblsoyad.Text = hmn.LastName;
            lblboy.Text = hmn.Size.ToString();
            lblyas.Text = hmn.Age.ToString();
            lbldepartman.Text = personel.Departman;
            lblmaas.Text = hmn.Salary.ToString();
        }
    }
}
