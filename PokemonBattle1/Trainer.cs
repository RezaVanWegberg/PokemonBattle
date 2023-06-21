using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle1
{
    class Trainer
    {
        private List<Pokeball> belt;
        private string name;

        public Trainer(string name)
        {
            this.name = name;
            belt = new List<Pokeball>();
        }

        public List<Pokeball> Belt
        {
            get { return belt; }
        }

        public string Name
        { 
            get { return name; } 
        }

        public void givePokeball(Pokeball pokeball)
        {
            if (belt.Count < 6)
            {
            belt.Add(pokeball);

            } else
            {
                throw new Exception("The belt is full.");
            }
        }

        public void throwPokeball(int number, string name)
        {
            Console.WriteLine(name + " throws a pokeball");
            Thread.Sleep(300);
            
            Pokeball pokeball = belt[number];

            pokeball.Thrown();
            
        }


        public void returnToPokeball(int number, string name)
        {
            Console.WriteLine(name + " returns " + belt[number].Pokemon.Name);

            Pokeball pokeball = belt[number];

            pokeball.Close();
        }

        public static void Shuffle<T>(List<T> list)
        {
            Random random = new Random();

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }

}
