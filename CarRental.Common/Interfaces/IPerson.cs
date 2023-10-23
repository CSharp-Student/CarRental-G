namespace CarRental.Common.Interfaces;
public interface IPerson
{
    int Ssn { get; init; }
    string LastName { get; init; }
    string FirstName { get; init; }
}
