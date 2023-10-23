using CarRental.Common.Enums;

namespace CarRental.Common.Interfaces;
public interface IVehicle
{
    string RegNo { get; init; }
    string Make { get; init; }
    int Odometer { get; init; }
    decimal CostPerKilometer { get; init; }
    VehicleTypes VehicleType { get; init; }
    decimal CostPerDay { get; init; }
    VehicleStatuses Status { get; init; }
}