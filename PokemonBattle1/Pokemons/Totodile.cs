using System;

namespace PokemonBattle1
{
    class Totodile : Pokemon
    {
        public Totodile() : base("Totodile", "Water", "Grass") { }

        public override void battleCry()
        {
            Console.WriteLine("Totodile used battlecry!");
            Console.WriteLine("Totodile!");
        }
    }
}
