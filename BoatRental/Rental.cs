using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoatRental
{
    class Rental
    {

        public String Id,Boat,Destination;
        public int Total;

        public Rental(String id, String boat, String destination, int total)
        {
            this.Id = id;
            this.Boat = boat;
            this.Destination = destination;
            this.Total = total;
       

        }
        public String toString()
        {
            return
                  ",Id='" + Id + '\'' +
                  ",Boat ='" +Boat + '\'' +
                  ",Destination='" + Destination + '\'' +
                  ",Total Rent ='" + Total +
                   '}';
        }
        public Rental(String id, String boat, String destination)
        {
            Boat = boat;
            Destination = destination;
            Id = id;

        }

    }
}
