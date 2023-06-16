using System;

namespace PokemonBattle1
{
    class Cyndaquil : Pokemon
    {
        public Cyndaquil() : base("Cyndaquil", "Fire", "Water") { }

        public override void battleCry()
        {
            Console.WriteLine("Cyndaquil used battlecry!");
            Console.WriteLine("Cyndaquil!");
        }
    }
}
