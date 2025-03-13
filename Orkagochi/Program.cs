namespace Orkagochi;

class Program
{
    static void Main(string[] args)
    {
        //Orka myOrka = new Orka("Willy", "Rot", "Schwarz", "Male", 14, 5000, 6.5, 2.3, 1.4, 2, 20, 3, 2);
        //GameTime gameTime = new GameTime(myOrka);

        //gameTime.StartGameLoop(); // Startet die Game-Loop

        Menu menu = new Menu();
        menu.ShowMainMenu();// Spieler kann interagieren
        //var orka = new Orka("Willy","Rot","Schwarz","Male",14,5000,6.5,2.3,1.4,2,20,3,2);
        //var food = new Food();
        //var shop = new Shop();
        //var location = new Location();
        //var toy = new Toys();
        //var gameTime = new GameTime();
        //var junk = new Junk();
        //
        //Console.WriteLine("Orkagochi");
        //Console.WriteLine(orka.ToString(3));


    }
}