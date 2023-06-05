public class PatternMatching
{
    //Is expresion with patterns
    public static void PrintStars(object o)
    {
        if (o is null) return;     // constant pattern "null"
        if (!(o is int i)) return; // type pattern "int i"
        Console.WriteLine(new string('*', i));
    }

    //Switch statements with patterns:
    //https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#switch-statements-with-patterns
}