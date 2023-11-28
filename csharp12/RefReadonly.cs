using System.Diagnostics.CodeAnalysis;

namespace csharp12;

public static class RefReadonly
{
    public static void Ref(ref string test)
    {
        Console.WriteLine(test);
    }

    public static void Readonly(ref readonly string test)
    {
        Console.WriteLine(test);
    }

    public static void In(in string test)
    {
        Console.WriteLine(test);
    }
}
