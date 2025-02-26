namespace Orkagochi;

class Program
{
    static void Main(string[] args)
    {
        Orka orka = new Orka();
        orka.Name = "Willy";
        orka.Age = 12;
        
        Console.WriteLine(orka.Age);
    }
}