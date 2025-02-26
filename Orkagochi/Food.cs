using System.Globalization;

namespace Orkagochi;

public class Food
{
    private Dictionary<int, string> food = new Dictionary<int, string>
    {
        {1, "Lachs"},
        {2, "Hering"},
        {3, "Makrele"},
        {4,"Kabeljau"},
        {5,"Seehund"},
        {7, "Seelöwe"},
        {8, "Robbe"},
        {9, "Schweinswal"},
        {10, "Delfin"},
        {11, "Beluga"},
        {12, "Grauwalkalb"},
        {13, "Risenkalmar"},
        {14, "Oktopuss"},
        {15, "Pinguin"},
        {16, "Möwe"},
        {17,"Meeresschildkröte"},
        {18, "Rochen"}
        
    };

    private Dictionary<int, int> consume = new Dictionary<int, int>()
    {
        {1, 50},    // Lachs
        {2, 40},    // Hering
        {3, 35},    // Makrele
        {4, 30},    // Kabeljau
        {5, 100},   // Seehund
        {7, 120},   // Seelöwe
        {8, 100},   // Robbe
        {9, 150},   // Schweinswal
        {10, 160},  // Delfin
        {11, 180},  // Beluga
        {12, 250},  // Grauwalkalb
        {13, 80},   // Riesenkalmar
        {14, 45},   // Oktopus
        {15, 70},   // Pinguin
        {16, 20},   // Möwe
        {17, 60},   // Meeresschildkröte
        {18, 90}    // Rochen

    };
}