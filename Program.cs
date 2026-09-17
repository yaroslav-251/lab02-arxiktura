using System.Diagnostics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Debug vs Release");

        int sum = Add(2, 3);
        Console.WriteLine($"Add(2, 3) = {sum}");

    int n = 1_000_000_000;
    var stopwatch = Stopwatch.StartNew();
    long result1 = SumTo(n);

    stopwatch.Stop();

    Console.WriteLine($"SumTo({n:NO}) = {result1:N0}");
    Console.WriteLine($"Время: {stopwatch.ElapsedMilliseconds} мс");
    }
    static int Add(int a, int b)
    {
        int result = a + b;
        return result;
    }
    static long SumTo(int n)
    {
        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}
