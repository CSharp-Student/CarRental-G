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
    public IEnumerable<IBooking> GetBookings() => _db.GetBookings();
}
