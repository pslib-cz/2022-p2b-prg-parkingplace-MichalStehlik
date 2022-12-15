using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal abstract class PersonalVehicle : Vehicle, IParkable
    {
        public PersonalVehicle(string id, Color color, int size, int seats) : base(id, color)
        {
            Size = size;
            Seats = seats;
        }

        public int Size { get; }
        public int Seats { get; }

        public virtual float CalculatePrice(int hoursSpent)
        {
            return Size * hoursSpent * Seats;
        }
    }
}
