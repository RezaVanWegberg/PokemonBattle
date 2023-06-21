using System;

namespace PokemonBattle1
{
    class Fennekin : Pokemon
    {
        public Fennekin() : base("Fennekin", Element.Fire, Element.Water) { }

        public override void battleCry()
        {
            Console.WriteLine("Fennekin used battlecry!");
            Console.WriteLine("Fennekin!");
        }
    }
}
