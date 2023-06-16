using System;

namespace PokemonBattle1
{
    class Oshawott : Pokemon
    {
        public Oshawott() : base("Oshawott", "Water", "Grass") { }

        public override void battleCry()
        {
            Console.WriteLine("Oshawott used battlecry!");
            Console.WriteLine("Oshawott!");
        }
    }
}
