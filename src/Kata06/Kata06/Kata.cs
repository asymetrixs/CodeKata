using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeKata.Kata06
{
    public static class Kata
    {
        /// <summary>
        /// Dictionary will hold all words
        /// </summary>
        public static ConcurrentDictionary<string, List<string>> Words { get; } = new();

        /// <summary>
        /// Searches in <paramref name="data"/> for anagrams
        /// </summary>
        /// <param name="data">Data to search through, one term per line.</param>
        public static void SearchForAnagrams(string[] data)
        {
            Parallel.ForEach(data, (text) =>
            {
                // Skip empty strings
                if (string.IsNullOrWhiteSpace(text))
                {
                    return;
                }

                // Lower case
                text = text.ToLowerInvariant();

                // Get letter count
                string letters = string.Concat(text.OrderBy(c => c));

                // Add/update dictionary
                Words.AddOrUpdate(letters, new List<string> { text }, (letterCount, oldValue) =>
                {
                    oldValue.Add(text);
                    return oldValue;
                });
            });
        }
    }
}
