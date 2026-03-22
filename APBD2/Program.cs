using APBD2.Models.Devices;
using APBD2.Models.Users;
using APBD2.Services.Devices;
using APBD2.Services.Rentals;
using APBD2.Enums;

var student = new Student("Jan", "Kowal");
var employee = new Employee("Anna", "Nowak");

var laptop = new Laptop("ThinkPad", "Lenovo", "Linux", true);
var projector = new Projector("R1", "ZENWIRE", "HD", ProjectorLightSource.Laser);
var camera1 = new Camera("Ixus", "Canon", "DSLR", 18);
var camera2 = new Camera("Alpha A7 III", "Sony", "SLR", 18);


IDeviceService deviceService = new DeviceService();
IRentalService rentalService = new RentalService();

deviceService.AddDevice(laptop);
deviceService.AddDevice(projector);
deviceService.AddDevice(camera1);
deviceService.AddDevice(camera2);

deviceService.SetUnavailable(camera2.Id);

rentalService.CreateRental(student, laptop, new DateTime(2026, 4, 1), 10);
rentalService.CreateRental(student, camera1, new DateTime(2026, 3, 1), 20);

try
{
    rentalService.CreateRental(student, projector, new DateTime(2026, 5, 15), 30);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    rentalService.CreateRental(employee, camera2, new DateTime(2026, 5, 15), 30);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

rentalService.ReturnRental(1);

try
{
    rentalService.ReturnRental(2);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine(deviceService.GenerateRapport());