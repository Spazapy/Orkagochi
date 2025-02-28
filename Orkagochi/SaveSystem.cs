namespace Orkagochi;

public class SaveSystem
{
    // General Save info
    private int saveID;
    private string saveName;
    private DateTime saveDate;
    private TimeSpan playTime;
    private string gameVersion;
    
    // Saved game files
    private Orka orcaData;
    private List<int> inventoryData;
    private int locationData;
    private Dictionary<int, int> questProgress;
    private List<int> archievmentsUnlocked;
    private Settings settingsData;
    
    // File Managing & Backup
    private bool isAutoSave;
    private bool isCorrupted;
    private int backupSaveID;
    private string saveFilePath;
    
    // GET & SET
    public int SaveID { get => saveID; set => saveID = value; }
    public string SaveName { get => saveName; set => saveName = value; }
    public DateTime SaveDate { get => saveDate; set => saveDate = value; }
    public TimeSpan PlayTime { get => playTime; set => playTime = value; }
    public string GameVersion { get => gameVersion; set => gameVersion = value; }
    public Orka OrcaData { get => orcaData; set => orcaData = value; }
    public List<int> InventoryData { get => inventoryData; set => inventoryData = value; }
    public int LocationData { get => locationData; set => locationData = value; }
    public Dictionary<int, int> QuestProgress { get => questProgress; set => questProgress = value; }
    public List<int> ArchievmentsUnlocked { get => archievmentsUnlocked; set => archievmentsUnlocked = value; }
    public Settings SettingsData { get => settingsData; set => settingsData = value; }
    public bool IsAutoSave { get => isAutoSave; set => isAutoSave = value; }
    public bool IsCorrupted { get => isCorrupted; set => isCorrupted = value; }
    public int BackupSaveID { get => backupSaveID; set => backupSaveID = value; }
    public string SaveFilePath { get => saveFilePath; set => saveFilePath = value; }

}