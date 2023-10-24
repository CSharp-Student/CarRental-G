using CarRental.Common.Enums;

namespace CarRental.Common.Interfaces;
public interface IVehicle
{
    string RegNo { get; init; }
    string Make { get; init; }
    int Odometer { get; init; }
    double CostPerKilometer { get; init; }
    VehicleTypes VehicleType { get; init; }
    double CostPerDay { get; init; }
    VehicleStatuses Status { get; init; }
}