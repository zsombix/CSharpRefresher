public static class ExceptionFiltering
{
    public static void Do()
    {

        int num = 10;
        int num2 = 0;
        try
        {

            var res = num / num2;
        }
        catch (System.Exception) when (num2 == 0)
        {
            Console.WriteLine($"devide by zero error");
        }
        catch (System.Exception)
        {
            Console.WriteLine($"other error");
        }
    }
}