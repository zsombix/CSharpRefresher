class Point
{
    public int X { get; set; }  
    public int Y { get; set; }
    public int Z { get; set; }

    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    //Need to have a Deconstruct function for pattern matching to work
    public void Deconstruct(out int x, out int y, out int z)
    {
        x = X;
        y = Y;
        z = Z;
    }
}

class PatternMatching 
{
    public void Check()
    {
        var point = new Point(1,2,3);
        if (point is Point(1, var myVar, _)){
            Console.WriteLine($"Point matched {myVar}");
        }
    }


}