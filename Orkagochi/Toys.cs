namespace Orkagochi;

public class Toys
{
    
    // General Info
    private string name;
    private string type;
    private string material;
    private string size;
    
    // Toy Condition
    private string condition;
    private int durability;
    private int used;
    
    // Toy & Orca Interaction
    private int happinessBoost;
    private int energyBoost;
    private int stressRelief;
    private int playDuration;
    
    // More Toy Key marks
    private bool interactable;
    private bool isFavorite;
    private string playStyle;
    
    // Special Toy marks
    private bool waterproof;
    private bool interactive;
    private bool sound;

    // GET & SET:
    public string Name { get => name; set => name = value; }
    public string Type { get => type; set => type = value; }
    public string Material { get => material; set => material = value; }
    public string Size { get => size; set => size = value; }
    public string Condition { get => condition; set => condition = value; }
    public int Durability { get => durability; set => durability = value; }
    public int Used { get => used; set => used = value; }
    public int HappinessBoost { get => happinessBoost; set => happinessBoost = value; }
    public int EnergyBoost { get => energyBoost; set => energyBoost = value; }
    public int StressRelief { get => stressRelief; set => stressRelief = value; }
    public int PlayDuration { get => playDuration; set => playDuration = value; }
    public bool Interactable { get => interactable; set => interactable = value; }
    public bool IsFavorite { get => isFavorite; set => isFavorite = value; }
    public string PlayStyle { get => playStyle; set => playStyle = value; }
    public bool Waterproof { get => waterproof; set => waterproof = value; }
    public bool Interactive { get => interactive; set => interactive = value; }
    public bool Sound { get => sound; set => sound = value; }

}