using ParkingPlace.Models;
using System;
using System.Collections.Generic;
using System.Drawing;

Console.WriteLine("Naše parkoviště");
Parking parking = new Parking(7);
/*
Car skodovka = new Car("LBT 12 12", Color.Azure, 4);
Car bavorak = new Car("LBT 13 13", Color.Purple, 4);
Car peugeot = new Car("LBT 11 11", Color.Green, 4);
Bus scania = new Bus("LBT 14 14", Color.Orange, 45);
Tank leopard = new Tank("25", Color.Green);
Horse semik = new Horse("Šemík");

List<object> incoming = new List<object> { skodovka, scania, leopard, semik, peugeot };

foreach (var o in incoming)
{
    if (parking.TryAdd(o))
    {
        Console.WriteLine(o + " was parked.");
    }
    else
    {
        Console.WriteLine(o + " was not parked. (This thing cannot be parked here.)");
    }
}

Console.WriteLine("--- Content of Parking ---");
foreach (IParkable parkableThing in parking.ParkingSpaces)
{
    Console.WriteLine(parkableThing);
}

Console.WriteLine("--- Departures ---");
List<IParkable> leaving = new List<IParkable> { bavorak, scania, semik, peugeot };
foreach (var l in leaving)
{
    float price = 0;
    if (parking.Remove(l, 3, out price)) 
    {
        Console.WriteLine(l + " left. We got sweet " + price + ".");
    }
    else
    {
        Console.WriteLine(l + " has failed to leave. (It was probably not even parked inside.)");
    }
}
Console.WriteLine("--- Result ---");
Console.WriteLine("We earned " + parking.Revenue + " total");
*/