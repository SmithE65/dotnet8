namespace csharp12;

public class PrimaryConstructors(string first, string last, string middle, int age) : Base(age)
{
    public PrimaryConstructors() : this(string.Empty, string.Empty, string.Empty, default) { }
    public PrimaryConstructors(string first, string last) : this(first, string.Empty, last, default) { }

    public string First { get; } = first;
    public string Last { get; } = last;

    public override string ToString()
    {
        return string.Join(string.Empty, First, middle, Last);
    }
}

public class Base(int age)
{
    public int Age => age;

    public int GrowUp() => ++age;
}
