using System;

namespace CodeKata.Kata02
{
    public static class Kata
    {
        public static int Chop(int lookFor, int[] source)
        {
            if(source.Length == 0)
            {
                return -1;
            }

            if(source.Length == 1)
            {
                return (source[0] == lookFor) ? 0 : -1;
            }

            return int.MaxValue;
        }
    }
}
