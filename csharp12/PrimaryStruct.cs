namespace csharp12;

public readonly struct PrimaryStruct(int one, string two, DateTime three)
{
    public int One { get; } = one;
    public string Two { get => two; }
    public string Three { get; } = three.ToString();
    public int Four { get; } = three.Year;
    public DateTime Five { get; } = three;
}
