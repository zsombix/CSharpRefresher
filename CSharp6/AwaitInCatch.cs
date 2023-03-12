public static class AwaitInCatch
{
    public async static void Do()
    {
        int num1 = 10;
        int num2 = 0;
        try
        {
            var res = num1 / num2;
        }
        catch (System.Exception)
        {
            await asyncMethod();
        }
        finally
        {
            await asyncMethod();
        }
    }

    private static Task asyncMethod()
    {
        Console.WriteLine("AsyncMethod!");
        return Task.FromResult("done");
    }
}