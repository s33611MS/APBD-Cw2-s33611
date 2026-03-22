using APBD2.Enums;

namespace APBD2.Models.Devices;

public abstract class Device(string name, string brand)
{
    private static int _idGenerator = 1;
    
    public int Id { get; } = _idGenerator++;
    public string Name { get; set; } = name;
    public string Brand { get; set; } = brand;
    public DeviceStatus Status { get; set; } = DeviceStatus.Free;
}