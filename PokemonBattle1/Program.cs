using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace PokemonBattle1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool GameStart = true;
            while (GameStart)
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
                string nameTrainer1 = Console.ReadLine();

                Console.WriteLine("Enter a name for trainer 2");
                string nameTrainer2 = Console.ReadLine();

                Trainer trainer1 = new Trainer(nameTrainer1);
                trainer1.givePokeball(new Pokeball(new Pokemon("Charmander", "Fire", "Water")));
                trainer1.givePokeball(new Pokeball(new Pokemon("Bulbasaur", "Grass", "Fire")));
/*                trainer1.givePokeball(new Pokeball(new Pokemon("Mudkip", "Water", "Grass")));
                trainer1.givePokeball(new Pokeball(new Pokemon("Chimchar", "Fire", "Water")));
                trainer1.givePokeball(new Pokeball(new Pokemon("Chespin", "Grass", "Fire")));
                trainer1.givePokeball(new Pokeball(new Pokemon("Froakie", "Water", "Grass")));*/

                Trainer trainer2 = new Trainer(nameTrainer2);
                trainer2.givePokeball(new Pokeball(new Pokemon("Squirtle", "Water", "Grass")));
                trainer2.givePokeball(new Pokeball(new Pokemon("Torchic", "Fire", "Water")));
/*                trainer2.givePokeball(new Pokeball(new Pokemon("Treecko", "Grass", "Fire")));
                trainer2.givePokeball(new Pokeball(new Pokemon("Piplup", "Water", "Grass")));
                trainer2.givePokeball(new Pokeball(new Pokemon("Tepig", "Fire", "Water")));
                trainer2.givePokeball(new Pokeball(new Pokemon("Snivy", "Grass", "Fire")));*/

                for (int i = 0; i < trainer1.belt.Count || i < trainer2.belt.Count; i++)
                {

                    trainer1.throwPokeball(i, nameTrainer1);
                    Thread.Sleep(600);
                    trainer2.throwPokeball(i, nameTrainer2);
                    Thread.Sleep(600);
                    trainer1.returnToPokeball(i, nameTrainer1);
                    Thread.Sleep(600);
                    trainer2.returnToPokeball(i, nameTrainer2);
                    Thread.Sleep(600);
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

                }
                else
                {
                    StartOver &= false;
                }
            }
        }
    }
}