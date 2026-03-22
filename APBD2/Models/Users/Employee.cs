namespace APBD2.Models.Users;

public class Employee(string name, string surname) : User(name, surname, "Employee")
{
    public override int GetMaxRented() => 5;
}