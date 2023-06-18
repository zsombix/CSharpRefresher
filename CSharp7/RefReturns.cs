public class RefReturns
{
    public static ref int Find(int number, int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == number)
            {
                return ref numbers[i]; // return the storage location, not the value
            }
        }
        throw new IndexOutOfRangeException($"{nameof(number)} not found");
    }
}