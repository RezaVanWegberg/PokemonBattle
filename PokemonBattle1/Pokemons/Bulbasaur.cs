using System;

namespace PokemonBattle1
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur() : base("Bulbasaur", "Grass", "Fire") { }

        public override void battleCry()
        {
            Console.WriteLine("Bulbasaur used battlecry!");
            Console.WriteLine("Bulbasaur!");
        }
    }
}
