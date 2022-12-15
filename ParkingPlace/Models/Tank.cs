using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Tank : Vehicle
    {
        public Tank(string id, Color color) : base(id, color)
        {
        }

        public int Size { get; }
        public float CalculatePrice(int hoursSpent)
        {
            return 10000;
        }

        public override string ToString()
        {
            return "Tank " + Id;
        }
    }
}
