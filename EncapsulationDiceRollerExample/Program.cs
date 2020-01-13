using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dice = new Die[5];

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }

            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(dice[i].FaceValue);
            }


            /*
            Die myDice = new Die();
            

            Console.WriteLine(myDice.FaceValue);

            myDice.Roll();

            Console.WriteLine(myDice.FaceValue);

            */

            Console.ReadKey();
        }
    }
}
