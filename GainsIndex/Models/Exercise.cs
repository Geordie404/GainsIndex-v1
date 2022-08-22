public class Exercise
{
    public int id { get; set; }
    public string exercise_name { get; set; } // name of exercise ex. Flat Bench Press
    public string details { get; set; } // small description, tips, etc
    public string? ww_bella { get; set; } // working weight for bella
    public string? ww_geo { get; set; } // working weight for geo
    public string target_muscle { get; set; } // target muscle
    public int sets { get; set; } // set count number
    public int reps { get; set; } // rep count number
    public bool is_active { get; set; } // is it currently live in the routine

    // Enum Fields
    public Motion? motion_group { get; set; } // push pull or legs categorization
    public Focus? body_focus { get; set; } // area of body
    public Complexity? exercise_type { get; set; } // exercise complexity
    
    // Bool for days
    public bool is_sunday { get; set; }
    public bool is_monday{ get; set; }
    public bool is_tuesday { get; set; }
    public bool is_wednesday { get; set; }
    public bool is_thursday { get; set; }
    public bool is_friday { get; set; }
    public bool is_saturday { get; set; }

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