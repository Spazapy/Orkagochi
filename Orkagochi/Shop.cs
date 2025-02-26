namespace Orkagochi;

public class Shop
{
    
    // General Info
    private string name;
    private string location;
    private string currency;
    private string openingHours;
    
    // Shop Inventory
    
    private List<string> products = new List<string>()
    {
        
    };
    
    private Dictionary<string, int> productStock = new Dictionary<string, int>()
    {
        
    };

    private Dictionary<string, int> productPrices = new Dictionary<string, int>()
    {

    };

    private Dictionary<string, string> productType = new Dictionary<string, string>()
    {

    };
    
    // Buy options
    private int balance;

    private Dictionary<string, int> discounts = new Dictionary<string, int>()
    {

    };
    private List<string> purchableItems = new List<string>();
    
    
    // product categories
    private List<string> foodItems = new List<string>()
    {
        
    };
    private List<string> toyItems = new List<string>()
    {
        
    };
    private List<string> medicineItems = new List<string>()
    {
        
    };
    private List<string> upgradeItems = new List<string>()
    {
        
    };
    
    // events
    private bool salesEvent;
    private Dictionary<string, Tuple<int, DateTime>> limitedTimeOffer = new Dictionary<string, Tuple<int, DateTime>>()
    {
        
    };

    private Dictionary<string, int> specialRewards = new Dictionary<string, int>()
    {

    };
    
    // Userinteraction & Buymanagment
    private bool canPurchase;
    private List<string> transactionHistory = new List<string>()
    {
        
    };
    private bool confirmPurchase;
    
    // GET & SET
    public string Name { get => name; set => name = value; }
    public string Location { get => location; set => location = value; }
    public string Currency { get => currency; set => currency = value; }
    public string OpeningHours { get => openingHours; set => openingHours = value; }
    public List<string> Products { get => products; set => products = value; }
    public Dictionary<string, int> ProductStock { get => productStock; set => productStock = value; }
    public Dictionary<string, int> ProductPrices { get => productPrices; set => productPrices = value; }
    public Dictionary<string, string> ProductType { get => productType; set => productType = value; }
    public int Balance { get => balance; set => balance = value; }
    public Dictionary<string, int> Discounts { get => discounts; set => discounts = value; }
    public List<string> PurchableItems { get => purchableItems; set => purchableItems = value; }
    public List<string> FoodItems { get => foodItems; set => foodItems = value; }
    public List<string> ToyItems { get => toyItems; set => toyItems = value; }
    public List<string> MedicineItems { get => medicineItems; set => medicineItems = value; }
    public List<string> UpgradeItems { get => upgradeItems; set => upgradeItems = value; }
    public bool SalesEvent { get => salesEvent; set => salesEvent = value; }
    public bool ConfirmPurchase { get => confirmPurchase; set => confirmPurchase = value; }
    
    // Methods

    public void buyItem(string item, int quantity)
    {
        
    }

    public void updateStock(string item, int quantity)
    {
        
    }

    public void applyDiscount(string item, int quantity)
    {
        
    }

    public bool checkAvailbility(string item, int quantity)
    {
        return true;
    }
}