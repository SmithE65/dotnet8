namespace corelibs;

public record class MyModel(string Name, DateTime Created);

public class TimeAbstraction(TimeProvider timeProvider)
{
    public MyModel CreateModel(string name) => new(name, timeProvider.GetUtcNow().DateTime);
}
