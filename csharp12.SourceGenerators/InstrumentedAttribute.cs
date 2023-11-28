using System.Runtime.CompilerServices;

namespace csharp12.SourceGenerators;

[AttributeUsage(AttributeTargets.Method)]
public class InstrumentedAttribute : Attribute
{
}
