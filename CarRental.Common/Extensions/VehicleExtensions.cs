namespace CarRental.Common.Extensions;

public static class VehicleExtensions
{

    /// TODO: Implement extension method
    public static int Duration(this DateOnly startDate, DateOnly endDate) => 
        endDate.DayNumber == startDate.DayNumber ? 1 : endDate.DayNumber - startDate.DayNumber;

}
