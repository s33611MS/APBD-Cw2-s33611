namespace APBD2.Exceptions;

public class TooManyRentalsException(int userId) : Exception($"User: {userId} has too many devices rented.");