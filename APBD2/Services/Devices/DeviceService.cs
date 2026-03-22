using APBD2.Enums;
using APBD2.Exceptions;
using APBD2.Models.Devices;

namespace APBD2.Services.Devices;

public class DeviceService : IDeviceService
{
    private readonly List<Device> _devices = [];
    public void AddDevice(Device device)
    {
        _devices.Add(device);
    }

    public Device GetDeviceById(int deviceId)
    {
        return _devices.FirstOrDefault(room => room.Id == deviceId) ?? throw new DeviceNotFoundException(deviceId);
    }

    public List<Device> GetAll()
    {
        return _devices;
    }

    public List<Device> GetAvailable()
    {
        return _devices.Where(device => device.Status == DeviceStatus.Free).ToList();
    }

    public void SetFree(int deviceId)
    {
        GetDeviceById(deviceId).Status = DeviceStatus.Free;
    }

    public void SetRented(int deviceId)
    {
        GetDeviceById(deviceId).Status = DeviceStatus.Rented;
    }

    public void SetUnavailable(int deviceId)
    {
        GetDeviceById(deviceId).Status = DeviceStatus.Unavailable;
    }

    public string GenerateRapport()
    {
        string rapport = "Current list of devices: \n";

        foreach (var device in GetAll())
        {
            rapport += $"ID: {device.Id} Name: {device.Name} Brand: {device.Brand} Status: {device.Status} \n";
        }

        rapport += $"Number of devices available: {GetAll().Count(device => device.Status == DeviceStatus.Free)} \n";
        rapport += $"Devices out of use: {GetAll().Count(device => device.Status == DeviceStatus.Unavailable)} \n";
        
        return rapport;
    }
}