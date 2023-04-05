using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    internal class Taxi
    {
        public string DriveName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPasseger { get; set; }

        public void TaxiInfo()
        {
            string duty = "No";

            if (OnDuty == true)
            {
                duty = "Yes";
            }

            Console.WriteLine("Driver Name\t\t: {0}", DriveName);
            Console.WriteLine("On Duty\t\t\t: {0}", duty);
            Console.WriteLine("Numbe Of Passenger\t: {0}\n", NumPasseger);

        }

        public void PickUpPassenger()
        {
            if (OnDuty == true && NumPasseger > 1)
            {
                Console.WriteLine("Jono sedang menjemput penumpang.");
            }
            else
            {
                Console.WriteLine("Jono sedang tidak bertugas.");
            }
        }

        public void DropOffPassenger()
        {
            if (OnDuty == true && NumPasseger > 0)
            {
                Console.WriteLine("Jono selesai mengantar penumpang.");
            }
            else
            {
                Console.WriteLine("Jono tidak sedang mengantar penumpang.");
            }
        }
    }
}
