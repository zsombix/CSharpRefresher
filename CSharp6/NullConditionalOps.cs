public class Person
{
    public string Name {get;set;}
}

public class NullConditionalOps
{
    private string? SomeStringValue {get;set;}

    public void CalculateValueForNulableValue()
    {
        var person = new Person();
        var nameLength = person?.Name?.Length ?? 0;
        Console.WriteLine($"Person name length {nameLength}");
        person.Name = "John";
        nameLength = person?.Name?.Length ?? 0;
        Console.WriteLine($"Person name length {nameLength}");        
    }
}