public record Person(string FirstName, string LastName);

public record Person2()
{
    public required string Name { get; init; }
}

public record Person3(string FirstName, string LastName, string[] PhoneNumbers);

public record Teacher(string FirstName, string LastName, int Grade)
    : Person(FirstName, LastName);