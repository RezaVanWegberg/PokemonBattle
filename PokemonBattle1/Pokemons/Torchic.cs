using System;

namespace PokemonBattle1
{
    class Torchic : Pokemon
    {
        public Torchic() : base("Torchic", "Fire", "Water") { }

        public override void battleCry()
        {
            Console.WriteLine("Torchic used battlecry!");
            Console.WriteLine("Torchic!");
        }
    }
}
