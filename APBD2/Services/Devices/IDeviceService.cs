using APBD2.Models.Devices;

namespace APBD2.Services.Devices;

public interface IDeviceService
{
    public void AddDevice(Device device);
    public Device GetDeviceById(int deviceId);
    public List<Device> GetAll();
    public List<Device> GetAvailable();
    public void SetFree(int deviceId);
    public void SetRented(int deviceId);
    public void SetUnavailable(int deviceId);
    public string GenerateRapport();
}