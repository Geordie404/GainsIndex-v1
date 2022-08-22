public class Exercise
{
    public int id { get; set; }
    public string exercise { get; set; } // name of exercise ex. Flat Bench Press
    public string details { get; set; } // small description, tips, etc
    public string? ww_bella { get; set; } // working weight for bella
    public string? ww_geo { get; set; } // working weight for geo
    public string target_muscle { get; set; } // target muscle
    public int sets { get; set; } // set count number
    public int reps { get; set; } // rep count number
    public bool is_active { get; set; } // is it currently live in the routine
    public Motion motion_group { get; set; } // push pull or legs categorization
    public Focus body_focus { get; set; } // area of body
    public Complexity exercise_type { get; set; } // exercise complexity
    public Day week_day { get; set; }
}

public enum Motion {
    Push,
    Pull,
    Legs
}

public enum Focus {
    Arms,
    Chest,
    Shoulders,
    Back,
    Abdominals,
    Glutes,
    Legs 
}

public enum Complexity {
    Compound,
    Isolation,
    Cardio
}

public enum Day {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
