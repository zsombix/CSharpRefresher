// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Out variables
// https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#out-variables
OutVariables.PrintNumbers(39);

// Pattern matching
//https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#pattern-matching
PatternMatching.PrintStars(null);
PatternMatching.PrintStars("null");
PatternMatching.PrintStars(5);

// tuple types and tuple literals
// https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#tuples
var name = Tuples.GetName();
Console.WriteLine($"{name.first} {name.last}");

// Deconstruction
// https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#deconstruction
(var firstName, var lastName) = Tuples.GetName();
Console.WriteLine($"{firstName} {lastName}");

// Local functions
// https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#local-functions
var fib = LocalFunctions.Fibonacci(2);
Console.WriteLine($"{fib}");

// Literal improvements
// https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#literal-improvements
var d = 123_456;
Console.WriteLine($"{d}");

// Refs returns and locals
// https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#ref-returns-and-locals
int[] array = { 1, 15, -39, 0, 7, 14, -12 };
ref int place = ref RefReturns.Find(7, array);
place = 9;
Console.WriteLine(array[4]);

// Generalized async return types
// https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#generalized-async-return-types

// More expression bodied members
// https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#more-expression-bodied-members
var person = new Person("Test");
Console.WriteLine($"{person.Name}");

// Throw expressions
// https://devblogs.microsoft.com/dotnet/new-features-in-c-7-0/#throw-expressions
try{

    var throwPerson = new ThrowPerson(null);
}catch(Exception ex)
{
    Console.WriteLine(ex);
}