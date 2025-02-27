namespace Orkagochi;

public class Menu
{
    
    // General Info
    
    private string name;
    private bool active;
    private int currentMenu;
    private string previousMenu;
    
    // Menu structure & Navigation
    private List<string> menuOptions;
    private Dictionary<string, List<string>> subMenu;
    private bool canNavigateBack;
    private string selectedOption;
    private int manuDepth;
    
    // Menu layout
    private bool isFullScreen;
    private string menuPosition;
    private string menuTheme;
    private float menuAnimationSpeed;
    
    // Userinteraction
    private bool isNavigable;
    private string confirmKey;
    private string backKey;
    private int scrollSpeed;
    private DateTime lastInteractionTime;
    
    // specific menu options
    private bool hasSound;
    private int musicVolume;
    private bool showTooltips;
    private string currentTooltip;
    private TimeSpan autoCloseTime;
    
    // Connections
    private GameTime linkedGameTime;
    private Inventory linkedInventory;
    private Settings linkedSettings;
    
    // GET & SET
    public string Name { get => name; set => name = value; }
    public bool Active { get => active; set => active = value; }
    public int CurrentMenu { get => currentMenu; set => currentMenu = value; }
    public string PreviousMenu { get => previousMenu; set => previousMenu = value; }
    public List<string> MenuOptions { get => menuOptions; set => menuOptions = value; }
    public Dictionary<string, List<string>> SubMenu { get => subMenu; set => subMenu = value; }
    public bool CanNavigateBack { get => canNavigateBack; set => canNavigateBack = value; }
    public string SelectedOption { get => selectedOption; set => selectedOption = value; }
    public int ManuDepth { get => manuDepth; set => manuDepth = value; }
    public bool IsFullScreen { get => isFullScreen; set => isFullScreen = value; }
    public string MenuPosition { get => menuPosition; set => menuPosition = value; }
    public string MenuTheme { get => menuTheme; set => menuTheme = value; }
    public float MenuAnimationSpeed { get => menuAnimationSpeed; set => menuAnimationSpeed = value; }
    public bool IsNavigable { get => isNavigable; set => isNavigable = value; }
    public string ConfirmKey { get => confirmKey; set => confirmKey = value; }
    public string BackKey { get => backKey; set => backKey = value; }
    public int ScrollSpeed { get => scrollSpeed; set => scrollSpeed = value; }
    public DateTime LastInteractionTime { get => lastInteractionTime; set => lastInteractionTime = value; }
    public bool HasSound { get => hasSound; set => hasSound = value; }
    public int MusicVolume { get => musicVolume; set => musicVolume = value; }
    public bool ShowTooltips { get => showTooltips; set => showTooltips = value; }
    public string CurrentTooltip { get => currentTooltip; set => currentTooltip = value; }
    public TimeSpan AutoCloseTime { get => autoCloseTime; set => autoCloseTime = value; }
    public GameTime LinkedGameTime { get => linkedGameTime; set => linkedGameTime = value; }
    public Inventory LinkedInventory { get => linkedInventory; set => linkedInventory = value; }
    public Settings LinkedSettings { get => linkedSettings; set => linkedSettings = value; }
    
    // Methods
    
    
    
    
    
}