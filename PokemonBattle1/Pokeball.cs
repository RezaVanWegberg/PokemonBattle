using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PokemonBattle1
{
    class Pokeball
    {
        public Pokemon pokemon;
        public bool isEmpty;

        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            isEmpty = false;
        }

        public void Throw(string name)
        {
            Console.WriteLine(pokemon.name + " got released!");
            Thread.Sleep(300);
            pokemon.battleCry();
        }




    }
}

