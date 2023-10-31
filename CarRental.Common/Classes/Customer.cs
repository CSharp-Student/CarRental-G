using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;
public class Customer : IPerson
{
    public string Ssn { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }

    public Customer(string ssn = "", string lName = "", string fName = "") => (Ssn, LastName, FirstName) = (ssn, lName, fName);
}
