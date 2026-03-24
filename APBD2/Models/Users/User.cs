using APBD2.Enums;

namespace APBD2.Models.Users;

public abstract class User(string name, string surname, UserType type)
{
    private static int _idGenerator = 1;
    
    public int Id { get; } = _idGenerator++;
    public string Name { get; set; } = name;
    public string Surname { get; set; } = surname;
    public UserType Type { get; set; } = type;

    public abstract int GetMaxRentals();
}