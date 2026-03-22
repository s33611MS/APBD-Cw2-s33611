namespace APBD2.Exceptions;

public class TooManyRentalsException(string name, string surname) : Exception($"User: {name} {surname} has too many devices rented.");