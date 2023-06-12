using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle1
{
    class Trainer
    {
        public List<Pokeball> belt;
        public string name;

        public Trainer(string name)
        {
            this.name = name;
            belt = new List<Pokeball>();
        }

        public void givePokeball(Pokeball pokeball)
        {
            belt.Add(pokeball);
        }

        public void throwPokeball(int number, string name)
        {
            Console.WriteLine(name + " throws a pokeball");
            Thread.Sleep(300);
            
            Pokeball pokeball = belt[number];

            pokeball.Thrown();
            
        }

        public void returnToPokeball(int number, string name)
        {
            Console.WriteLine(name + " returns " + belt[number].pokemon.name);

            Pokeball pokeball = belt[number];

            pokeball.Close();
        }
    }

}
