using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;
//using System.Net.Http.Json;

namespace CarRental.Data.Classes;
public class CollectionData : IData
{
    readonly List<IPerson> _persons = new List<IPerson>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IBooking> _bookings = new List<IBooking>();
    //HttpClient _httpClient;
    public CollectionData()
    {
        SeedData();
    }

    void SeedData()
    {
        // TODO: Implement this method.
        // Lägger till data till listorna
        _persons.Add(new Customer(12345, "Doe", "John"));
        _persons.Add(new Customer(98765, "Doe", "Jane"));
        List<IVehicle> seedVehicles = new()
        {
            new Car("ABC123", "Volvo", 10000, 1, VehicleTypes.Combi, 200, VehicleStatuses.Available),
            new Car("DEF456", "Saab", 20000, 1, VehicleTypes.Sedan, 100, VehicleStatuses.Available),
            new Car("GHI789", "Tesla", 1000, 3, VehicleTypes.Sedan, 100, VehicleStatuses.Booked),
            new Car("JKL012", "Jeep", 5000, 1.5, VehicleTypes.Van, 300, VehicleStatuses.Available),
            new Motorcycle("MNO234", "Yamaha", 30000, 0.5, VehicleTypes.Motorcycle, 50, VehicleStatuses.Available)
        };
        _vehicles.AddRange(seedVehicles);

        _bookings.Add(new Booking("GHI789", new Customer(12345, "Doe", "John"), 1000, default, new DateOnly(2023, 9, 20), default));
        _bookings.Add(new Booking("JKL012", new Customer(98765, "Doe", "Jane"), 5000, 6500, new DateOnly(2023, 9, 20), new DateOnly(2023, 9, 27)));
    }

    public IEnumerable<IBooking> GetBookings() => _bookings;

    public IEnumerable<IPerson> GetPersons() => _persons;

    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = 0)
    {
        // TODO: Implentera filtering baserad av fordonsstatus
        if (status == 0) { return _vehicles; }
        return _vehicles.Where(v => v.Status == status);
    }
}