class NullRefereceType
{
  public static void ReferencingNullableString()
  {
    string? nullableString = null;
    Console.WriteLine(nullableString.Length); // WARNING: may be null! 
  }
}