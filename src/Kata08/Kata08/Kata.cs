using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeKata.Kata08
{
    public static class Kata
    {
        public static IEnumerable<(string, string)> GetSixOfTwo(IEnumerable<string> list)
        {
            // Prefilter list to only contain 6 letter words and shorter
            // This way we do not need to scan the whole list every time
            // And due to the hashmap have fast access to elements
            // We have to use ToLower so that a word starting with a capital
            // Letter will still be recognized in a 6 character word
            var filteredList = list
                .Where(l => l.Length <= 6)
                .Select(l => l.ToLowerInvariant())
                .ToHashSet();

            // Concurrent bag to add result entries concurrently
            var resultSet = new ConcurrentBag<(string, string)>();

            Parallel.ForEach(list, (item) =>
            {
                // Check if item has length of 6
                if (item.Length != 6)
                {
                    return;
                }

                // Split item into (first+last): 1+5, 2+4, 3+3, 4+2, 5+1 and search for each part
                for (int first = 1; first < 6; first++)
                {
                    var firstPart = item[0..first];
                    var lastPart = item[first..6];

                    if (filteredList.Contains(firstPart) && filteredList.Contains(lastPart))
                    {
                        resultSet.Add((firstPart, lastPart));
                    }
                }

            });

            // Return bag
            return resultSet.AsEnumerable();
        }
    }
}
