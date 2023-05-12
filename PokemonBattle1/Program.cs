using System.Runtime.InteropServices;

class Charmander
{
    public string name;
    public string type;
    public string weakness;

    public Charmander()
    {
        name = Console.ReadLine();
        type = "Fire";
        weakness = "Water";
    }
    static void Main(string[] args)
    {
        Charmander myObj = new Charmander();
        Console.WriteLine("His name is " + myObj.name);
    }
}