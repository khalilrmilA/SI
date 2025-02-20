using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Traveller:Passenger
    {
        public string HealhInformation { get; set; }
        public string Nationality { get; set; }

        public override void passengertype()
        {
            Console.WriteLine("je suis un passenger");
        }
    }
    
}
