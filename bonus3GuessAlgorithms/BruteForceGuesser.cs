using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus3GuessAlgorithms
{
    class BruteForceGuesser : Guesser
    {
        int index = 0;
        public override int Guess()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();
            index++;
            return numbers[index - 1];
        }
    }
}
