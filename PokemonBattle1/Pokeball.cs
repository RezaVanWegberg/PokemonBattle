using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle1
{
    class Pokeball
    {
        public Pokemon pokemon;

        public Pokeball(Pokemon charmander)
        {
            this.pokemon = charmander;

            /*Console.WriteLine("check dat ie er in zit :" + charmander.name); //test om te kijken of de pokemon in de pokebal zit
    */
        }

        /* public void openPokeball(List<Charmander> pokemon)       //werkt nog niet
         {
             Console.WriteLine(pokemon[0].name + " came out!");
             pokemon.RemoveAt(0);
         }*/

    }
}
