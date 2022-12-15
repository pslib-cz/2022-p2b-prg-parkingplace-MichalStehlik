using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Bus : PersonalVehicle
    {
        public Bus(string id, Color color, int seats) : base(id, color, 5, seats)
        {
        }

        public override float CalculatePrice(int hoursSpent)
        {
            return 200 + base.CalculatePrice(hoursSpent);
        }
        public override string ToString()
        {
            return "Bus " + base.ToString() + " with " + Seats + " seats";
        }
    }
}
