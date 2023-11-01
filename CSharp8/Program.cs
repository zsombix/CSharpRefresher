// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-80
// https://medium.com/globant/c-8-new-features-17bdf09658d3

// Default Interface methods
IWriteLine writeLiner = new WriteLiner();
writeLiner.WriteLine();

// Nullable reference type
// There is a warning to not make this mistake
// Uncomment and running this causes a runtime error
// NullRefereceType.ReferencingNullableString();

// Pattern matching enhancements
var patterMatch = new PatternMatching();
patterMatch.Check();

// Ranges
Ranges.RunExamples();

// Interpolated verbatim strings
var filename = @"alma\string";
Console.WriteLine(@$"c:\temp\{filename}");
Console.WriteLine($@"c:\temp\{filename}");

// Using declarations and disposable ref structs
Usings.RunStatement();

//readonly instance members
var readonlyCheck = new ReadOnlyInstanceMemebers();
readonlyCheck.SetX(1);
readonlyCheck.IncreaseX();