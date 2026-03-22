namespace APBD2.Models.Devices;

public class Laptop(string name, string brand, string operatingSystem, bool hasCamera) : Device(name, brand)
{
    public string OperatingSystem { get; set; } = operatingSystem;
    public bool HasCamera { get; set; } =  hasCamera;
}