using System;

namespace PokemonBattle1
{
    class Rowlet : Pokemon
    {
        public Rowlet() : base("Rowlet", "Grass", "Fire") { }

        public override void battleCry()
        {
            Console.WriteLine("Rowlet used battlecry!");
            Console.WriteLine("Rowlet!");
        }
    }
}
