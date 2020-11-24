using System;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            Trainer trainer = new Trainer();
            Pokemon pokemons = new Pokemon();

            while (commands[0] != "Tournament")
            {
                trainer = new Trainer();
                trainer.Name = commands[0];
                pokemons = new Pokemon();
                pokemons.Name = commands[1];
                pokemons.Element = commands[2];
                pokemons.Health = int.Parse(commands[3]);
                trainer.Pokemon = pokemons;
            }
        }
    }
}
