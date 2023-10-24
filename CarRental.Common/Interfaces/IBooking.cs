using CarRental.Common.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Interfaces;
public interface IBooking
{
    string RegNo { get; init; }
    Customer Customer { get; init; }
    double KmRented { get; init; }
    double? KmReturned { get; set; }
    DateOnly Rented { get; init; }
    DateOnly? Returned { get; set; }
    double? Cost { get; set; }
    string Status { get; set; }

    void ReturnVehicle(IVehicle vehicle);
}
