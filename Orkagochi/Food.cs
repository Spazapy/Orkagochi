using System.Globalization;

namespace Orkagochi;

public class Food
{
    
    // General Info
    private Dictionary<int, string> foodname = new Dictionary<int, string>
    {
        {1, "Lachs"},
        {2, "Hering"},
        {3, "Makrele"},
        {4,"Kabeljau"},
        {5,"Seehund"},
        {7, "Seelöwe"},
        {8, "Robbe"},
        {9, "Schweinswal"},
        {10, "Delfin"},
        {11, "Beluga"},
        {12, "Grauwalkalb"},
        {13, "Risenkalmar"},
        {14, "Oktopuss"},
        {15, "Pinguin"},
        {16, "Möwe"},
        {17,"Meeresschildkröte"},
        {18, "Rochen"}
        
    };
    private string type;
    private string category;
    
    // Nutritional information
    private Dictionary<int, int> consume = new Dictionary<int, int>()
    {
        {1, 50},    // Lachs
        {2, 40},    // Hering
        {3, 35},    // Makrele
        {4, 30},    // Kabeljau
        {5, 100},   // Seehund
        {7, 120},   // Seelöwe
        {8, 100},   // Robbe
        {9, 150},   // Schweinswal
        {10, 160},  // Delfin
        {11, 180},  // Beluga
        {12, 250},  // Grauwalkalb
        {13, 80},   // Riesenkalmar
        {14, 45},   // Oktopus
        {15, 70},   // Pinguin
        {16, 20},   // Möwe
        {17, 60},   // Meeresschildkröte
        {18, 90}    // Rochen

    };

    private int happinessBoost;
    private int healthBoost;
    private int hungerSatisfaction;
    private int thirstSatisfaction;
    
    // additional properties
    private bool toxicity;
    private bool preferredByOrca;
    private string rarity;
    
    // effects on orka
    private int healthImpact;
    private int energyBoostRate;
    private int timeToConsume;
    
    // food management
    private bool isSpoiled;
    private DateTime expirationTime;
    private int quantityAvaiable;
    
    // More food marks
    private int suitableForAge;
    private bool isFresh;
    private bool isSeasonal;
    
    // GET & SET
    public Dictionary<int, string> Foodname { get => foodname; set => foodname = value; }
    public string Type { get => type; set => type = value; }
    public string Category { get => category; set => category = value; }
    public Dictionary<int, int> Consume { get => consume; set => consume = value; }
    public int HappinessBoost { get => happinessBoost; set => happinessBoost = value; }
    public int HealthBoost { get => healthBoost; set => healthBoost = value; }
    public int HungerSatisfication { get => hungerSatisfaction; set => hungerSatisfaction = value; }
    public int ThirstSatisfaction { get => thirstSatisfaction; set => thirstSatisfaction = value; }
    public bool Toxicity { get => toxicity; set => toxicity = value; }
    public bool PreferredByOrca { get => preferredByOrca; set => preferredByOrca = value; }
    public string Rarity { get => rarity; set => rarity = value; }
    public int HealthImpact { get => healthImpact; set => healthImpact = value; }
    public int EnergyBoostRate { get => energyBoostRate; set => energyBoostRate = value; }
    public int TimeToConsume { get => timeToConsume; set => timeToConsume = value; }
    public bool IsSpoiled { get => isSpoiled; set => isSpoiled = value; }
    public DateTime ExpirationTime { get => expirationTime; set => expirationTime = value; }
    public int QuantityAvaiable { get => quantityAvaiable; set => quantityAvaiable = value; }
    public int SuitableForAge { get => suitableForAge; set => suitableForAge = value; }
    public bool IsFresh { get => isFresh; set => isFresh = value; }
    public bool IsSeasonal { get => isSeasonal; set => isSeasonal = value; }
}