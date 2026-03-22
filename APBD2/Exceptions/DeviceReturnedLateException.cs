namespace APBD2.Exceptions;

public class DeviceReturnedLateException(string name, string surname, int penalty) :  Exception($"User: {name} {surname} needs to pay {penalty}$ penalty");