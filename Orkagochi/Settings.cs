namespace Orkagochi;

public class Settings
{
    
    // General Settings
    private string language;
    private string difficulty;
    private bool autoSave;
    private int saveSlot;
    private bool showTutorial;
    private bool isPaused;
    
    // graphic settings
    private string resolution;
    private bool fullscreen;
    private bool vSync;
    private int frameRateLimit;
    private float brightness;
    private float contrast;
    private string graphicsQuality;
    private bool particelEffect;
    private string shadowQuality;
    
    // Audio settings
    private int masterVolume;
    private int musicVolume;
    private int soundEffectVolume;
    private int voiceVolume;
    private bool muteAll;
    private bool use3DSoundEffect;
    
    // Movement Settings
    private string controlScheme;
    private Dictionary<string, string> keyBindings;
    private bool invertYAxis;
    private float sensitivity;
    private bool vibration;
    
    // gameplay Settings

    private bool realisticMode;
    private bool dayNightCycle;
    private bool weatherEffects;
    private float orcaAgingSpeed;
    private float energyConsumptionRate;
    private float foodDecayRate;
    private float hungerRate;
    
    // other settings
    private bool showSubtitles;
    private bool tooltipsEnabled;
    private float uiOpactiy;
    private bool showMinimap;
    private float hudScale;
    private string saveGamePath;
    
    public string Language { get => language; set => language = value; }
    public string Difficulty { get => difficulty; set => difficulty = value; }
    public bool AutoSave { get => autoSave; set => autoSave = value; }
    public int SaveSlot { get => saveSlot; set => saveSlot = value; }
    public bool ShowTutorial { get => showTutorial; set => showTutorial = value; }
    public bool IsPaused { get => isPaused; set => isPaused = value; }
    public string Resolution { get => resolution; set => resolution = value; }
    public bool Fullscreen { get => fullscreen; set => fullscreen = value; }
    public bool VSync { get => vSync; set => vSync = value; }
    public int FrameRateLimit { get => frameRateLimit; set => frameRateLimit = value; }
    public float Brightness { get => brightness; set => brightness = value; }
    public float Contrast { get => contrast; set => contrast = value; }
    public string GraphicsQuality { get => graphicsQuality; set => graphicsQuality = value; }
    public bool ParticelEffect { get => particelEffect; set => particelEffect = value; }
    public string ShadowQuality { get => shadowQuality; set => shadowQuality = value; }
    public int MasterVolume { get => masterVolume; set => masterVolume = value; }
    public int MusicVolume { get => musicVolume; set => musicVolume = value; }
    public int SoundEffectVolume { get => soundEffectVolume; set => soundEffectVolume = value; }
    public int VoiceVolume { get => voiceVolume; set => voiceVolume = value; }
    public bool MuteAll { get => muteAll; set => muteAll = value; }
    public bool Use3DSoundEffect { get => use3DSoundEffect; set => use3DSoundEffect = value; }
    public string ControlScheme { get => controlScheme; set => controlScheme = value; }
    public Dictionary<string, string> KeyBindings { get => keyBindings; set => keyBindings = value; }
    public bool InvertYAxis { get => invertYAxis; set => invertYAxis = value; }
    public float Sensitivity { get => sensitivity; set => sensitivity = value; }
    public bool Vibration { get => vibration; set => vibration = value; }
    public bool RealisticMode { get => realisticMode; set => realisticMode = value; }
    public bool DayNightCycle { get => dayNightCycle; set => dayNightCycle = value; }
    public bool WeatherEffect { get => weatherEffects; set => weatherEffects = value; }
    public float OrcaAgingSpeed { get => orcaAgingSpeed; set => orcaAgingSpeed = value; }
    public float EnergyConsumptionRate { get => energyConsumptionRate; set => energyConsumptionRate = value; }
    public float FoodDecayRate { get => foodDecayRate; set => foodDecayRate = value; }
    public float HungerRate { get => hungerRate; set => hungerRate = value; }
    public bool ShowSubtitles { get => showSubtitles; set => showSubtitles = value; }
    public bool TooltipsEnabled { get => tooltipsEnabled; set => tooltipsEnabled = value; }
    public float UiOpacity { get => uiOpactiy; set => uiOpactiy = value; }
    public bool ShowMinimap { get => showMinimap; set => showMinimap = value; }
    public float HudScale { get => hudScale; set => hudScale = value; }
    public string SaveGamePath { get => saveGamePath; set => saveGamePath = value; }
    
}