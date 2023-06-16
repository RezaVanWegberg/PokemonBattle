using System;

namespace PokemonBattle1
{
    class Squirtle : Pokemon
    {
        public Squirtle() : base("Squirtle", "Water", "Grass") { }

        public override void battleCry()
        {
            Console.WriteLine("Squirtle used battlecry!");
            Console.WriteLine("Squirtle!");
        }
    }
}
