using System;

namespace PokemonBattle1
{
    class Squirtle : Pokemon
    {
        public Squirtle() : base("Squirtle", "Fire", "Water") { }

        public override void battleCry()
        {
            Console.WriteLine("Squirtle used battlecry!");
            Console.WriteLine("Squirtle!");
        }
    }
}
