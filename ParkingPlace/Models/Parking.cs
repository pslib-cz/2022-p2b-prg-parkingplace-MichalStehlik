using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingPlace.Models
{
    class Parking
    {
        public List<IParkable> ParkingSpaces { get; }
        public int Total { get; } // Celkový počet parkovacích míst
        public int Occupied { get; private set; } // Počet obsazených míst
        public int Free { get { return (Total - Occupied); } } // Vypočítaný počet volných parkovacích míst
        public float Revenue { get; private set; } // Celkový příjem z parkovného

        public Parking(int total)
        {
            ParkingSpaces = new List<IParkable>();
            Total = total;
            Occupied = 0;
        }

        /// <summary>
        /// Přidá na parkoviště novou věc splňující rozhraní IParkable
        /// </summary>
        /// <param name="client">věc, kterou parkujeme</param>
        /// <returns>výsledek operace</returns>
        public bool Add(IParkable client)
        {
            if (client.Size <= Free)
            {
                ParkingSpaces.Add(client);
                Occupied += client.Size;
                return true;
            }
            else
            {
                return false;
                //throw new NotEnoughSpaceException("There is not enough space.");
            }
        }

        /// <summary>
        /// Přidá (pokud to jde) na parkoviště libovolný objekt.
        /// </summary>
        /// <param name="client">věc, kterou parkujeme</param>
        /// <returns>výsledek operace</returns>
        public bool TryAdd(object client)
        {
            if (client is IParkable)
            {
                return this.Add(client as IParkable);
            }
            else
            {
                //throw new NotSuitableException("This thing cannot be parked here.");
                return false;
            }
        }

        /// <summary>
        /// Odstraní z parkoviště určenou věc
        /// </summary>
        /// <param name="client">co se má odparkovat</param>
        /// <param name="hoursSpent">po kolika hodinách stání</param>
        /// <param name="price">výsledná cena</param>
        /// <returns>výsledek operace</returns>
        public bool Remove(IParkable client, int hoursSpent, out float price)
        {
            if (ParkingSpaces.Remove(client) && hoursSpent > 0)
            {
                price = client.CalculatePrice(hoursSpent);
                Revenue += price;
                Occupied -= client.Size;
                return true;
            }
            else
            {
                price = 0;
                return false;
                //throw new NotContentException("This thing was not parked here.");
            }
        }
    }
}
