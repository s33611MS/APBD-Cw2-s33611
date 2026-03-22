namespace APBD2.Models.Devices;

public class Camera(string name, string brand, string type, int focalLength) : Device(name, brand)
{
    public string Type { get; set; } = type;
    public int FocalLength { get; set; } = focalLength;
}