ref struct Test
{
    public void Dispose() {}
    public void WriteTest()
    {
        Console.WriteLine("test");
    }
}

class Usings
{
    public static void RunStatement()
    {
        using var alma = new Test();
        alma.WriteTest();
    }
}