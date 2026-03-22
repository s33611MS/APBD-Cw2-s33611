using APBD2.Models.Devices;
using APBD2.Models.Rental;
using APBD2.Models.Users;

namespace APBD2.Services.Rentals;

public class RentalService : IRentalService
{
    private readonly List<Rental> _rentals = [];

    public void CreateRental(User user, Device device, DateTime to, int penalty)
    {
        int currentUserRentals = _rentals.Count(rental => rental.User == user && !rental.Returned);
        
        var newRental = new Rental(device, user, to, penalty);
        _rentals.Add(newRental);
    }

    public int ReturnRental(int rentalId)
    {
        var rental = _rentals.FirstOrDefault(rental => rental.Id == rentalId);
        rental.Return();
        return DateTime.Today.CompareTo(rental.To) * rental.Penalty;
    }

    public List<Rental> GetUserRentals(User user)
    {
        return _rentals.Where(rental => rental.User == user).ToList();

    }

    public List<Rental> GetExpiredRentals()
    {
        return _rentals.Where(rental => rental.ReturnedOnTime == false).ToList();
    }
}