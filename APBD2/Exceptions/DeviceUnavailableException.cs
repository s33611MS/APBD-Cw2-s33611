namespace APBD2.Exceptions;

public class DeviceUnavailableException(string deviceName) : Exception($"Device: {deviceName} is currently unavailable.");