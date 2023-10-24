using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;
public class Booking : IBooking
{
    public string RegNo { get; init; }
    public Customer Customer { get; init; }
    public double KmRented { get; init; }
    public double? KmReturned { get; set; }
    public DateOnly Rented { get; init; }
    public DateOnly? Returned { get; set; }
    public double? Cost { get; set; } = 0;
    public string Status { get; set; } = string.Empty;

    public Booking(string regNo, Customer customer, double kmRented, double kmReturned = 0, DateOnly rented = default, DateOnly returned = default)
    {
        RegNo = regNo;
        Customer = customer;
        KmRented = kmRented;
        KmReturned = kmReturned;
        Rented = rented;
        Returned = returned;
    }

    public void ReturnVehicle(IVehicle vehicle)
    {
        var days = Returned?.DayNumber - Rented.DayNumber;
        var kilometers = KmReturned - KmRented;
        Cost = (kilometers * vehicle.CostPerKilometer) + (days * vehicle.CostPerDay);
    }
}
