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
                trainer1.givePokeball(new Pokeball(new Charmander()));
                trainer1.givePokeball(new Pokeball(new Charmander()));
                trainer1.givePokeball(new Pokeball(new Chikorita()));
                trainer1.givePokeball(new Pokeball(new Squirtle()));
                trainer1.givePokeball(new Pokeball(new Torchic()));
                trainer1.givePokeball(new Pokeball(new Oshawott()));
                trainer1.givePokeball(new Pokeball(new Snivy()));

                Trainer trainer2 = new Trainer(nameTrainer2);
                trainer2.givePokeball(new Pokeball(new Bulbasaur()));
                trainer2.givePokeball(new Pokeball(new Totodile()));
                trainer2.givePokeball(new Pokeball(new Cyndaquil()));
                trainer2.givePokeball(new Pokeball(new Rowlet()));
                trainer2.givePokeball(new Pokeball(new Fennekin()));
                trainer2.givePokeball(new Pokeball(new Mudkip()));


                Arena arena = new Arena(trainer1, trainer2);
                arena.arenaBattle();


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