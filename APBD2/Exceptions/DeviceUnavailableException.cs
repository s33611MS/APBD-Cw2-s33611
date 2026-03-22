namespace APBD2.Exceptions;

public class DeviceUnavailableException(int deviceId) : Exception($"Device: {deviceId} is currently unavailable.");