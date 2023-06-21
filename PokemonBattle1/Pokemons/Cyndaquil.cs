using System;

namespace PokemonBattle1
{
    class Cyndaquil : Pokemon
    {
        public Cyndaquil() : base("Cyndaquil", Element.Fire, Element.Water) { }

        public override void battleCry()
        {
            Console.WriteLine("Cyndaquil used battlecry!");
            Console.WriteLine("Cyndaquil!");
        }
    }
}
