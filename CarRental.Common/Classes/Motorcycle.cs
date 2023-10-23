using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;
public class Motorcycle : IVehicle
{
    public string RegNo { get; init; }
    public string Make { get; init; }
    public int Odometer { get; init; }
    public decimal CostPerKilometer { get; init; }
    public VehicleTypes VehicleType { get; init; }
    public decimal CostPerDay { get; init; }
    public VehicleStatuses Status { get; init; }

    public Motorcycle(string regNo, string make, int odometer, decimal costPerKilometer, VehicleTypes vehicleType, decimal costPerDay, VehicleStatuses status)
    {
        RegNo = regNo;
        Make = make;
        Odometer = odometer;
        CostPerKilometer = costPerKilometer;
        VehicleType = vehicleType;
        CostPerDay = costPerDay;
        Status = status;
    }
}