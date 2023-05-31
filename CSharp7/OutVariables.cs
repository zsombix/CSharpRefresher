public class OutVariables
{
    
    public static void  PrintNumbers(int num)
    {
        CalculateNums(num,out int x, out int y);
        Console.WriteLine($"({x}, {y})");
    }

    private static void CalculateNums(int num,out  int x,out int y )
    {
        x = num / 7;
        y = num % 7;
    } 

}
