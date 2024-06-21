namespace vim_quest.Model;

public enum Performance
{
	Beginner,
	Intermediate,
	Advanced, 
	Expert,
	Master
}

public class Command
{
	string Name { get; set; }

	bool IsKnown { get; set; }

	private Performance UserPerformance { get; set; }	
	
	public Command(string name, Performance performance)
	{
		Name = name;
		UserPerformance = performance;
	}
}


