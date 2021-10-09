using System;

<<<<<<< HEAD
namespace UC_2_diceRoll
{
    class UC_2_diceRoll
=======
namespace UC_3_optionsCheck
{
    class UC_3_optionsCheck
>>>>>>> UC_3checkoptions
    {
        static void Main(string[] args)
        {
            Random random = new Random();
<<<<<<< HEAD
            int diceRoll = random.Next(0, 7);
            Console.WriteLine("You got " + diceRoll + " in dice roll.");
=======
            int diceRoll = random.Next(1, 6);
            Console.WriteLine("You got " + diceRoll);
            //Constants
            const int samePosition = 0;
            const int forward = 1;
            Random random1 = new Random();
            int options = random1.Next(0, 2);
            if (options == samePosition)
            {
                Console.WriteLine("You Got No Option Stay in the Same Place.");
            }
            else if (options == forward)
            {
                Console.WriteLine("You Got Ladder Your moving ahead by " + diceRoll + " numbers.");
            }
            else
                Console.WriteLine("You Got Snake Your Moving Backward by " + diceRoll + " numbers.");
>>>>>>> UC_3checkoptions
        }
    }
}