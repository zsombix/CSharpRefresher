public struct ReadOnlyInstanceMemebers
{
    private int X { get; set; }
    public readonly int IncreaseX()
    {
        // This will not compile: C# 8 
        //X = X + 1; 
        var newX = X + 1; // OK 
        return newX;
    }

    public void SetX(int x){
        X = x;
    }
}

