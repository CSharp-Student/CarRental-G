using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;

namespace CarRental.Business.Classes;
public class BookingProcessor
{
    private readonly IData _db;

    public BookingProcessor(IData db) => _db = db;

    // TODO: Implement
    public IEnumerable<IPerson> GetCustomers() => _db.GetPersons();
    // TODO: Implement
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _db.GetVehicles(status);
    // TODO: Implement
    public IEnumerable<IBooking> GetBookings()
    {
        var bookings = _db.GetBookings();
        var vehicles = _db.GetVehicles();

        foreach (var booking in bookings)
        {
            var vehicle = vehicles.FirstOrDefault(v => v.RegNo == booking.RegNo);
            if (vehicle == null) break;

            if (vehicle.Status == VehicleStatuses.Booked)
            {
                booking.Status = "Open";
                booking.KmReturned = null;
                booking.Returned = null;
                booking.Cost = null;
            }
            else if (vehicle.Status == VehicleStatuses.Available)
            {
                booking.Status = "Closed";
                var days = booking.Returned?.DayNumber - booking.Rented.DayNumber;
                var kilometers = booking.KmReturned - booking.KmRented;
                booking.Cost = (kilometers * vehicle.CostPerKilometer) + (days * vehicle.CostPerDay);
            }
        }

        return bookings;
    }
}
