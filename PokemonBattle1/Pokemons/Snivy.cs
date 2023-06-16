using System;

namespace PokemonBattle1
{
    class Snivy : Pokemon
    {
        public Snivy() : base("Snivy", "Grass", "Fire") { }

        public override void battleCry()
        {
            Console.WriteLine("Snivy used battlecry!");
            Console.WriteLine("Snivy!");
        }
    }
}
