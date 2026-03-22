using APBD2.Enums;
using APBD2.Models.Devices;
using APBD2.Models.Users;

namespace APBD2.Models.Rental;

public class Rental(Device device, User user, DateTime to, int penalty)
{
    private static int _nextId = 1;
    
    public int Id { get; set; } = _nextId++;
    public Device Device { get; set; } = device;
    public User User { get; set; } = user;
    public DateTime To { get; set; } = to;
    public int Penalty { get; set; } = penalty;
    public bool Returned { get; private set; }
    public bool ReturnedOnTime { get; private set; } = true;
    
    public void Rent() => Device.Status = DeviceStatus.Rented;

    public void Return()
    {
        Returned = true;
        Device.Status = DeviceStatus.Free;
    }

    public void NotOnTime() => ReturnedOnTime = false;
    
}