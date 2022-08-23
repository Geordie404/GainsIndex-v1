public class Exercise
{
    public int id { get; set; }
    public string exercise_name { get; set; } // name of exercise ex. Flat Bench Press
    public string details { get; set; } // small description, tips, etc
    public int? ww_bella { get; set; } // working weight for bella
    public int? ww_geo { get; set; } // working weight for geo
    public string? log_bella { get; set; } // working weight log for bella
    public string? log_geo { get; set; } // working weight log for geo
    public string target_muscle { get; set; } // target muscle
    public string sets { get; set; } // set count number
    public string reps { get; set; } // rep count number

    // Enum Fields
    public Motion? motion_group { get; set; } // push pull or legs categorization
    public Focus? body_focus { get; set; } // area of body
    public Complexity? exercise_type { get; set; } // exercise complexity
    
    // Bool for bella days
    public bool bella_monday{ get; set; }
    public bool bella_tuesday { get; set; }
    public bool bella_wednesday { get; set; }
    public bool bella_thursday { get; set; }
    public bool bella_friday { get; set; }
    public bool bella_weekend{ get; set; }

    // Bool for geordie days
    public bool geo_monday{ get; set; }
    public bool geo_tuesday { get; set; }
    public bool geo_wednesday { get; set; }
    public bool geo_thursday { get; set; }
    public bool geo_friday { get; set; }
    public bool geo_weekend{ get; set; }
}

public enum Motion {
    Push,
    Pull,
    Hinge, 
    Bend
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