using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public enum PlaneType
    {
        Boeing,
        Airbus
    }
    public class Plane
    {
        

        public int PlaneId { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }
        public ICollection<Flight> Flights { get; set; }

       /* public Plane(int capacity, DateTime manufactureDate, PlaneType planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planeType;
        }*/

        public override string ToString()
        {
            return ($"\nPlaneType: {PlaneType}\nManufactureDate: {ManufactureDate}\nCapacity: {Capacity}");
        }
    }
}
