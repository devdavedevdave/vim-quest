using vim_quest.Model;

class Program
{
    static void Main(string[] args)
    {
        PerformanceMetrics metrics = new PerformanceMetrics(5, 300, 4, 50);
        int performanceScore = metrics.CalculateOverallPerformanceScore();
        Console.WriteLine("--- Overall performance score ---");
        Console.WriteLine(performanceScore);
    }
}