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
    
    // timebased events
    private int timeToNextEvent;
    private int eventTimer;
    private DateTime seasonChangeTime;
    private int seasonDuration;
    
    // gamecounter & progress
    private TimeSpan currentLevelTime;
    private TimeSpan totalPlayTime;
    private Dictionary<string, TimeSpan> timeSpentPerTask = new Dictionary<string, TimeSpan>()
    {
        
    };
    
    // userinteraction
    private TimeSpan pauseTime;
    private bool timePaused;
    
    // In-Game Week
    private int weekNumber;
    private int monthNumber;
    private int yearNumber;
    
    // Event&Game mechanics
    private TimeSpan eventCooldown;
    private TimeSpan timeSinceLastInteraction;
    
    // more time factors
    private TimeSpan maxRealTimeDuration;
    private bool speedUpTime;
    
    public DateTime CurrentTime { get { return currentTime; } }
    public DateTime StartTime { get { return startTime; } }
    public TimeSpan ElapsedTime { get { return elapsedTime; } }
    public int DayCycle { get { return dayCycle; } }
    public float TimeScale { get { return timeScale; } }
    public bool IsDaytime { get { return isDaytime; } }
    public int NightCycleDuration { get { return nightCycleDuration; } }
    public int DayCycleDuration { get { return dayCycleDuration; } }
    public int TimeToNextEvent { get { return timeToNextEvent; } }
    public int EventTimer { get { return eventTimer; } }
    public DateTime SeasonChangeTime { get { return seasonChangeTime; } }
    public int SeasonDuration { get { return seasonDuration; } }
    public TimeSpan CurrentLevelTime { get { return currentLevelTime; } }
    public TimeSpan TotalPlayTime { get { return totalPlayTime; } }
    public TimeSpan PauseTime { get { return pauseTime; } }
    public bool TimePaused { get { return timePaused; } }
    public int WeekNumber { get { return weekNumber; } }
    public int MonthNumber { get { return monthNumber; } }
    public int YearNumber { get { return yearNumber; } }
    public TimeSpan EventCooldown { get { return eventCooldown; } }
    public TimeSpan TimeSinceLastInteraction { get { return timeSinceLastInteraction; } }
    public TimeSpan MaxRealTimeDuration { get { return maxRealTimeDuration; } }
    public bool SpeedUpTime { get { return speedUpTime; } }
}