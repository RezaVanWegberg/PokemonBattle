using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle1
{
    class Pokemon
    {
        public string name;
        public string type;
        public string weakness;

        public Pokemon(string inputName, string inputType, string inputWeakness)
        {
            name = inputName;
            type = inputType;
            weakness = inputWeakness;
        }

        public void battleCry()
        {
            Console.WriteLine(name + " used battlecry!");
            Console.WriteLine(name + "!");
        }
    }
}
