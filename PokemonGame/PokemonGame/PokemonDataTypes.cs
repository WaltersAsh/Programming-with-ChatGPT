using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame;

public static class PokemonDataTypes
{
    public enum Type
    {
        Normal, 
        Fire,
        Water,
        Grass,
        Electric,
        Ice,
        Fighting,
        Poison,
        Ground,
        Flying,
        Psychic,
        Bug,
        Rock,
        Ghost,
        Dark,
        Dragon,
        Steel,
        Fairy
    }

    public enum PokemonMoveCategory
    {
        Physical,
        Special,
        Status
    }
}

