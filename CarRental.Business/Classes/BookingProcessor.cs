using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;

namespace CarRental.Business.Classes;
public class BookingProcessor
{
    private readonly IData _db;
    //string _regNo = string.Empty;
    //string _make = string.Empty;
    //string _odometer = string.Empty;
    //string costKm = string.Empty;
    //VehicleTypes _vehicleType = VehicleTypes.Sedan;
    public Customer NewCustomer { get; set; } = new();
    public BookingProcessor(IData db) => _db = db;
    public IEnumerable<IPerson> GetCustomers() => _db.GetPersons();
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _db.GetVehicles(status);
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
                booking.ReturnVehicle(vehicle);
            }
        }

        return bookings;
    }
    public void HandleAddCustomer(string ssn, string lastName, string firstName)
    {
        _db.AddCustomer(new Customer(ssn, lastName, firstName));
        NewCustomer.Ssn = string.Empty;
        NewCustomer.LastName = string.Empty;
        NewCustomer.FirstName = string.Empty;
    }
}
