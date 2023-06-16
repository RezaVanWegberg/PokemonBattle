using System;

namespace PokemonBattle1
{
    class Chikorita : Pokemon
    {
        public Chikorita() : base("Chikorita", "Grass", "Fire") { }

        public override void battleCry()
        {
            Console.WriteLine("Chikorita used battlecry!");
            Console.WriteLine("Chikorita!");
        }
    }
}
