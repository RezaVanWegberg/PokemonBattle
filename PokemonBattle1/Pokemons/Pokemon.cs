using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle1
{
    abstract class Pokemon
    {
        public string name;
        public string type;
        public string weakness;

        public Pokemon(string name, string type, string weakness)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
        }

        public abstract void battleCry();
        
    }
}
