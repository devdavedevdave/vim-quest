namespace vim_quest.Model;

public class Exercise
{
    public string Code { get; set; }

    public string Description { get; set; }
    public int Points { get; set; }

    public string Difficulty { get; set; }

    public List<Session> Sessions { get; set; } 
    
    public List<Command> Commands { get; set; }
    
    public Exercise(string code, string description, int points, string difficulty, List<Session> sessions, List<Command> commands)
    {
        Code = code;
        Description = description;
        Points = points;
        Difficulty = difficulty;
        Sessions = sessions;
        Commands = commands;
    }
}