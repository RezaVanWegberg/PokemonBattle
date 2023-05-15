using System.Runtime.InteropServices;

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
    Charmander myObj = new Charmander(userInput, "Fire", "Water");
    Console.WriteLine("His name is " + myObj.name);

    Console.WriteLine("Start over? answer with Y/N");
    string VraagStartOver = Console.ReadLine();
    if (VraagStartOver == "Y")
    {
        StartOver = true;
    }
    else if (VraagStartOver == "N")
    {
        StartOver = false;
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
}


