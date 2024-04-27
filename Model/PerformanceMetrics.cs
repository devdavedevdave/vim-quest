namespace vim_quest.Model;

public class PerformanceMetrics
{
    private int Attempts;

    private int TimeTaken;

    private int ErrorsMade;

    private int TimeToFirstKey;

    public int CalculateOverallPerformanceScore()
    {
        // Calculate performance score of each single one.
            // This needs to be enough flexible, for me to be able to add new criterias
            // Also I want to have a base set of criterias, which validate the score, but be able to change this based on the exercise
        // Return sum of PerformanceScore
        return 0;
    }

    private int CalculateAttemptsScore(int penalty)
    {
        int score = 25;
        
        if (Attempts > 1)
        {
            for (int i = 1; i < Attempts; i++)
            {
                if (score - penalty < 0)
                {
                    score = 0;
                    break;
                }
                score -= penalty;
            }
        }

        return score;
    }

    private int CalculateTimeTakenScore()
    {
        int score = 25;

        switch (TimeTaken)
        {
            case <= 1000:
                break;
            case <= 1250:
                score -= 5;
                break;
            case <= 1500:
                score -= 10;
                break;
            case <= 1750:
                score -= 15;
                break;
            case <= 2000:
                score -= 20;
                break;
            default:
                score = 0;
                break;
        }

        return score;
    }
    
    private int CalculateErrorsMadeScore()
    {
        int score = 25;
        
        switch (ErrorsMade)
        {
            case == 0:
                break;
            case == 1:
                score -= 5;
                break;
            case == 2:
                score -= 10;
                break;
            case == 3:
                score -= 15;
                break;
            case == 4:
                score -= 20;
                break;
            default:
                score = 0;
                break;
        }

        return score;
    }
    
    private int CalculateTimeToFirstKeyScore()
    {
        
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

