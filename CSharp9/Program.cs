// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9
// https://devblogs.microsoft.com/dotnet/c-9-0-on-the-record/
// https://pvs-studio.com/en/blog/posts/csharp/0860/

// Record types
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#record-types

var person = new Person("aaa","bbb");
var person2 = new Person2()
{
    Name = "NameName"
};
Console.WriteLine(person);
Console.WriteLine(person2);

Person person3 = new("ccc","ddd");
Console.WriteLine(person3);

var phoneNumbers = new string[2];
Person3 person4 = new("Nancy", "Davolio", phoneNumbers);
Person3 person5 = new("Nancy", "Davolio", phoneNumbers);
Console.WriteLine(person4 == person5); // output: True

person4.PhoneNumbers[0] = "555-1234";
Console.WriteLine(person4 == person5); // output: True
Console.WriteLine(ReferenceEquals(person4, person5)); // output: False

Person teacher = new Teacher("Nancy", "Davolio", 3);
Console.WriteLine(teacher);

// And a couple of other features in the documentation

// Init only setters
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#init-only-setters
//Error if uncommenting this
//person2.Name = "aaa";


// Top-level statements
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#top-level-statements
// This is already used in all of the Program.cs


// Pattern matching enhancements
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#pattern-matching-enhancements

string? somethingOrNot = null;

if (somethingOrNot is not null) {
    Console.WriteLine("It's something");
}

char aaa = 'a';
Console.WriteLine(aaa.IsLetter());
char sep = '.';
Console.WriteLine(sep.IsLetterOrSeparator());

// Performance and interop
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#performance-and-interop


// Fit and finish features
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#fit-and-finish-features

// Support for code generators
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#support-for-code-generators
