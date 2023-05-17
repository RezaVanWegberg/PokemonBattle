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
    Console.WriteLine("Enter a name for trainer 1");
    string userInput = Console.ReadLine();

    Trainer trainer1 = new Trainer(userInput);
    trainer1.givePokeball(new Pokeball(new Charmander("Charmander 1", "Fire", "Water")));

    Console.WriteLine("Enter a name for trainer 2");
    string userInput2 = Console.ReadLine();

    Trainer trainer2 = new Trainer(userInput2);
    trainer2.givePokeball(new Pokeball(new Charmander("Charmander 2", "Fire", "Water")));

    trainer1.throwPokeball(0);
    trainer2.throwPokeball(0);



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

    } else
    {
        StartOver &= false;
    }
}

class Pokeball
{
    public Charmander charmander;
    
    public Pokeball(Charmander charmander)
    {
        this.charmander = charmander;

        Console.WriteLine("check dat ie er in zit :" + charmander.name); //test om te kijken of de pokemon in de pokebal zit

    }

    public void openPokeball(List<Charmander> pokemon)       //werkt nog niet
    {
        Console.WriteLine(pokemon[0].name + " came out!");
        pokemon.RemoveAt(0);
    }
}

class Trainer {
    public List<Pokeball> belt;
    public string name;

    public Trainer(string input)
    {
        name = input;
        belt = new List<Pokeball>();
    }

    public void givePokeball(Pokeball pokeball)
    {
        belt.Add(pokeball);
    }

    public void throwPokeball(int number)
    {
        belt[number].charmander.battleCry();
        /*belt.Remove(belt[number]);*/
    }
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

