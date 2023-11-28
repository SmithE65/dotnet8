
using csharp12;
using System.Runtime.CompilerServices;
using Bob = (int Number, string Name);

var test = new PrimaryConstructors("bob", "jones");
Console.WriteLine(test.First);
Console.WriteLine(test.Age);
test.GrowUp();
Console.WriteLine(test.Age);

var world = "world!";
var result = CollectionExpressions.Test([.."Hello, ", ..world]);
Console.WriteLine(result);

//RefReadonly.Ref(ref "test");
//RefReadonly.Readonly("test");
//RefReadonly.In("test");

var testString = "test";
RefReadonly.Ref(ref testString);
RefReadonly.Readonly(ref testString);
RefReadonly.Readonly(in testString);
RefReadonly.In(testString);

var upper = (string x = "test") => x.ToUpper();
Console.WriteLine(upper());
Console.WriteLine(upper("hello"));
Console.WriteLine(TestMethod().ToString());

static Bob TestMethod()
{
    return (42, "hello");
}
