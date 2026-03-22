namespace APBD2.Exceptions;

public class DeviceNotFoundException(int rentalId) : Exception($"Device with ID: {rentalId}  was not found.");