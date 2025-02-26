namespace Orkagochi;

public class Location
{
    
    // General info
    private string name;
    private string region;
    private float latitude;
    private float longitude;
    private string climateType;
    
    // Enviroment 
    private float temperature; // C°
    private float saltValue; // PSU
    private int waterVisibility;
    private float waterCurrent; // m/s
    
    // Food & prey
    private int fishPopulation;
    private int marineMammalPopulation;
    private int huntingDifficulty;
    
    // Danger & Challanges
    private bool predatorPresence;
    private int humanActivity;
    private int pollutionLevel;
    private float stormFrequency;
    private int stormStrength;
    
    // Social & Orca population
    private int orcaPopulation;
    private string socialStructure;
    private bool territorialConflicts;
    
    // GET & SET Values:
    public string Name { get => name; set => name = value; }
    public string Region { get => region; set => region = value; }
    public float Latitude { get => latitude; set => latitude = value; }
    public float Longitude { get => longitude; set => longitude = value; }
    public string ClimateType { get => climateType; set => climateType = value; }
    public float Temperature { get => temperature; set => temperature = value; }
    public float SaltValue { get => saltValue; set => saltValue = value; }
    public int WaterVisibility { get => waterVisibility; set => waterVisibility = value; }
    public float WaterCurrent { get => waterCurrent; set => waterCurrent = value; }
    public int FishPopulation { get => fishPopulation; set => fishPopulation = value; }
    public int MarineMammalPopulation { get => marineMammalPopulation; set => marineMammalPopulation = value; }
    public int HuntingDifficulty { get => huntingDifficulty; set => huntingDifficulty = value; }
    public bool PredatorPresence { get => predatorPresence; set => predatorPresence = value; }
    public int HumanActivity { get => humanActivity; set => humanActivity = value; }
    public int PollutionLevel { get => pollutionLevel; set => pollutionLevel = value; }
    public float StormFrequency { get => stormFrequency; set => stormFrequency = value; }
    public int StormStrength { get => stormStrength; set => stormStrength = value; }
    public int OrcaPopulation { get => orcaPopulation; set => orcaPopulation = value; }
    public string SocialStructure { get => socialStructure; set => socialStructure = value; }
    public bool TerritorialConflicts { get => territorialConflicts; set => territorialConflicts = value; }
    
}