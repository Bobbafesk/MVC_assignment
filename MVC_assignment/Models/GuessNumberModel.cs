using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_assignment.Models
{
   
    public class GuessNumberModel
    {
        static Random rndGenerator = new Random();

        public static int GenerateRandomNumber()
        {
            return rndGenerator.Next(1, 101);
        }

        public static string GuessANumber(int guessedNumber, int rndNumber)
        {
            
            while (guessedNumber != rndNumber)
            {
                if (guessedNumber > rndNumber)
                {
                    return $"The number {guessedNumber} is to high, guess on a new number.";
                }
                if (guessedNumber < rndNumber)
                {
                    return $"The number {guessedNumber} is to small, guess on a new number.";
                }
            }
            return $"Well done! The answer was {rndNumber}.";
        }
    }
}
