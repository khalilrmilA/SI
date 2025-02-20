using AM.Application.Core.Domain;
using AM.Application.Core.Services;
// en utilisant const par default
/*Plane plane = new Plane();
plane.PlaneType=PlaneType.Airbus;
plane.Capacity = 200;
plane.ManufactureDate = DateTime.Now;
Console.WriteLine(plane);*/
// en utilsant l'instanciation intuitive
/*Plane plane = new Plane
{
    ManufactureDate = DateTime.Now,
    Capacity = 100,
    PlaneType = PlaneType.Boeing
};
Console.WriteLine(plane);*/
// en utilisant const parametré
/*Plane plane = new Plane(300, DateTime.Parse("2024-07-12"), PlaneType.Airbus);
Console.WriteLine(plane);
Passenger pa = new Passenger
{
    FirstName = "Test",
    LaststName = "Test",
    EmailAddress = "Test",
};
Console.WriteLine(pa);
if (pa.CheckProfile("med","ali") )
    Console.WriteLine("first ok");
Console.WriteLine("first not ok!");
if (pa.CheckProfile("Test", "Test","Test"))
    Console.WriteLine("second ok");
else Console.WriteLine("secnd not ok!");

Passenger passenger = new Passenger
{
    FirstName = "Test",
    LaststName = "Test",
    EmailAddress = "Test",
};
Traveller traveller = new Traveller
{
    FirstName = "Test1",
    LaststName = "Test1",
    EmailAddress = "Test1",
};
Staff staff = new Staff
{
    FirstName = "Test2",
    LaststName = "Test2",
    EmailAddress = "Test2",
};
passenger.passengertype();
traveller.passengertype();
staff.passengertype();
*/
ServiceFlight sf= new ServiceFlight();
sf.Flights=TestData.listFlights;