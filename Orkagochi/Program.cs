namespace Orkagochi;

class Program
{
    static void Main(string[] args)
    {
        var orka = new Orka("Willy","Rot","Schwarz",'M',14,5000,6.5,2.3,1.4,2,20,3,2);
        var food = new Food();
        var shop = new Shop();
        var location = new Location();
        var toy = new Toys();
        var gameTime = new GameTime();
        var junk = new Junk();
        
        Console.WriteLine("Orkagochi");
        Console.WriteLine($"Der Orka heißt {orka.Name}, ist vom Geschlecht {orka.Gender} seine Hauptfarbe ist {orka.BaseColor} und die Muster Farbe ist {orka.PatternColor} er ist nun {orka.Age} Jahre alt. Derzeitiges Level: {orka.Level}");
        Console.WriteLine();
        
        
    }
}