using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle1
{
    abstract class Pokemon
    {
        private readonly string name;
        private readonly string type;
        private readonly string weakness;

        public Pokemon(string name, string type, string weakness)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
        }

        public string Name
        {
            get { return name; }
        }

        public string Type
        {
            get { return type; }
        }

        public string Weakness
        {
            get { return weakness; }
        }

        public abstract void battleCry();

    }
}
