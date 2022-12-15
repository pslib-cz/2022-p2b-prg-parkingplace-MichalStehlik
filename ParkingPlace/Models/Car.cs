using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Car : PersonalVehicle
    {
        public Car(string id, Color color, int seats) : base(id, color, 1, seats)
        {
        }

        public override float CalculatePrice(int hoursSpent)
        {
            return 15 * hoursSpent;
        }
        public override string ToString()
        {
            return "Car " + base.ToString();
        }
    }
}
