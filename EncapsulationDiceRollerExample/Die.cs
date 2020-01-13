using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerExample
{
    /// <summary>
    /// Represents a standard, Vegas style, single six-sided die
    /// </summary>
    class Die
    {
        // static members get shared across all instances of this class
        private static Random rand;

        /// <summary>
        /// Set initial value of die
        /// </summary>
        public Die()
        {
            rand = new Random();
            Roll();
        }

        /// <summary>
        /// The current value of a the die (1-6)
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// Die that are held, are not rolled.
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Generate a new randam face value, roll die.
        /// Sets the face value
        /// Returns the generated face value
        /// </summary>        
        public byte Roll()
        {
            const byte MinValue = 1; // min die roll
            const byte MaxValue = 6; // max die roll
            const byte Offset = 1;   // offset for Random.Next(lower, upper) lower bound is inclusive, upper bound is exclusive.
            
            byte newValue = (byte)rand.Next(MinValue, MaxValue + Offset); // cast from int to byte

            FaceValue = newValue;
            return newValue;
        }
    }
}
