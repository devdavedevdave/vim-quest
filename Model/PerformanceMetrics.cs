namespace vim_quest.Model;

public class Metric
{
    public int Value { get; set; }
    public int ScorePoints { get; set; }
    public int Penalty { get; set; }
    public int Threshold { get; set; }
    public int ThresholdIncrement { get; set; }

    public Metric(int value, int scorePoints, int penalty, int threshold, int thresholdIncrement)
    {
        Value = value;
        ScorePoints = scorePoints;
        Penalty = penalty;
        Threshold = threshold;
        ThresholdIncrement = thresholdIncrement;
    }

    public int CalculateScore()
    {
        int calculatedScore = ScorePoints;
        for (int currentThreshold = Threshold; currentThreshold < Value; currentThreshold += ThresholdIncrement)
        {
            calculatedScore = Math.Max(0, calculatedScore - Penalty);
        }
        return calculatedScore;
    }
}

public class PerformanceMetrics
{
    private Metric Attempts;
    private Metric ErrorsMade;
    private Metric TimeTaken;
    private Metric TimeToFirstKey;

    public PerformanceMetrics(int attempts, int errorsMade, int timeTaken, int timeToFirstKey)
    {
        Attempts = new Metric(attempts, 15, 10, 1, 1);
        ErrorsMade = new Metric(errorsMade, 25, 5, 0, 1);
        TimeTaken = new Metric(timeTaken, 35, 5, 100, 100);
        TimeToFirstKey = new Metric(timeToFirstKey, 25, 5, 50, 50);
    }

    public int CalculateOverallPerformanceScore()
    {
        return Attempts.CalculateScore() + ErrorsMade.CalculateScore() + 
               TimeTaken.CalculateScore() + TimeToFirstKey.CalculateScore();
    }
}