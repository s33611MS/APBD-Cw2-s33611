namespace APBD2.Exceptions;

public class RentalNotFoundException(int rentalId) : Exception($"Rental with ID: {rentalId}  was not found.");