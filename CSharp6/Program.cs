using static UsingStatic;

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

// Using static
// See https://medium.com/@aparnagadgil/c-6-0-new-features-that-you-must-know-a6b6f0960672
WriteHello();

// Dictionary initializers
// See https://medium.com/@aparnagadgil/c-6-0-new-features-that-you-must-know-a6b6f0960672
// I personally don't see a benefit, but maybe it's easyer to read by someone
DictionaryInit.Do();

// String interpolation
// See https://medium.com/@aparnagadgil/c-6-0-new-features-that-you-must-know-a6b6f0960672
// Cleaner string formating
StringInterpol.Do(); 

// Exception filtering
// See https://medium.com/@aparnagadgil/c-6-0-new-features-that-you-must-know-a6b6f0960672
ExceptionFiltering.Do();

// Await in catch and finally block
// See https://medium.com/@aparnagadgil/c-6-0-new-features-that-you-must-know-a6b6f0960672
AwaitInCatch.Do();

// Expression-bodied function members
// See https://medium.com/@aparnagadgil/c-6-0-new-features-that-you-must-know-a6b6f0960672
Console.WriteLine($"Sum 1 and 2 :  {LambdaFuncMembers.AddNumbers(1,2)}");