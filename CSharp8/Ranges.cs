class Ranges
{
    public static void RunExamples()
    {
        Index i1 = 3; // number 3 from beginning  
        Index i2 = ^4; // number 4 from end
        int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };  
        Console.WriteLine($"{a[i1]}, {a[i2]}"); // "3, 6"

        var slice = a[i1..i2]; // { 3, 4, 5 }
        Console.WriteLine(slice.Length);
    }
}