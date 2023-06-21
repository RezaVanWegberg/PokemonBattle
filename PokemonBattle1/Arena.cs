using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle1
{

    class Arena
    {
        private Trainer trainer1;
        private Trainer trainer2;
        private GameState winner = GameState.Draw;
        private int currentPokemon1 = 0;
        private int currentPokemon2 = 0;
        public Arena(Trainer trainer1, Trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
        }

        public void arenaBattle()
        {
            Trainer.Shuffle(trainer1.Belt);
            Trainer.Shuffle(trainer2.Belt);

            int currentBattle = 0;
            while (currentBattle == 0)

            {
                Console.WriteLine("------------------");
                Console.WriteLine("");
                Console.WriteLine($"{trainer1.Name}'s {trainer1.Belt[currentPokemon1].Pokemon.Name}" );
                Console.WriteLine("");
                Console.WriteLine($"{trainer2.Name}'s {trainer2.Belt[currentPokemon2].Pokemon.Name}");
                Console.WriteLine("");
                Console.WriteLine("------------------");


                Battle battle = new Battle();

                winner = battle.battle(trainer1.Belt[currentPokemon1].Pokemon, trainer2.Belt[currentPokemon2].Pokemon);
                Thread.Sleep(1000);

                if (winner == GameState.Draw)
                {
                    currentPokemon1++;
                    currentPokemon2++;
                }
                else if (winner == GameState.Trainer1)
                {
                    currentPokemon1++;
                }
                else
                {
                    currentPokemon2++;
                }
                if (trainer1.Belt.Count <= currentPokemon1)
                {
                    currentBattle = 1;
                }
                else if (trainer2.Belt.Count <= currentPokemon2)
                {
                    currentBattle = 1;
                }
            }
        }
    }
}
