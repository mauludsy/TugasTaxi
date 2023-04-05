using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    class program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriveName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPasseger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadLine();
        }
    }
}