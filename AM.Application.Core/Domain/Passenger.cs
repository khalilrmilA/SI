using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LaststName { get; set; }

        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public int TelNUmber { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return ($"FirstName: {FirstName}\nLastName: {LaststName}\nBirthDate: {BirthDate}");
        }
        public bool CheckProfile(string nom,string prenom)
        {
            return nom==LaststName && prenom==FirstName;
        }
        public bool CheckProfile(string nom, string prenom,string email)
        {
            return nom==LaststName && prenom==LaststName && email== EmailAddress;
        }
        public virtual void passengertype()
        {
            Console.WriteLine("i am a passenger"); 
        }
               
    }
}
