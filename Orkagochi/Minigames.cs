namespace Orkagochi;

public class Minigames
{
    
    // General Minigame infos
    private int gameID;
    private string name;
    private string gameType;
    private string description;
    private int difficultyLevel;
    
    // gameplay mechanics
    private int timeLimit;
    private bool hasTimeLimit;
    private int score;
    private int Highscore;
    private int rewardPoints;
    private bool hasBonusRound;
    private int currentStage;
    private int maxStage;
    
    // interaction & controls 
    private string controls;
    private bool isPaused;
    private bool isGameOver;
    private bool restartAvaible;
    private DateTime lastPlayed;
    private int playCount;
    
    // rewards & progress
    private List<int> earnedItems;
    private int earnedCurrency;
    private bool unlockableItems;
    private bool hasLeaderboard;
    private int playerRank;
    
    // graphic quality
    private string graphicsQuality;
    private bool soundEnabled;
    private bool musicEnabled;
    private bool vibrationEnabled;
    
    // GET & SET
    public int GameID { get => gameID; set => gameID = value; }
    public string Name { get => name; set => name = value; }
    public string GameType { get => gameType; set => gameType = value; }
    public string Description { get => description; set => description = value; }
    public int DifficultyLevel { get => difficultyLevel; set => difficultyLevel = value; }
    public int TimeLimit { get => timeLimit; set => timeLimit = value; }
    public bool HasTimeLimit { get => hasTimeLimit; set => hasTimeLimit = value; }
    public int Score { get => score; set => score = value; }
    public int HighScore { get => Highscore; set => Highscore = value; }
    public int RewardPoints { get => rewardPoints; set => rewardPoints = value; }
    public bool HasBonusRound { get => hasBonusRound; set => hasBonusRound = value; }
    public int CurrentStage { get => currentStage; set => currentStage = value; }
    public int MaxStage { get => maxStage; set => maxStage = value; }
    public string Controls { get => controls; set => controls = value; }
    public bool IsPaused { get => isPaused; set => isPaused = value; }
    public bool IsGameOver { get => isGameOver; set => isGameOver = value; }
    public bool RestartAvaible { get => restartAvaible; set => restartAvaible = value; }
    public DateTime LastPlayed { get => lastPlayed; set => lastPlayed = value; }
    public int PlayCount { get => playCount; set => playCount = value; }
    public List<int> EarnedItems { get => earnedItems; set => earnedItems = value; }
    public int EarnedCurrency { get => earnedCurrency; set => earnedCurrency = value; }
    public bool UnlockableItems { get => unlockableItems; set => unlockableItems = value; }
    public bool HasLeaderboard { get => hasLeaderboard; set => hasLeaderboard = value; }
    public int PlayerRank { get => playerRank; set => playerRank = value; }
    public string GraphicsQuality { get => graphicsQuality; set => graphicsQuality = value; }
    public bool SoundEnabled { get => soundEnabled; set => soundEnabled = value; }
    public bool MusicEnabled { get => musicEnabled; set => musicEnabled = value; }
    public bool VibrationEnabled { get => vibrationEnabled; set => vibrationEnabled = value; }
    
}