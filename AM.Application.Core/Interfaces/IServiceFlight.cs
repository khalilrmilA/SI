using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Application.Core.Domain;

namespace AM.Application.Core.Interfaces
{
    internal interface IServiceFlight
    {
        public List<DateTime> GetFlightsDates(string destination);
        public void GetFlights(string filterType, string filterValue);
        public double DurationAverage(string destination);
        public int ProgrammedFlightNumber(DateTime startDate);
        public void ShowFlightDetails(Plane plane);
        public List<DateTime> GetFlightsDates(string destination);
    }
}
