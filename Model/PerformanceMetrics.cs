namespace vim_quest.Model;

public class Metric(int value, int scorePoints, int penalty, int threshold, int thresholdIncrement)
{
    public int CalculateScore()
    {
        int calculatedScore = scorePoints;
        for (int currentThreshold = threshold; currentThreshold < value; currentThreshold += thresholdIncrement)
        {
            calculatedScore = Math.Max(0, calculatedScore - penalty);
        }
        return calculatedScore;
    }
}

public class PerformanceMetrics(int attempts, int errorsMade, int timeTaken, int timeToFirstKey)
{
    private readonly Metric _attempts = new(attempts, 15, 10, 1, 1);
    private readonly Metric _errorsMade = new(errorsMade, 25, 5, 0, 1);
    private readonly Metric _timeTaken = new(timeTaken, 35, 5, 100, 100);
    private readonly Metric _timeToFirstKey = new(timeToFirstKey, 25, 5, 50, 50);

    public double CalculateOverallPerformanceScore()
    {
        return (_attempts.CalculateScore() + _errorsMade.CalculateScore() + 
               _timeTaken.CalculateScore() + _timeToFirstKey.CalculateScore()) / 100.0;
    }
}