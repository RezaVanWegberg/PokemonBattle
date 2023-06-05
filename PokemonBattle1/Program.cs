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

                Trainer trainer1 = new Trainer(nameTrainer1);
                trainer1.givePokeball(new Pokeball(new Pokemon("Charmander", "Fire", "Water")));

                Console.WriteLine("Enter a name for trainer 2");
                string nameTrainer2 = Console.ReadLine();

                Trainer trainer2 = new Trainer(nameTrainer2);
                trainer2.givePokeball(new Pokeball(new Pokemon("Squirtle", "Fire", "Water")));

                trainer1.throwPokeball(0, nameTrainer1);
                trainer2.throwPokeball(0, nameTrainer2);
                trainer1.returnToPokeball(0, nameTrainer1);
                trainer2.returnToPokeball(0, nameTrainer2);


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