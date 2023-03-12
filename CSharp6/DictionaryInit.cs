public static class DictionaryInit
{
    public static void Do()
    {
        var newDict = new Dictionary<string,string>(){
            ["alma"] = "korte",
            ["dinnye"] = "narancs"
        };

        Console.WriteLine($"Dictionary value of alma : {newDict["alma"]}");
    }
}