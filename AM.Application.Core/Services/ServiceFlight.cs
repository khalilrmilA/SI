using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;

namespace AM.Application.Core.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination.Equals(filterValue))
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }
                    break;
                case "FlightDate":
                    DateTime.TryParse(filterValue, out DateTime date);
                    foreach (var flight in Flights)
                    {
                        if (flight.FightDate.Equals(date))
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }
                    break;
                case "EffectiveArrival":
                    DateTime.TryParse(filterValue, out DateTime date1);
                    foreach (var flight in Flights)
                    {
                        if (flight.FightDate.Equals(date1))
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }
                    break;  
                default:
                    Console.WriteLine("Invalid filter type");
                    break;
            }

        }
        // experion normal 
        public List<DateTime> GetFlightsDates(string destination)
        {
            return (from flight in Flights
                    where flight.Destination.Equals(destination)
                    select flight.FightDate).ToList();
        }
        //exprestion lamda 
        /*public List<DateTime> GetFlightsDates(string destination)
        {
            return Flights.Where(f => f.Destination.Equals(destination))
                          .Select(f => f.FightDate)
                          .ToList();
        }*/

        public void ShowFlightDetails(Plane plane)
        {
            var flightDetails = Flights.Where(f => f.Plane.PlaneId == plane.PlaneId)
                                       .Select(f => new { f.FightDate, f.Destination });

            foreach (var detail in flightDetails)
            {
                Console.WriteLine($"Date: {detail.FightDate}, Destination: {detail.Destination}");
            }
        }

        public void ShowFlightDetails(Plane plane)
        {
            Flights.Where(f => f.Plane.PlaneId == plane.PlaneId)
               .Select(f => new { f.FightDate, f.Destination })
               .ToList()
               .ForEach(detail => Console.WriteLine($"Date: {detail.FightDate}, Destination: {detail.Destination}"));
        }
        

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            DateTime endDate = startDate.AddDays(7);
            return Flights.Count(f => f.FightDate >= startDate && f.FightDate < endDate);
        }

       /* public List<DateTime> GetFlightsDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            foreach (var flight in Flights)
            {
                if (flight.Destination.Equals(destination))
                {
                    dates.Add(flight.FightDate);
                }
            }
            for (int i=0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination.Equals(destination))
                {
                    dates.Add(Flights[i].FightDate);
                }
            }
            return dates;
        }*/



    }
}
