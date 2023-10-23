using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;
public class Customer : IPerson
{
    public int Ssn { get; init; }
    public string LastName { get; init; }
    public string FirstName { get; init; }

    public Customer(int ssn, string lName, string fName) => (Ssn, LastName, FirstName) = (ssn, lName, fName);
}
