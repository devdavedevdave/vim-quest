using vim_quest.Model;

class Program
{
    static void Main(string[] args)
    {
        PerformanceMetrics metrics = new PerformanceMetrics(1, 1, 300, 100);
        int performanceScore = metrics.CalculateOverallPerformanceScore();
        Console.WriteLine("--- Overall performance score ---");
        Console.WriteLine(performanceScore);
        
        Console.WriteLine("--- Specific performance score ---");
        Console.WriteLine("Attempts:");
        int attemptScore = metrics.CalculatePerformanceScore(2, 25, 10, 1, 1);
        Console.WriteLine(attemptScore);
        
        Console.WriteLine("Errors:");
        int errorScore = metrics.CalculatePerformanceScore(1, 25, 5, 0, 1);
        Console.WriteLine(errorScore);
        
        Console.WriteLine("TimeTaken:");
        int timeTakenScore = metrics.CalculatePerformanceScore(300, 25, 5, 100, 100);
        Console.WriteLine(timeTakenScore);
        
        Console.WriteLine("TimeToFirstKey:");
        int timeToFirstKey = metrics.CalculatePerformanceScore(100, 25, 5, 50, 50);
        Console.WriteLine(timeToFirstKey);
        
    }
}