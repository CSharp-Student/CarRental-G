using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;
public class Car : IVehicle
{
    public string RegNo { get; init; }
    public string Make { get; init; }
    public int Odometer { get; init; }
    public double CostPerKilometer { get; init; }
    public VehicleTypes VehicleType { get; init; }
    public double CostPerDay { get; init; }
    public VehicleStatuses Status { get; init; }

    public Car(string regNo, string make, int odometer, double costPerKilometer, VehicleTypes vehicleType, double costPerDay, VehicleStatuses status)
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
