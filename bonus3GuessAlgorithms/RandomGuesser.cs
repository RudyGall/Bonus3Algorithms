using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus3GuessAlgorithms
{
    class RandomGuesser : Guesser
    {
        Random random = new Random();
        public override int Guess()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();
            int randomGuess = random.Next(0, numbers.Length);
            return numbers[randomGuess];
        }
    }
}
