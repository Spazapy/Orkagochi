namespace Orkagochi;

public class Orka
{
    
    // General Info
    private string name;
    private string baseColor;
    private string patternColor;
    private string gender;
    private int age;
    private string familyGroup;
    private bool reproductiveStatus;
    private int experience;
    private int level;
    
    // Body info
    private int weight;
    private double length;
    private double height;
    private double width;
    private int finSize;
    private int teethCount;
    private int teethSize;
    private int blubberThickness;
    
    // Condition
    private int health;
    private int energy;
    private int hunger;
    private int thirst;
    private int happiness;
    private int stressLevel;
    private int boredom;
    private bool isTired;
    private bool isHungry;
    private bool isSick;
    private int maxTemperatureTolerance;
    private int minTemperatureTolerance;
    
    // Stats
    private int intelligence = 5;
    private int agility = 5;
    private int swimmingSpeed = 5;
    private int huntingSkill = 5;
    private bool knowsEcholocation;
    private FoodType preferedFood;
    private int successRate;
    private bool huntsInGroup;
    private int socialSkill;
    private int loneliness;
    private int dominance;
    private bool isLeader;
    
    // location
    private int orcaLocation;
    
    
    // GET & SET: 
    public string Name { get => name; set => name = value; }
    public string BaseColor { get => baseColor; set => baseColor = value; }
    public string PatternColor { get => patternColor; set => patternColor = value; }
    public string Gender { get => gender; set => gender = value; }
    public int Age { get => age; set => age = value; }
    public string FamilyGroup { get => familyGroup; set => familyGroup = value; }
    public bool ReproductiveStatus { get => reproductiveStatus; set => reproductiveStatus = value; }
    public int Experience { get => experience; set => experience = value; }
    public int Level { get => level; set => level = value; }
    public int Weight { get => weight; set => weight = value; }
    public double Lenght { get => length; set => length = value; }
    public double Height { get => height; set => height = value; }
    public double Width { get => width; set => width = value; }
    public int FinSize { get => finSize; set => finSize = value; }
    public int TeethCount { get => teethCount; set => teethCount = value; }
    public int TeethSize { get => teethSize; set => teethSize = value; }
    public int BlubberThickness { get => blubberThickness; set => blubberThickness = value; }
    public int Health { get => health; set => health = value; }
    public int Energy { get => energy; set => energy = value; }
    
    public int Hunger { get => hunger; set => hunger = value; }
    
    public int Thirst { get => thirst; set => thirst = value; }
    public int Happiness { get => happiness; set => happiness = value; }
    public int StressLevel { get => stressLevel; set => stressLevel = value; }
    public int Boredom { get => boredom; set => boredom = value; }
    public bool IsTired { get => isTired; set => isTired = value; }
    public bool IsHungry { get => isHungry; set => isHungry = value; }
    public bool IsSick { get => isSick; set => isSick = value; }
    public int MaxTemperatureTolerance { get => maxTemperatureTolerance; set => maxTemperatureTolerance = value; }
    public int MinTemperatureTolerance { get => minTemperatureTolerance; set => minTemperatureTolerance = value; }
    public int Intelligence { get => intelligence; set => intelligence = value; }
    public int Agility { get => agility; set => agility = value; }
    public int SwimmingSpeed { get => swimmingSpeed; set => swimmingSpeed = value; }
    public int HuntingSkill { get => huntingSkill; set => huntingSkill = value; }
    public bool KnowsEchoLocation { get => knowsEcholocation; set => knowsEcholocation = value; }
    public FoodType PreferedFood { get => preferedFood; set => preferedFood = value; }
    public int SuccesRate { get => successRate; set => successRate = value; }
    public bool HuntsInGroup { get => huntsInGroup; set => huntsInGroup = value; }
    
    public int SocialSkill { get => socialSkill; set => socialSkill = value; }
    public int Loneliness { get => loneliness; set => loneliness = value; }
    public int Dominance { get => dominance; set => dominance = value; }
    public bool IsLeader { get => isLeader; set => isLeader = value; }
    public int OrcaLocation { get => orcaLocation; set => orcaLocation = value; }

    public enum FoodType
    {
        Fish,
        MarineMammals,
        Everything
    }
    
    // Constructor

    public Orka(string name, string baseColor, string patternColor, string gender, int age, int weight, double length, double height, double width, int finSize, int teethCount, int teethSize, int blubberThickness)
    {
        // Base Values
        this.name = name;
        this.baseColor = baseColor;
        this.patternColor = patternColor;
        this.gender = gender;
        this.age = age;
        this.weight = weight;
        this.length = length;
        this.height = height;
        this.width = width;
        this.finSize = finSize;
        this.teethCount = teethCount;
        this.teethSize = teethSize;
        this.blubberThickness = blubberThickness;
        
        // Conditions
        health = 100;
        energy = 1000;
        hunger = 0;
        thirst = 0;
        happiness = 100;
        stressLevel = 0;
        boredom = 0;
        loneliness = 0;
        dominance = 10;
        isLeader = false;
        
        // skills and intelligence
        experience = 0;
        level = 1;
        intelligence = 20;
        agility = 20;
        swimmingSpeed = 30;
        huntingSkill = 30;
        successRate = 50;
        huntsInGroup = false;
        socialSkill = 20;
        knowsEcholocation = false;
        
        // Environment
        maxTemperatureTolerance = 25;
        minTemperatureTolerance = -2;
        orcaLocation = 0;
    }

    

    // Methods:
    public override string ToString()
    {
        return $"Name: {name}, Hauptfarbe: {baseColor}, MusterFarbe: {patternColor}, " +
               $"Geschlecht: {gender}, Alter: {age}, Gewicht: {weight}kg, Länge: {length}m, "+
               $"Höhe: {height}, Breite: {width}, Flossengröße: {finSize}m, Zahnanzahl: {teethCount}m, "+
               $"Zahngröße {teethSize}, Hautschicht: {blubberThickness} mm, Gesundheit: {health}, Energie: {energy}, Hunger: {hunger}, Durst: {thirst}, " +
               $"Glück: {happiness}, Stresslevel: {stressLevel}, Jagdfähigkeit: {huntingSkill}, " +
               $"Standort-ID: {orcaLocation}";
    }




}