namespace corelibs;

public class Randomness
{
    public static int[] GetIntArray(int count, int min, int max) => 
        System.Random.Shared.GetItems(Enumerable.Range(min, max - min).ToArray(), count);

    public static void Shuffle(int[] input) => System.Random.Shared.Shuffle(input);
}
