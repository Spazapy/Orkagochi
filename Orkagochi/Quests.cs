namespace Orkagochi;

public class Quests
{
    
    // General Quest Infos
    private int questID;
    private string questName;
    private string questDescription;
    private string questType;
    private int questDifficulty;
    private bool isRepeatable;
    private int timeLimit;
    private string questGiver;
    
    // Quest goal & progress
    private Dictionary<string, int> requiredActions;
    private Dictionary<string, int> currentProgress;
    private bool isCompleted;
    private DateTime completionTime;
    
    // Rewards and Consequenzes
    private int rewardExperience;
    private List<int> rewardItems;
    private int rewardCurrency;
    private bool unlocksNewQuest;
    private string penaltyOnFailure;
    
    // Status and managing
    private bool isActive;
    private bool isFailed;
    
    // GET & SET
    public int QuestID { get => questID; set => questID = value; }
    public string QuestName { get => questName; set => questName = value; }
    public string QuestDescription { get => questDescription; set => questDescription = value; }
    public string QuestType { get => questType; set => questType = value; }
    public int QuestDifficulty { get => questDifficulty; set => questDifficulty = value; }
    public bool IsRepeatable { get => isRepeatable; set => isRepeatable = value; }
    public int TimeLimit { get => timeLimit; set => timeLimit = value; }
    public string QuestGiver { get => questGiver; set => questGiver = value; }
    public Dictionary<string, int> RequiredActions { get => requiredActions; set => requiredActions = value; }
    public Dictionary<string, int> CurrentProgress { get => currentProgress; set => currentProgress = value; }
    public bool IsCompleted { get => isCompleted; set => isCompleted = value; }
    public DateTime CompletionTime { get => completionTime; set => completionTime = value; }
    public int RewardExperience { get => rewardExperience; set => rewardExperience = value; }
    public List<int> RewardItems { get => rewardItems; set => rewardItems = value; }
    public int RewardCurrency { get => rewardCurrency; set => rewardCurrency = value; }
    public bool UnlocksNewQuest { get => unlocksNewQuest; set => unlocksNewQuest = value; }
    public string PenaltyOnFailure { get => penaltyOnFailure; set => penaltyOnFailure = value; }
    public bool IsActive { get => isActive; set => isActive = value; }
    public bool IsFailed { get => isFailed; set => isFailed = value; }

}