using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle1
{
    abstract class Pokemon
    {
        public enum Element
        {
            Fire,
            Water,
            Grass
        }


        private readonly string name;
        private readonly Element type;
        private readonly Element weakness;

        public Pokemon(string name, Element type, Element weakness)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
        }

        public string Name
        {
            get { return name; }
        }

        public Element Type
        {
            get { return type; }
        }

        public Element Weakness
        {
            get { return weakness; }
        }

        public abstract void battleCry();

    }
}
