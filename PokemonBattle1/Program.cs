using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

bool GameStart = true;
while(GameStart)
{
    Console.WriteLine("Start game? answer with Y/N");
    string VraagGameStart = Console.ReadLine();
    if (VraagGameStart == "Y")
    {
        GameStart = false;
    }
}

bool StartOver = true;
while (StartOver)
{
    Console.WriteLine("Enter a name for charmander");
    string userInput = Console.ReadLine();
    Charmander myCharmander = new Charmander(userInput, "Fire", "Water");
    
    Pokeball greatBall = new Pokeball(myCharmander.name);

    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(1000);
        myCharmander.battleCry();
    }

    Console.WriteLine("Start over? answer with Y/N");
    string VraagStartOver = Console.ReadLine();
    if (VraagStartOver == "Y")
    {
        StartOver = true;

    }
    else if (VraagStartOver == "N")
    {
        StartOver = false;
        Console.WriteLine("test");
        Console.WriteLine(greatBall.CharmanderInPokeball.name);

    }
}

class Pokeball
{
    public Pokeball(string pokemon)
    {
        List<string> pokeballList = new List<string>(1);
        pokeballList.Add(pokemon);
        Console.WriteLine("check dat ie er in zit" + pokeballList[0]); //test om te kijken of de pokemon in de pokebal zit

    }

    public Charmander CharmanderInPokeball { get; set; }
}


class Charmander
{
    public string name;
    public string type;
    public string weakness;

    public Charmander(string inputName, string inputType, string inputWeakness)
    {
        name = inputName;
        type = inputType;
        weakness = inputWeakness;
    }

    public void battleCry()
    {
        Console.WriteLine(name + " used battlecry!");
        Console.WriteLine(name + "!");
    }
}

