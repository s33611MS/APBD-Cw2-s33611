using APBD2.Models.Devices;
using APBD2.Models.Rental;
using APBD2.Models.Users;

namespace APBD2.Services.Rentals;

public interface IRentalService
{
    public void CreateRental(User user, Device device, DateTime to, int penalty);
    public void ReturnRental(int rentalId);
    public List<Rental> GetUserRentals(User user);
    public List<Rental> GetExpiredRentals();
}