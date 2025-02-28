namespace Orkagochi;

public class AudioManager
{
    
    // General Audio Settings
    private float masterVolume;
    private float musicVolume;
    private float sfxVolume;
    private float voiceVolume;
    private float ambientVolume;
    private bool isMuted;
    
    // Soundcategory & controls
    private string currentMusic;
    private bool isMusicLooping;
    private bool isSFXEnabled;
    private bool is3DAudioEnabled;
    
    // audio source & effects
    private List<string> ambientsSounds;
    private List<string> orcaSounds;
    private List<string> musicSounds;
    private List<string> sfxSounds;
    private List<string> voiceSounds;
    private List<string> uiSounds;
    
    // Audio Managing and Saving
    private string audioPreset;
    private Dictionary<string, float> savedAudioSettings;
    private string lastPlayedSound;
    private string lastPlayedMusic;
    
    // GET & SET
    public float MasterVolume { get => MasterVolume; set => MasterVolume = value; }
    public float MusicVolume { get => MusicVolume; set => MusicVolume = value; }
    public float SFXVolume { get => SFXVolume; set => SFXVolume = value; }
    public float VoiceVolume { get => VoiceVolume; set => VoiceVolume = value; }
    public float AmbientVolume { get => AmbientVolume; set => AmbientVolume = value; }
    public bool IsMuted { get => IsMuted; set => IsMuted = value; }
    public string CurrentMusic { get => CurrentMusic; set => CurrentMusic = value; }
    public bool IsMusicLooping { get => IsMusicLooping; set => IsMusicLooping = value; }
    public bool IsSFXEnabled { get => IsSFXEnabled; set => IsSFXEnabled = value; }
    public bool Is3DAudioEnabled { get => Is3DAudioEnabled; set => Is3DAudioEnabled = value; }
    public List<string> AmbientSounds { get => AmbientSounds; set => AmbientSounds = value; }
    public List<string> OrcaSounds { get => OrcaSounds; set => OrcaSounds = value; }
    public List<string> MusicSounds { get => MusicSounds; set => MusicSounds = value; }
    public List<string> SfxSounds { get => SfxSounds; set => SfxSounds = value; }
    public List<string> VoiceSounds { get => VoiceSounds; set => VoiceSounds = value; }
    public List<string> UiSounds { get => UiSounds; set => UiSounds = value; }
    public string AudioPreset { get => audioPreset; set => audioPreset = value; }
    public Dictionary<string, float> SavedAudioSettings { get => savedAudioSettings; set => savedAudioSettings = value; }
    public string LastPlayedSound { get => lastPlayedSound; set => lastPlayedSound = value; }
    public string LastPlayedMusic { get => lastPlayedMusic; set => lastPlayedMusic = value; }

}