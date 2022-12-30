using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame;

public class Pokemon : IPokemon
{
    // Private fields for the name, current hit points, and attack points
    private string name { get; set; }
    private int attackPoints { get; set; }
    private int exp { get; set; }

    public int Level { get; set; }
    public int HitPoints { get; set; }
    public PokemonDataTypes.Type Type { get; set; }
    public List<PokemonMove> Moves = new List<PokemonMove>
    {
        new PokemonMove()
        {
            Name = "Electroweb",
            Type = PokemonDataTypes.Type.Electric,
            Category = PokemonDataTypes.PokemonMoveCategory.Special,
            Pp = 15,
            Power = 55,
            Accuracy = 0.95M
        },
        new PokemonMove()
        {
            Name = "Thunderbolt",
            Type = PokemonDataTypes.Type.Electric,
            Category = PokemonDataTypes.PokemonMoveCategory.Special,
            Pp = 15,
            Power = 90,
            Accuracy = 1M
        },
        new PokemonMove()
        {
            Name = "Iron Tail",
            Type = PokemonDataTypes.Type.Steel,
            Category = PokemonDataTypes.PokemonMoveCategory.Physical,
            Pp = 15,
            Power = 100,
            Accuracy = 0.75M
        },
        new PokemonMove()
        {
            Name = "Quick Attack",
            Type = PokemonDataTypes.Type.Normal,
            Category = PokemonDataTypes.PokemonMoveCategory.Physical,
            Pp = 30,
            Power = 40,
            Accuracy = 1M
        }
    };

    // Constructor for creating a Pokemon
    public Pokemon(string name, int level, int hitPoints, int attackPoints, PokemonDataTypes.Type type)
    {
        this.Level = level;
        this.name = name;
        this.HitPoints = hitPoints;
        this.attackPoints = attackPoints;
        this.Type = type;
    }

    // Method for the Pokemon to attack
    public int Attack()
    {
        return attackPoints;
    }

    // Method for the Pokemon to take damage
    public void TakeDamage(int damage)
    {
        HitPoints -= damage;
    }

    // Method to check if the Pokemon has fainted
    public bool IsFainted()
    {
        return HitPoints <= 0;
    }

    // Method to calculate damage based on type advantage/disadvantage
    public int CalculateDamage(PokemonDataTypes.Type moveType, PokemonDataTypes.Type opponentPokemonType, 
        int damage)
    {
        if (moveType is PokemonDataTypes.Type.Electric && opponentPokemonType is PokemonDataTypes.Type.Water)
        {
            return damage * 2;
        }

        return damage;
    }

    // Method to gain exp after successful Pokemon battles
    public void gainExp(int exp)
    {
        this.exp += exp;
    }
}
