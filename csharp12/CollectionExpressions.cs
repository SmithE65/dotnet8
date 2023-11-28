namespace csharp12;

public static class CollectionExpressions
{
    public static int[] GetEmptyArray() => [];
    public static List<int> GetEmptyList() => [];
    public static IEnumerable<int> GetEmptyEnumerable() => [];

    public static string Test(string input)
    {
        ReadOnlySpan<char> first = [char.ToLowerInvariant(input[0])];
        var last = input.AsSpan()[1..];
        return string.Concat(first, last);
    }

    public static string Test(ReadOnlySpan<char> input)
    {
        ReadOnlySpan<char> first = [char.ToLowerInvariant(input[0])];
        var last = input[1..];
        return string.Concat(first, last);
    }
}
