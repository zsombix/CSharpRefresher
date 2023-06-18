public class PatternMatching
{
    //Constant patterns of the form c (where c is a constant expression in C#),
    //which test that the input is equal to c
    
    //Type patterns of the form T x (where T is a type and x is an identifier),
    //which test that the input has type T, and if so, extracts the value of the input into a fresh variable x of type T
    
    //Var patterns of the form var x (where x is an identifier), 
    //which always match, and simply put the value of the input into a fresh variable x with the same type as the input.


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