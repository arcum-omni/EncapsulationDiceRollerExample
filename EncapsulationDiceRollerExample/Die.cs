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
        /// <summary>
        /// static members get shared across all instances of this class
        /// </summary>
        private static Random rand;
        private byte faceValue;

        /// <summary>
        /// Runs once before any Die objects are created and initializes Random object once
        /// </summary>
        static Die()
        {
            rand = new Random();
        }

        /// <summary>
        /// Set initial value of die
        /// </summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// The current value of a the die (1-6)
        /// </summary>
        public byte FaceValue
        {
            get { return faceValue; }
            private set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentException("Invalid Face Value");
                }
                faceValue = value; 
            }
        }

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
            // If current die is held, return the current value
            if (IsHeld)
            {
                return FaceValue;
            }

            const byte MinValue = 1; // min die roll
            const byte MaxValue = 6; // max die roll
            const byte Offset = 1;   // offset for Random.Next(lower, upper) lower bound is inclusive, upper bound is exclusive.

            byte newValue = (byte)rand.Next(MinValue, MaxValue + Offset); // cast from int to byte

            FaceValue = newValue;
            return newValue;
        }
    }
}
