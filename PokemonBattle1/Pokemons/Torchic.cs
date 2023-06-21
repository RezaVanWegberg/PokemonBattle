using System;

namespace PokemonBattle1
{
    class Torchic : Pokemon
    {
        public Torchic() : base("Torchic", Element.Fire, Element.Water) { }

        public override void battleCry()
        {
            Console.WriteLine("Torchic used battlecry!");
            Console.WriteLine("Torchic!");
        }
    }
}
