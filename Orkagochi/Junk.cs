namespace Orkagochi;

public class Junk
{
    
    // General Info
    private string name;
    private string type;
    private string size;
    private string color;
    private int weight;
    
    // Junk condition
    private string condition;
    private float decayRate;
    
    // orca negative effect
    private int healthImpact;
    private int energyImpact;
    private int stressImpact;
    private int happinessImpact;
    
    // junk interaction
    private bool isToxic;
    private bool attractedToOrca;
    private bool canBeEaten;
    private bool canBeRecycled;
    
    // more junk marks
    private string location;
    private string origin;
    private bool collected;
    
    // Enviroment effects
    private int pollutionLevel;
    private bool potentialDangerToEnviroment;
    private int decomposesln;
    
    // GET & SET Values:
    public string Name { get => name; set => name = value; }
    public string Type { get => type; set => type = value; }
    public string Size { get => size; set => size = value; }
    public string Color { get => color; set => color = value; }
    public int Weight { get => weight; set => weight = value; }
    public string Condition { get => condition; set => condition = value; }
    public float DecayRate { get => decayRate; set => decayRate = value; }
    public int HealthImpact { get => healthImpact; set => healthImpact = value; }
    public int EnergyImpact { get => energyImpact; set => energyImpact = value; }
    public int StressImpact { get => stressImpact; set => stressImpact = value; }
    public int HappinessImpact { get => happinessImpact; set => happinessImpact = value; }
    public bool IsToxic { get => isToxic; set => isToxic = value; }
    public bool AttractedToOrca { get => attractedToOrca; set => attractedToOrca = value; }
    public bool CanBeEaten { get => canBeEaten; set => canBeEaten = value; }
    public bool CanBeRecycled { get => canBeRecycled; set => canBeRecycled = value; }
    public string Location { get => location; set => location = value; }
    public string Origin { get => origin; set => origin = value; }
    public bool Collected { get => collected; set => collected = value; }
    public int PollutionLevel { get => pollutionLevel; set => pollutionLevel = value; }
    public bool PotentialDangerToEnviroment { get => potentialDangerToEnviroment; set => potentialDangerToEnviroment = value; }
    public int Decomposesln { get => decomposesln; set => decomposesln = value; }

}