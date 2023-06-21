using System;

namespace PokemonBattle1
{
    class Squirtle : Pokemon
    {
        public Squirtle() : base("Squirtle", Element.Water, Element.Grass) { }

        public override void battleCry()
        {
            Console.WriteLine("Squirtle used battlecry!");
            Console.WriteLine("Squirtle!");
        }
    }
}
