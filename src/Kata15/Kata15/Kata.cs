using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata.Kata15
{
    public static class Kata
    {
        /// <summary>
        /// Generates the bit sequence
        /// </summary>
        /// <param name="digits">Amount of digits</param>
        /// <returns></returns>
        public static int[] GenerateSequence(int digits)
        {
            // Could be moved into FindWithoutTwoAdjacent1bits but is here
            // so it can be tested
            return Enumerable.Range(0, (int)Math.Pow(2, digits)).ToArray();
        }

        /// <summary>
        /// Returns a list of numbers that have two bits set
        /// </summary>
        /// <param name="list">List of numbers to test</param>
        /// <returns></returns>
        public static int[] FindWithoutTwoAdjacent1Bits(int[] list)
        {
            // Bit representation of 3 is MSB->LSB: 11
            const int twoAdjacentBits = 3;

            // Result set
            var result = new HashSet<int>();

            // Comparing the twoAdjacentBits with bitshifting to the list of integers
            for (int i = 0; i < list.Length; i++)
            {
                var current = list[i];

                // Shifting starting point
                int shiftingBits = twoAdjacentBits;

                // If current is smaller it cannot have as many consecutive bits
                // therefore, add
                if (current < shiftingBits)
                {
                    if (!result.Contains(current))
                    {
                        result.Add(current);
                    }
                }
                else
                {
                    // Flag, indicating check found nothing or something
                    bool doesNotHaveTwoAdjacentBits = true;

                    // Try as long as shiftingBits is smaller than or equal to current
                    while (current >= shiftingBits)
                    {
                        // If bits match, the combination is present, thus the value
                        // does have two adjacent bits and has to be excluded
                        if ((current & shiftingBits) == shiftingBits)
                        {
                            doesNotHaveTwoAdjacentBits = false;
                            break;
                        }

                        // Shift bits to the left for next check
                        shiftingBits <<= 1;
                    }

                    // If current does not have two adjacent bits
                    // add it to the list
                    if (doesNotHaveTwoAdjacentBits && !result.Contains(current))
                    {
                        result.Add(current);
                    }
                }
            }

            // Return list as array
            return result.ToArray();
        }
    }
}
