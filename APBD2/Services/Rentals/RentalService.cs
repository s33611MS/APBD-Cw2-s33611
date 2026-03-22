using APBD2.Enums;
using APBD2.Exceptions;
using APBD2.Models.Devices;
using APBD2.Models.Rental;
using APBD2.Models.Users;

namespace APBD2.Services.Rentals;

public class RentalService : IRentalService
{
    private readonly List<Rental> _rentals = [];

    public void CreateRental(User user, Device device, DateTime to, int penalty)
    {
        if (device.Status != DeviceStatus.Free)
        {
            throw new DeviceUnavailableException(device.Name);
        }

        int currentRentals = _rentals.Count(rental => !rental.Returned && rental.User == user);

        if (currentRentals >= user.GetMaxRentals())
        {
            throw new TooManyRentalsException(user.Name, user.Surname);
        }
        
        var newRental = new Rental(device, user, to, penalty);
        newRental.Rent();
        _rentals.Add(newRental);
    }

    public void ReturnRental(int rentalId)
    {
        var rental = _rentals.FirstOrDefault(rental => rental.Id == rentalId);
        
        if (rental == null)
            throw new RentalNotFoundException(rentalId);
        
        rental.Return();
        
        if (DateTime.Today.CompareTo(rental.To) > 0)
        {
            rental.NotOnTime();
            throw new DeviceReturnedLateException(rental.User.Name, rental.User.Surname, rental.Penalty);
        }
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