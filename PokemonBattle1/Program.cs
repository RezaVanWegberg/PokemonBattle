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

Console.WriteLine("Enter a name for charmander");
        string userInput = Console.ReadLine();
        Charmander myObj = new Charmander(userInput);
        Console.WriteLine("His name is " + myObj.name);

class Charmander
{
    public string name;
    public string type;
    public string weakness;

    public Charmander(string input)
    {
        name = input;
        type = "Fire";
        weakness = "Water";
    }
}