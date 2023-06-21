using System;

namespace PokemonBattle1
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur() : base("Bulbasaur", Element.Grass, Element.Fire) { }

        public override void battleCry()
        {
            Console.WriteLine("Bulbasaur used battlecry!");
            Console.WriteLine("Bulbasaur!");
        }
    }
}
