using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_ClassRelationships
{
    class House
    {
        public string Address { get; set; }
        public double SqM { get; set; }

        public List<Room> Rooms { get; set; } // this is association 

    }

    class Room
    {
        public string Type { get; set; }
        public double SqM { get; set; }

        public bool Ensuite { get; set; }
    }
}
