namespace Orkagochi;

public class GameTime
{
    // General Info
    private DateTime currentTime;
    private DateTime startTime;
    private TimeSpan elapsedTime;
    private int dayCycle;

    // Time mechanics
    private float timeScale;
    private bool isDaytime;
    private int nightCycleDuration;
    private int dayCycleDuration;

    // Time-based events
    private int timeToNextEvent;
    private int eventTimer;
    private DateTime seasonChangeTime;
    private int seasonDuration;

    // Game counter & progress
    private TimeSpan currentLevelTime;
    private TimeSpan totalPlayTime;
    private Dictionary<string, TimeSpan> timeSpentPerTask = new();

    // User interaction
    private TimeSpan pauseTime;
    private bool timePaused;

    // In-Game Week
    private int weekNumber;
    private int monthNumber;
    private int yearNumber;

    // Event & Game mechanics
    private TimeSpan eventCooldown;
    private TimeSpan timeSinceLastInteraction;

    // More time factors
    private TimeSpan maxRealTimeDuration;
    private bool speedUpTime;

    public DateTime CurrentTime => currentTime;
    public DateTime StartTime => startTime;
    public TimeSpan ElapsedTime => elapsedTime;
    public int DayCycle => dayCycle;
    public float TimeScale => timeScale;
    public bool IsDaytime => isDaytime;
    public int NightCycleDuration => nightCycleDuration;
    public int DayCycleDuration => dayCycleDuration;
    public int TimeToNextEvent => timeToNextEvent;
    public int EventTimer => eventTimer;
    public DateTime SeasonChangeTime => seasonChangeTime;
    public int SeasonDuration => seasonDuration;
    public TimeSpan CurrentLevelTime => currentLevelTime;
    public TimeSpan TotalPlayTime => totalPlayTime;
    public TimeSpan PauseTime => pauseTime;
    public bool TimePaused => timePaused;
    public int WeekNumber => weekNumber;
    public int MonthNumber => monthNumber;
    public int YearNumber => yearNumber;
    public TimeSpan EventCooldown => eventCooldown;
    public TimeSpan TimeSinceLastInteraction => timeSinceLastInteraction;
    public TimeSpan MaxRealTimeDuration => maxRealTimeDuration;
    public bool SpeedUpTime => speedUpTime;
}
