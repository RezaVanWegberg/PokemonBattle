using System;

namespace PokemonBattle1
{
	class Charmander : Pokemon
    {
        public Charmander() : base("Charmander", Element.Fire, Element.Water) { }
        
        public override void battleCry()
        {
            Console.WriteLine("Charmander used battlecry!");
            Console.WriteLine("Charmander!");
        }
}
}
