// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Auto-Property initializers
// See https://learn.microsoft.com/en-us/archive/msdn-magazine/2014/october/csharp-the-new-and-improved-csharp-6-0#auto-property-initializers 
var propInit = new AutoPropertyInit();
Console.WriteLine($"Auto property value: {propInit.SomeField}");

// Null conditional operators
//https://learn.microsoft.com/en-us/archive/msdn-magazine/2014/october/csharp-the-new-and-improved-csharp-6-0#null-conditional-operator
var nullCondOps = new NullConditionalOps();
nullCondOps.CalculateValueForNulableValue();

// Nameof Expressions
// See https://learn.microsoft.com/en-us/archive/msdn-magazine/2014/october/csharp-the-new-and-improved-csharp-6-0#nameof-expressions
var nameofCheck = new NameOfExprs();
nameofCheck.ShowParamName("SomeValue");