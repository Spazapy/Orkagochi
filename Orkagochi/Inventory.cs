namespace Orkagochi;

public class Inventory
{
    
    // General inventory info
    private string owner;
    private int maxCapacity;
    private int currentCapacity;
    private int weightLimit;
    private int currentWeight;
    private bool isFull;
    
    // item category
    private Dictionary<int,int> foodItems;
    private List<int> toys;
    private List<int> junkItems;
    private List<int> specialItems;
    private Dictionary<int, int> consumables;
    
    // item management & interaction
    private int selectedItem;
    private int lastUsedItem;
    private int lastCollectedItem;
    private List<int> tradeableItems;
    private List<int> favoriteItems;
    private bool isItemEquipped;
    
    // Inventory functions & status properties
    private bool autoSort;
    private string sortOrder;
    private bool isTradeable;
    private bool isDroppable;
    private string inventoryState;
    
    // GET & SET
    public string Owner { get => owner; set => owner = value; }
    public int MaxCapacity { get => maxCapacity; set => maxCapacity = value; }
    public int CurrentCapacity { get => currentCapacity; set => currentCapacity = value; }
    public int WeightLimit { get => weightLimit; set => weightLimit = value; }
    public int CurrentWeight { get => currentWeight; set => currentWeight = value; }
    public bool IsFull { get => isFull; set => isFull = value; }
    public Dictionary<int,int> FoodItems { get => foodItems; set => foodItems = value; }
    public List<int> Toys { get => toys; set => toys = value; }
    public List<int> JunkItems { get => junkItems; set => junkItems = value; }
    public List<int> SpecialItems { get => specialItems; set => specialItems = value; }
    public Dictionary<int, int> Consumables { get => consumables; set => consumables = value; }
    
    public int SelectedItem { get => selectedItem; set => selectedItem = value; }
    public int LastUsedItem { get => lastUsedItem; set => lastUsedItem = value; }
    public int LastCollectedItem { get => lastCollectedItem; set => lastCollectedItem = value; }
    public List<int> TradeableItems { get => tradeableItems; set => tradeableItems = value; }
    public List<int> FavoriteItems { get => favoriteItems; set => favoriteItems = value; }
    public bool IsItemEquipped { get => isItemEquipped; set => isItemEquipped = value; }
    public bool AutoSort { get => autoSort; set => autoSort = value; }
    public string SortOrder { get => sortOrder; set => sortOrder = value; }
    public bool IsTradeable { get => isTradeable; set => isTradeable = value; }
    public bool IsDroppable { get => isDroppable; set => isDroppable = value; }
    public string InventoryState { get => inventoryState; set => inventoryState = value; }

}