public class NameOfExprs
{
    public void ShowParamName(string nameOfParam)
    {
        Console.WriteLine($"Name of param: {nameof(nameOfParam)} with given value: {nameOfParam}");
    }
}