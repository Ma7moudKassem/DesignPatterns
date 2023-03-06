using Singleton_Pattern;

Counter counter3 = Counter.GetInistance();

await Task.Factory.StartNew(() =>
{
    Counter counter1 = Counter.GetInistance();
    counter1.AddOne();
    Console.WriteLine(counter1.Count);
});
await Task.Factory.StartNew(() =>
{
    Counter counter2 = Counter.GetInistance();
    counter2.AddOne();
    Console.WriteLine(counter2.Count);
});

//Console.WriteLine(counter1.Count);
//Console.WriteLine(counter2.Count);
//Console.WriteLine(counter3.Count);