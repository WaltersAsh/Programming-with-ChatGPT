using System;
using System.Linq;

namespace PokemonGame;

public class PokemonBattle
{
    static void Main(string[] args)
    {
        // Create two Pokemon objects
        Pokemon pikachu = new Pokemon("Pikachu", 50, 500, 10, PokemonDataTypes.Type.Electric);
        Pokemon magikarp = new Pokemon("Magikarp", 25, 250, 12, PokemonDataTypes.Type.Water);

        // Start the battle
        Console.WriteLine("A wild Magikarp appeared!\n");
        Console.WriteLine("Go, Pikachu!\n");

        // Loop until one of the Pokemon faints
        while (pikachu.IsFainted() == false && magikarp.IsFainted() == false)
        {
            // Display current hit points
            Console.WriteLine("Pikachu: " + pikachu.HitPoints + " HP");
            Console.WriteLine("Magikarp: " + magikarp.HitPoints + " HP");

            // Display available moves for Pikachu
            Console.WriteLine("Choose a move:");
            for (int i = 0; i < pikachu.Moves.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + pikachu.Moves.ElementAt(i).Name);
            }

            // Get the player's move choice
            int moveChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Pikachu attacks based on the player's choice
            PokemonMove chosenMove = pikachu.Moves.ElementAt(moveChoice - 1);
            int damage = chosenMove.Power;

            // Check for critical hit
            Random rand = new Random();
            int criticalHitChance = rand.Next(1, 101);
            if (criticalHitChance <= 20)
            {
                Console.WriteLine("Critical hit!");
                damage *= 2;
            }

            // Calculate type advantage and apply damage
            damage = pikachu.CalculateDamage(chosenMove.Type, magikarp.Type, damage);
            magikarp.TakeDamage(damage);
            Console.WriteLine("Pikachu used " + chosenMove.Name + " and dealt " + damage + " damage to Magikarp.");

            // Check if Magikarp fainted
            if (magikarp.IsFainted())
            {
                Console.WriteLine("Magikarp fainted!\n" +
                    "Pikachu gained 10 exp points!");
                pikachu.gainExp(10);
                break;
            }

            // Magikarp attacks next
            Console.WriteLine("Magikarp used splash!\n" +
                "But it did nothing.\n");

            // Check if Pikachu fainted
            if (pikachu.IsFainted())
            {
                Console.WriteLine("Pikachu fainted!\n" +
                    "You are out of usable Pokemon!\n" +
                    "You scurry back to the Pokémon Center, protecting your exhausted Pokémon from any further harm...");
                break;
            }
        }
    }
}