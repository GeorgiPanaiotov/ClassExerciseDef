using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer()
        {
            NumberOfBadges = 0;
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public Pokemon Pokemon { get; set; }
    }

}
