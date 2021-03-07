using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_ProgrammingWindowsForm
{
    class Car
    {
        public int Id { get; set; }  //Id
        public string Brand { get; set; } //Marka
        public string Model { get; set; } //Model
        public string Color { get; set; } //Renk
        public string Date { get; set; } //Çıkış Tarihi
        public decimal Price { get; set; } //Fiyat
        public decimal Stok { get; set; } // Stok
        public bool Gear { get; set; } // Vites    true=otomatik , false = manuel
        public string Image { get; set; } //Araba Resmi

        public int GoId()
        {
            return Id;
        }
    }
}
