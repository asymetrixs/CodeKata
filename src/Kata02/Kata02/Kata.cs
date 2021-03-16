namespace CodeKata.Kata02
{
    public static class Kata
    {
        public static int Chop(int lookFor, int[] source)
        {
            // Check length, is empty, return -1
            if (source.Length == 0)
            {
                return -1;
            }

            // Check length, if only one element in array, check that element
            if (source.Length == 1)
            {
                return (source[0] == lookFor) ? 0 : -1;
            }
            else
            {
                // Split the array in half
                var splitted = Split(source);

                // Check each part
                var rhp = Chop(lookFor, splitted[0].Source);
                var lhp = Chop(lookFor, splitted[1].Source);

                // If value was found
                if (rhp > -1)
                {
                    // Check if source is a part with an offset
                    if(splitted[0].Offset > 0)
                    {
                        // Add the offset
                        rhp += splitted[0].Offset;
                    }
                    
                    return rhp;
                }

                // If value was found
                if (lhp > -1)
                {
                    // Check if source is a part with an offset
                    if (splitted[1].Offset > 0)
                    {
                        // Add the offset
                        lhp += splitted[1].Offset;
                    }

                    return lhp;
                }
            }

            return -1;
        }

        private static SplitOffset[] Split(int[] source)
        {
            // Take half
            int half = source.Length / 2;

            // Left hand part, with length exclusive
            SplitOffset lhp = new(0, source[0..half]);

            // Right hand part
            SplitOffset rhp = new(half, source[half..]);

            return new SplitOffset[] { lhp, rhp };
        }
    }
}
