namespace APBD2.Models.Users;

public abstract class User(string name, string surname, string type)
{
    private static int _idGenerator = 1;
    
    public int Id { get; } = _idGenerator++;
    public string Name { get; set; } = name;
    public string Surname { get; set; } = surname;
    public string Type { get; set; } = type;

    public abstract int GetMaxRentals();
}