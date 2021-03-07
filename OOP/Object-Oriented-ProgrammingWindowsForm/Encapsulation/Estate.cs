using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Estate
    {
        private string City;
        private int Room;
        private int Floor;
        private int Domain;

        public string City1 { get => City; set => City = value.ToUpper(); }
        public int Room1 { get => Room; set => Room = Math.Abs(value); }
        public int Floor1 { get => Floor; set => Floor = value; }
        public int Domain1 { get => Domain; set => Domain = Math.Abs(value); }
    }
}
