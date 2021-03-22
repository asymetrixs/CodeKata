using System.Linq;

namespace CodeKata.Kata11
{
    public class Kata11
    {
        public static int[] AddAndSort(int[] sortedList, int? number)
        {
            // Check if something is to be added
            if(number is not null)
            {
                // Make array a list to be more flexible on addition
                var tmp = sortedList.ToList();
                
                // Flag indicating if a value was added
                bool added = false;
                for (int i = 0; i < sortedList.Length; i++)
                {
                    // Check list, find first item that is bigger than the one
                    // that is to be added
                    if(sortedList[i] > number)
                    {
                        // Insert item
                        tmp.Insert(i, number.Value);

                        // Flag that it was added
                        added = true;
                    }
                }

                // If was not added, append
                if(!added)
                {
                    tmp = tmp.Append(number.Value).ToList();
                }

                // Convert back to array
                sortedList = tmp.ToArray();
            }

            return sortedList;
        }
    }
}
