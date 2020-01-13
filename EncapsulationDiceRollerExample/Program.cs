using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerExample
{
    class Program
    {
        /// <summary>
        /// Main needs 10 lines or less
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Die[] dice = new Die[5]; // Create dice array
            InitDice(dice);
            Console.WriteLine("Initial Dice Face Values"); 
            PrintDieFaceValues(dice);
            HoldDice(dice);
            Console.WriteLine("\nDice 1-3 Are Held,\nDice Re-Rolled");
            RollAllDice(dice);
            PrintDieFaceValues(dice);
            Console.ReadKey();
        }

        /// <summary>
        /// Roll Dice in Array
        /// </summary>
        /// <param name="dice"></param>
        private static void RollAllDice(Die[] dice)
        {
            // ReRoll Dice
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();
            }
        }

        /// <summary>
        /// Holds first three dice,
        /// For testing purposes.
        /// </summary>
        /// <param name="dice"></param>
        private static void HoldDice(Die[] dice)
        {
            // Hold dice 1-3
            for (int i = 0; i < 3; i++)
            {
                dice[i].IsHeld = true;
            }
        }

        /// <summary>
        /// Displays die face values
        /// </summary>
        /// <param name="dice"></param>
        private static void PrintDieFaceValues(Die[] dice)
        {
            // Display the dice face values
            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(dice[i].FaceValue);
            }
        }

        /// <summary>
        /// Initializes all die in a given array,
        /// Assumes array has a length
        /// </summary>
        /// <param name="dice"></param>
        private static void InitDice(Die[] dice)
        {
            // Instantiate 5 dice
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }
    }
}
