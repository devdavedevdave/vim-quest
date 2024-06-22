namespace vim_quest.Model;

public class ExerciseSelector
{
    public Queue<Exercise> _exerciseBuffer;
    
    public Queue<Exercise> fillBuffer()
    {
        // PSEUDO CODE
        // Commands = LoadAllCommands(); 
        // Commands.Filter(x => x.IsKnown);
        
        // newExercise = ShouldAddNewExercise(); // Already contain the new exercise. 
        // longAgo = Commands.reduce(x => x.TrainingTimestamp > y.TrainingTimestamp);
        // reallyBadAt = Commands.reduce(x => x.UserPerformance == Beginner);  

        // return _exerciseBuffer.push(newExercise, longAgo, reallyBadAt);
    }
}

// Nutzer sollte fortlaufend neuen Übungen vorgestellt werden. Er muss aber in alten Übungen genug proficiency haben, damit er fortfahren darf.

// Aber schlussendlich gibt es nur welche, die er kennt. Wie also wiederhole ich Aufgaben, die er bereits kennt?
// - Schon lange nicht mehr ausgeführt. 
// - Er ist nicht gut darin
// - 