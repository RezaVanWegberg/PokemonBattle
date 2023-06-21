using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PokemonBattle1
{
    class Pokeball
    {
        private Pokemon pokemon;
        private bool isEmpty;
        private bool isOpen;

        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            isEmpty = false;
            isOpen = false;
        }

        public Pokemon Pokemon
        {
            get { return pokemon; }
        }
        public bool IsEmpty
        {
            get { return isEmpty; }
        }

        public bool IsOpen
        {
            get { return isOpen; }
        }

        public Pokemon Thrown()
        {
            Console.WriteLine(pokemon.Name + " got released!");
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

