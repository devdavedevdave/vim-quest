namespace vim_quest.Model;

public class Progress
{   
    private List<Exercise> _completedExercises = new();

    private int Level { get; set; } = 0;

    private int Points { get; set; } = 0;

    public void AddCompletedExercise(Exercise exercise)
    {
        _completedExercises.Add(exercise);
    }
    
    private double CalculatePointsForExercise(Exercise exercise)
    {
       var exercisePoints = exercise.Points;
       var sessions = exercise.Sessions;

       var transformedSessions =
           sessions.Select(x => exercisePoints * x.PerformanceMetrics.CalculateOverallPerformanceScore());
       return transformedSessions.Sum();
    }

    private double CalculateOverallPoints()
    {
        var completedExercises = _completedExercises;
        return completedExercises.Select(CalculatePointsForExercise).Sum();
    }
    
    private int CalculateLevelFromPoints(int points)
    {
        // Maybe this needs to be more fine tuned with calculating in the performance score. 
        if (points < 300) return 1; // White Belt
        if (points < 900) return 2; // Blue Belt
        if (points < 1500) return 3; // Purple Belt
        if (points < 3000) return 4; // Brown Belt
        return 5; // Black Belt
    }
}