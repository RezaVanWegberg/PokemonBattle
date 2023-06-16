using System;

namespace PokemonBattle1
{
    class Fennekin : Pokemon
    {
        public Fennekin() : base("Fennekin", "Fire", "Water") { }

        public override void battleCry()
        {
            Console.WriteLine("Fennekin used battlecry!");
            Console.WriteLine("Fennekin!");
        }
    }
}
