using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal abstract class Vehicle
    {
        public Vehicle(string id, Color color)
        {
            Id = id;
            Color = color;
        }

        public string Id { get; set; }
        public Color Color { get; set; }
        public override string ToString()
        {
            return Color.Name + " " + Id;
        }
    }
}
