namespace vim_quest.Model;

public enum SessionStatus
{
    NotStarted,
    InProgress,
    Paused,
    Completed,
    Aborted
}

public class Session
{
    public PerformanceMetrics PerformanceMetrics { get; set; }
    
    public SessionStatus Status { get; set; }

    public Session()
    {
        Status = SessionStatus.NotStarted;
    }
}