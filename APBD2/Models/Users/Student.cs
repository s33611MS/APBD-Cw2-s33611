namespace APBD2.Models.Users;

public class Student(string name, string surname) : User(name, surname, "Student")
{
    public override int GetMaxRented() => 2;
}