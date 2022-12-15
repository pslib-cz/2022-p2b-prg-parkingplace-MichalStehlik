using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingPlace.Models
{
    public interface IParkable
    {
        string Id { get; }
        int Size { get; }
        float CalculatePrice(int HoursSpent);
    }
}
