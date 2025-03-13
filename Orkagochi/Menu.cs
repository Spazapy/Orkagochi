namespace Orkagochi;

public class Menu
{
    public static Orka orka;
    private GameTime gameTime;
    
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
    public void ShowMainMenu()
    {
        Console.WriteLine("Willkommen im Orkagochi Spiel!");
        Console.WriteLine("1. Neues Spiel");
        Console.WriteLine("2. Spiel Laden");
        Console.WriteLine("3. Einstellungen");
        Console.WriteLine("4. Beenden");
        Console.Write("Wähle eine Option: ");
        
        char option = Console.ReadKey().KeyChar;
        Console.Clear();
        
        SelectMenuOption(option);
    }
    
    public void SelectMenuOption(char option)
    {
        switch(option)
        {
            case '1':
                StartNewGame();
                break;
            case '2':
                LoadGame();
                break;
            case '3':
                OpenSettings();
                break;
            case '4':
                ExitGame();
                break;
            default:
                Console.WriteLine("Ungültige Option! Bitte versuche es erneut.");
                ShowMainMenu(); // Menü erneut anzeigen
                break;
        }
    }

    public void StartNewGame()
    {
        Console.WriteLine("Neues Spiel wird gestartet....");
        string name = prompt<string>("Wie möchtest du deinen Orka bennen? ");
        string baseColor = prompt<string>("Welche Hauptfarbe hat dein Orka?");
        string patternColor = prompt<string>("Welche Musterfarbe hat dein Orka?");
        string gender = prompt<string>("Ist dein Orka Männlich oder Weiblich?");
        int age = prompt<int>("Wie alt ist dein Orka?");
        int weight = prompt<int>("Wie viel wiegt dein Orka?");
        double lenght = prompt<double>("Wie lang ist dein Orka?");
        double height = prompt<double>("Wie hoch ist dein Orka?");
        double width = prompt<double>("Wie breit ist dein Orka?");
        int finSize = prompt<int>("Was ist die Flossengröße deines Orkas?");
        int teethCount = prompt<int>("Wie viele zähne hat dein Orka?");
        int teethSize = prompt<int>("Welche Zahngröße hat dein Orka?");
        int blubberThickness = prompt<int>("Wie dick ist die Hautschicht deines Orka?");
        orka = new Orka(name, baseColor, patternColor, gender, age, weight, lenght, height, width, finSize,
            teethCount, teethSize, blubberThickness);
        Console.Clear();
        Console.WriteLine("Dein Orka wurde mit folgenden Attributen erstellt:");
        Console.WriteLine(orka.ToString());
        Ingame();

        
    }

    public void Ingame()
    {
        GameTime gameTime = new GameTime(orka);
        gameTime.StartGameLoop();
        while (orka.Health > 0)
        {
            Console.WriteLine("===== Orka-Status =====");
            Console.WriteLine($"Name: {orka.Name}, Gesundheit: {orka.Health}, Energie: {orka.Energy}, Hunger: {orka.Hunger}, Durst: {orka.Thirst}, Glück: {orka.Happiness}, Stress-Level: {orka.StressLevel}");
            Console.WriteLine("=======================");
            Thread.Sleep(1000);
            Console.Clear();
        }
        gameTime.StopGameLoop();
        Console.WriteLine($"{orka.Name} ist gestorben. Kehre zurück zum Hauptmenü");
        ShowMainMenu();
        
    }
    
    public generic prompt<generic>(string prompt)
    {
        Console.Write(prompt);
        return (generic)Convert.ChangeType(Console.ReadLine(), typeof(generic));
    }

    public void LoadGame()
    {
        Console.WriteLine("Speicherstand wird geladen...");
    }

    public void OpenSettings()
    {
        Console.WriteLine("Hier findest du nützliche Einstellungen, tob dich ruhig aus!");
    }

    public void ShowArchievments()
    {
        Console.WriteLine("Das sind aber eine menge Leistungen die du bis jetzt erbracht hast!");
    }

    public void ExitGame()
    {
        Console.WriteLine("Spiel wird Geschlossen");
    }

    
    
    
    
    
}