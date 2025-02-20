using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime FightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public Plane Plane { get; set; }
        public ICollection<Passenger> Passengers { get; set; }

        public override string ToString()
        {
            return ($"FlightDate: {FightDate}\nEstimatedDuration: {EstimatedDuration}\n");
        }
    }
}
