namespace Orkagochi;

public class Archievments
{
    
    // General Archievment Info
    private int archievmentID;
    private string archievmentName;
    private string archievmentDescription;
    private string category;
    private int difficulty;
    private bool isHidden;
    
    // progress & requirements
    private Dictionary<string, int> requiredActions;
    private Dictionary<string, int> currentProgress;
    private bool isUnlocked;
    private DateTime unlockDate;
    
    // rewards
    private int rewardExperience;
    private List<int> rewardItems;
    private int rewardCurrency;
    private string rewardTitle;
    
    // Archievment Managing & Display
    private bool isDisplayed;
    private int sortOrder;
    private List<int> linkedArchievments;
    
    // GET & SET
    public int ArchievmentID { get => archievmentID; set => archievmentID = value; }
    public string ArchievmentName { get => archievmentName; set => archievmentName = value; }
    public string ArchievmentDescription { get => archievmentDescription; set => archievmentDescription = value; }
    public string Category { get => category; set => category = value; }
    public int Difficulty { get => difficulty; set => difficulty = value; }
    public bool IsHidden { get => isHidden; set => isHidden = value; }
    public Dictionary<string, int> RequiredActions { get => requiredActions; set => requiredActions = value; }
    public Dictionary<string, int> CurrentProgress { get => currentProgress; set => currentProgress = value; }
    public bool IsUnlocked { get => isUnlocked; set => isUnlocked = value; }
    public DateTime UnlockDate { get => unlockDate; set => unlockDate = value; }
    public int RewardExperience { get => rewardExperience; set => rewardExperience = value; }
    public List<int> RewardItems { get => rewardItems; set => rewardItems = value; }
    public int RewardCurrency { get => rewardCurrency; set => rewardCurrency = value; }
    public string RewardTitle { get => rewardTitle; set => rewardTitle = value; }
    public bool IsDisplayed { get => isDisplayed; set => isDisplayed = value; }
    public int SortOrder { get => sortOrder; set => sortOrder = value; }
    public List<int> LinkedArchievments { get => linkedArchievments; set => linkedArchievments = value; }
}