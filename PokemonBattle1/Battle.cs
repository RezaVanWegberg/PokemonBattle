using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle1
{
    class Battle
    {
        public Battle()
        { 
        }
        public GameState battle(Pokemon pokemon1, Pokemon pokemon2) 
        {
            if (pokemon1.type == pokemon2.weakness)
            {
                Console.WriteLine("");
                Console.WriteLine(pokemon1.name + " wins, trainer1 won");
                Console.WriteLine("");
                return GameState.Trainer1;
            }
            else if (pokemon2.type == pokemon1.weakness)
            {
                Console.WriteLine("");
                Console.WriteLine(pokemon2.name + " wins, trainer2 won");
                Console.WriteLine("");
                return GameState.Trainer2;
            }

            else if (pokemon1.type == pokemon2.type)
            {
                Console.WriteLine("");
                Console.WriteLine("it's a draw");
                Console.WriteLine("");
                return GameState.Draw;
            }
            else
            {
                Console.WriteLine("");
                return GameState.Draw;
                Console.WriteLine("");
            }
        } 
    }

}
