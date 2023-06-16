using System;

namespace PokemonBattle1
{
    class Mudkip : Pokemon
    {
        public Mudkip() : base("Mudkip", "Water", "Grass") { }

        public override void battleCry()
        {
            Console.WriteLine("Mudkip used battlecry!");
            Console.WriteLine("Mudkip!");
        }
    }
}
