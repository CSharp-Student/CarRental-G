namespace CarRental.Common.Interfaces;
public interface IBooking
{
    string RegNo { get; init; }
    IPerson? Customer { get; init; }
    double KmRented { get; init; }
    double? KmReturned { get; set; }
    DateOnly Rented { get; init; }
    DateOnly? Returned { get; set; }
    double? Cost { get; set; }
    string Status { get; set; }
    int Id { get; set; }
}
