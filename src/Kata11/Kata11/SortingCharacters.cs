using System.Text;

namespace CodeKata.Kata11
{
    public class SortingCharacters
    {
        public static string SortedCharacters(string sortMe)
        {
            // All lower case
            var cleanedText = sortMe.ToLowerInvariant();

            // ASCII lower case a-z is 97 - 122
            // We only want ASCII letters

            var asciia = (int)'a';
            var asciiz = (int)'z';

            // Array representing slots for a-z
            // First slot 0 is a, 1 is b ...
            // + 1 for the first letter itself
            var count = new int[asciiz - asciia + 1];

            // Check each position
            for (int i = 0; i < cleanedText.Length; i++)
            {
                var current = cleanedText[i];
                
                // Check if invalid letter
                if(current < asciia || current > asciiz)
                {
                    continue;
                }

                // Find slot, default initialization is 0, we can just increase
                // This also sorts the letters
                count[current - asciia]++;
            }

            // Render slots into letters
            var sb = new StringBuilder();
            for (int i = asciia; i <= asciiz; i++)
            {
                // i - asciia is the position in the array,
                // i itself is the letter
                // append a string to the StringBuilder of the letter
                // and it's frequency of appearance
                sb.Append(new string((char)(i), count[i - asciia]));
            }

            return sb.ToString();
        }
    }
}
