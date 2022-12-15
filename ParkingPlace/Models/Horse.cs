using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPlace.Models
{
    internal class Horse : IParkable
    {
        private string _id2;
        public string Id { get; private set; }
        /*
        public string Id2  // semik.Id2 = "Semik";
        {
            get
            {
                return _id2;
            }
            set
            {
                _id2 = value;
            }
        }
        */
        public int Size { get { return 1; } }
        /*
        string GetName()
        {
            return Id;
        }
        */

        public Horse(string id) // Horse semik = new Horse("Semik");
        {
            Id = id;
        }

        public Horse() // Horse semik = new Horse();
        {
            Id = "Semik";
        }
        public float CalculatePrice(int hoursSpent)
        {
            return hoursSpent * 1;
        }

        public override string ToString()
        {
            return "Horse " + Id;
        }
    }
}
