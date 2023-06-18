using System.Collections.Concurrent;

public class Person
{
    private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int, string>();
    private int id = GetId();

    public Person(string name) => names.TryAdd(id, name); // constructors
    ~Person() => names.TryRemove(id, out _);              // finalizers
    public string Name
    {
        get => names[id];                                 // getters
        set => names[id] = value;                         // setters
    }

    private static int GetId()
    {
        return 1;
    }
}