public class ThrowPerson
{
    public string Name { get; }
    public ThrowPerson(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));
    public string GetFirstName()
    {
        var parts = Name.Split(" ");
        return (parts.Length > 0) ? parts[0] : throw new InvalidOperationException("No name!");
    }
    public string GetLastName() => throw new NotImplementedException();
}