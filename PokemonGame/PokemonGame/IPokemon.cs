using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame;

public interface IPokemon
{
    int Attack();
    int CalculateDamage(PokemonDataTypes.Type moveType, PokemonDataTypes.Type opponentPokemonType, int damage);
    void TakeDamage(int damage);
    bool IsFainted();
    void gainExp(int exp);
}
