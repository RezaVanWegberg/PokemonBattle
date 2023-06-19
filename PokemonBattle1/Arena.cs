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
            Trainer.Shuffle(trainer1.belt);
            Trainer.Shuffle(trainer2.belt);

            int currentBattle = 0;
            while (currentBattle == 0)

            {
                Console.WriteLine("------------------");
                Console.WriteLine("");
                Console.WriteLine($"{trainer1.name}'s {trainer1.belt[currentPokemon1].pokemon.name}" );
                Console.WriteLine("");
                Console.WriteLine($"{trainer2.name}'s {trainer2.belt[currentPokemon2].pokemon.name}");
                Console.WriteLine("");
                Console.WriteLine("------------------");


                Battle battle = new Battle();

                winner = battle.battle(trainer1.belt[currentPokemon1].pokemon, trainer2.belt[currentPokemon2].pokemon);
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
                if (trainer1.belt.Count <= currentPokemon1)
                {
                    currentBattle = 1;
                }
                else if (trainer2.belt.Count <= currentPokemon2)
                {
                    currentBattle = 1;
                }
            }
        }
    }
}
