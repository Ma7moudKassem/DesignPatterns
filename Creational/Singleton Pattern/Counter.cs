namespace Singleton_Pattern;

public class Counter
{
    private Counter()
    {

    }
    static Counter? counter = null;
    private static object lockObj = new object();
    public int Count { get; set; }
    public void AddOne() => Count++;

    public static Counter GetInistance()
    {
        // lazy intialization
        if (counter is null)
        {
            lock (lockObj)
            {
                if (counter is null) counter = new Counter();
            }
        }

        return counter;
    }
}
