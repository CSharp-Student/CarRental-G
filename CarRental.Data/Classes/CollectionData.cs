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
            new Car("ABC123", "Volvo", 10000, 1m, VehicleTypes.Combi, 200m, VehicleStatuses.Available),
            new Car("DEF456", "Saab", 20000, 1m, VehicleTypes.Sedan, 100m, VehicleStatuses.Available),
            new Car("GHI789", "Tesla", 1000, 3m, VehicleTypes.Sedan, 100m, VehicleStatuses.Booked),
            new Car("JKL012", "Jeep", 5000, 1.5m, VehicleTypes.Van, 300m, VehicleStatuses.Available),
            new Motorcycle("MNO234", "Yamaha", 30000, 0.5m, VehicleTypes.Motorcycle, 50m, VehicleStatuses.Available)
        };
        _vehicles.AddRange(seedVehicles);
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