using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PokemonBattle1
{
    class Pokeball
    {
        public Pokemon pokemon;
        public bool isEmpty;
        public bool isOpen;

        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            isEmpty = false;
            isOpen = false;
        }

        public Pokemon Thrown()
        {
            Console.WriteLine(pokemon.name + " got released!");
            Thread.Sleep(300);
            pokemon.battleCry();


            isEmpty = true;
            isOpen = true;

            return (pokemon);
        }

        public void Close() 
        {
            isEmpty = false;
            isOpen = false;

        }




    }
}

