using APBD2.Enums;

namespace APBD2.Models.Devices;

public class Projector(string name, string brand, string resolution, ProjectorLightSource lightSource) : Device(name, brand)
{
    public string Resolution { get; set; } = resolution;
    public ProjectorLightSource LightSource { get; set; } =  lightSource;
}