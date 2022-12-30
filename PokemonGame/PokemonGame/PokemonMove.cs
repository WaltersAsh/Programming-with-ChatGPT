using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame;

public class PokemonMove : IPokemonMove
{
    public string Name { get; set; }
    public PokemonDataTypes.Type Type { get; set; }
    public PokemonDataTypes.PokemonMoveCategory Category { get; set; }
    public int Pp { get; set; }
    public int Power { get; set; }
    public decimal Accuracy { get; set; }
}
