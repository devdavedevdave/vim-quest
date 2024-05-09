namespace vim_quest.Model;

public class PerformanceMetrics
{
    private int Attempts;

    private int ErrorsMade;
    
    private int TimeTaken;

    private int TimeToFirstKey;

    public PerformanceMetrics(int attempts, int timeTaken, int errorsMade, int timeToFirstKey)
    {
        Attempts = attempts;
        ErrorsMade = errorsMade;
        TimeTaken = timeTaken;
        TimeToFirstKey = timeToFirstKey;
    }
    
    public int CalculateOverallPerformanceScore()
    {
        var attributes = new List<(int attribute, int penalty, int index, int indexIncrease, int upperLimit)>
        {
            (Attempts, 10, 1, 1, 4),
            (ErrorsMade, 3, 0, 1, 7),
            (TimeTaken, 5, 1, 1, 600),
            (TimeToFirstKey, 5, 50, 50, 300),
        };
        
        int scorePoints = 100 / attributes.Count;

        return attributes.Select(el => CalculatePerformanceScore(el.attribute, scorePoints, el.penalty, el.index, el.indexIncrease, el.upperLimit)).Sum();
    }
    
    private static int CalculatePerformanceScore(int attribute, int scorePoints, int penalty, int index, int indexIncrease, int upperLimit)
    {
        for (; index < attribute || index < upperLimit; index += indexIncrease)
        {
            if (scorePoints - penalty < 0)
            {
                scorePoints = 0;
                break;
            }

            scorePoints -= penalty;
        }

        return scorePoints;
    }
}



// Attemps: 5 (int)
// TimeTaken: 256 (ms)
// ErrorsMade: 5 (int)
// TimeToFirstKey: 50ms

// PerformanceScore: 100 
// PerformanceScore: 100 
// PerformanceScore: 100

// each criteria gives 25
// when not meeting a certain ideal, they get minus points.

